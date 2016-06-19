using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProGruppoInfo
{
    public partial class MainForm : Form
    {
        int n = 0;
        public static float dt, g, mua, m, v0, t0, epsilon, vt, tf;
        Bitmap bitmap, buffer, soglieb;
        Graphics gr;
        float maxY, maxX;
        Point origin;
        Point[] points;
        PointF[] originalPoints;
        SoglieView soglieForm;

        #region Inizializzazione
        public MainForm() // Costruttore
        {
            InitializeComponent();
            soglieForm = new SoglieView();
        }

        private void panel2_Paint(object sender, PaintEventArgs e) // Prepara buffer e disegna sfondo iniziale
        {
            bitmap = new Bitmap(panel2.Width, panel2.Height);
            buffer = new Bitmap(panel2.Width, panel2.Height);
            gr = Graphics.FromImage(bitmap);
            DrawAxes();
            panel2.CreateGraphics().DrawImage(bitmap, 0, 0);
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e) // Aggiorna dimensione buffer se form ingrandita
        {
            bitmap = new Bitmap(panel2.Width, panel2.Height);
            gr = Graphics.FromImage(bitmap);
            DrawAxes();
            panel2.CreateGraphics().DrawImage(bitmap, 0, 0);
        } 
        #endregion

        #region Disegno Grafici
        // Disegna i dati
        private void DrawData()
        {
            gr.SmoothingMode = SmoothingMode.HighQuality; // Antialiasing
            DrawAxes(); // Disegna assi

            // Trova il massimo
            maxY = 1f;
            for (int i = 0; i < n; i++)
                if ((float)data.Rows[i].Cells[1].Value > maxY)
                    maxY = (float)data.Rows[i].Cells[1].Value;
            maxY = maxY / 4f * 5f; // Riduce il massimo a 4/5

            // Trova i punti, interpola
            points = new Point[panel2.Width - 30];
            originalPoints = new PointF[panel2.Width - 30];
            float yval1 = 0, yval2 = 0;
            for (int x = 0; x < points.Length; x++)
            {
                int index1 = (int)Math.Floor((float)x / (float)(points.Length) * (float)(n)); // Indici nei dati
                int index2 = (int)Math.Ceiling((float)x / (float)(points.Length) * (float)(n));
                if (index2 < n && index1 >= 0)
                {
                    yval1 = (float)data.Rows[index1].Cells[1].Value / maxY * (origin.Y - 30); // Valori di Y
                    yval2 = (float)data.Rows[index2].Cells[1].Value / maxY * (origin.Y - 30);

                    // Calcola X e Y interpolando due punti
                    float px = x + 40f, py = origin.Y - Linear(((float)x % ((float)points.Length / (float)n)) / ((float)points.Length / (float)n), yval1, yval2);
                    points[x] = new Point((int)px, (int)py);

                    // Aggiunge valore X e Y originale interpolato a originalPoints per il popup dei valori
                    originalPoints[x] = new PointF((float)Math.Round(Linear(((float)x % ((float)points.Length / (float)n)) / ((float)points.Length / (float)n), // X
                        (float)data.Rows[index1].Cells[0].Value, (float)data.Rows[index2].Cells[0].Value), 3),
                        (float)Math.Round(Linear(((float)x % ((float)points.Length / (float)n)) / ((float)points.Length / (float)n), // Y
                        (float)data.Rows[index1].Cells[1].Value, (float)data.Rows[index2].Cells[1].Value), 3));
                }
                else if (index2 > n)
                    maxX = x;
            }

            // Disegna i punti collegati
            for (int i = 1; i < points.Length; i++)
                if (points[i - 1].X != 0 && points[i].X != 0)
                    gr.DrawLine(new Pen(new SolidBrush(Color.DarkSlateBlue), 2.5f), points[i - 1], points[i]);

            // Limite Tratteggiato
            gr.DrawLine(new Pen(new SolidBrush(Color.DarkRed), 1f) { DashStyle = DashStyle.Dash }, origin.X - 15, origin.Y - yval2, panel2.Width, origin.Y - yval2);
            gr.DrawString(Math.Round(vt, 2).ToString(), new Font("Arial", 10, FontStyle.Italic), new SolidBrush(Color.Black), 10, origin.Y - yval2 - 15);
            gr.DrawString("reale=\n" + Math.Round(g * m / mua, 2).ToString(), new Font("Arial", 7, FontStyle.Italic), new SolidBrush(Color.DarkRed), 10, origin.Y - yval2);

            // Avviso Grafico
            if (data.RowCount > 3 && (float)data.Rows[1].Cells[1].Value > (float)data.Rows[2].Cells[1].Value)
                gr.DrawString("Avviso: grafico errato, dt troppo grande", new Font("Arial", 10, FontStyle.Bold),
                    new SolidBrush(Color.Red), origin.X + 15, origin.Y + 5);
        }

        private void DrawAxes() // Disegna Assi
        {
            Rectangle rect = new Rectangle(0, 0, panel2.Width, panel2.Height);
            gr.FillRectangle(new System.Drawing.Drawing2D.LinearGradientBrush(rect, Color.White, Color.FromArgb(149, 173, 173), 90), rect); // Sfumatura
            origin = new Point(40, panel2.Height - 30);

            // Asse Y
            gr.DrawLine(new Pen(new SolidBrush(Color.Black), 2f), origin.X, origin.Y + 15, 40, 30);
            gr.DrawLine(new Pen(new SolidBrush(Color.Black), 2f), 40, 30, 35, 35);
            gr.DrawLine(new Pen(new SolidBrush(Color.Black), 2f), 40, 30, 45, 35);
            gr.DrawString("v", new Font("Arial", 12, FontStyle.Italic), new SolidBrush(Color.Black), 20, 35);

            // Asse X
            gr.DrawLine(new Pen(new SolidBrush(Color.Black), 2f), origin.X - 15, origin.Y, panel2.Width - 30, origin.Y);
            gr.DrawLine(new Pen(new SolidBrush(Color.Black), 2f), panel2.Width - 30, origin.Y, panel2.Width - 35, origin.Y + 5);
            gr.DrawLine(new Pen(new SolidBrush(Color.Black), 2f), panel2.Width - 30, origin.Y, panel2.Width - 35, origin.Y - 5);
            gr.DrawString("t", new Font("Arial", 12, FontStyle.Italic), new SolidBrush(Color.Black), panel2.Width - 60, origin.Y + 5);
        }

        private void Draw_Click(object sender, EventArgs e) // Disegna i punti calcolati
        {
            CalculateData(); // Calcola i dati
            DrawData(); // Disegna
            panel2.CreateGraphics().DrawImage(bitmap, 0, 0);
        }

        private void DrawPoints_Click(object sender, EventArgs e) // Disegna punti senza calcolare
        {
            n = data.RowCount - 1;
            epsilon = float.Parse(tht.Text);
            for (int i = 0; i < n; i++) // Converte tutti i dati in float
            {
                data.Rows[i].Cells[0].Value = float.Parse(data.Rows[i].Cells[0].Value.ToString());
                data.Rows[i].Cells[1].Value = float.Parse(data.Rows[i].Cells[1].Value.ToString());
            }

            // Trova le accellerazioni
            for (int i = 1; i < n; i++)
            {
                float dt = (float)data.Rows[i].Cells[0].Value - (float)data.Rows[i - 1].Cells[0].Value;
                float dv = (float)data.Rows[i].Cells[1].Value - (float)data.Rows[i - 1].Cells[1].Value;
                data.Rows[i - 1].Cells[2].Value = dv / dt;
            }

            // Calcola vt
            vt = VtFromData(out tf);
            label9.Text = "Vt = " + vt + " (t = " + tf + "), Vt calcolata = " + (g * m / mua);

            DrawData(); // Disegna
            panel2.CreateGraphics().DrawImage(bitmap, 0, 0);
        } 
        #endregion

        #region Dati
        // Calcola i dati
        private void CalculateData()
        {
            // Legge dalla form
            n = int.Parse(nct.Text);
            dt = float.Parse(dtt.Text); g = float.Parse(gt.Text);
            mua = float.Parse(muat.Text); m = float.Parse(mt.Text);
            v0 = float.Parse(v0t.Text); t0 = float.Parse(t0t.Text);
            epsilon = float.Parse(tht.Text);

            data.Rows.Clear();
            data.Rows.Add();
            data.Rows[0].Cells[0].Value = t0;
            data.Rows[0].Cells[1].Value = v0;
            data.Rows[0].Cells[2].Value = g;
            for (int i = 1; i < n; i++)
            {
                data.Rows.Add();
                float pt = (float)data.Rows[i - 1].Cells[0].Value;
                float pv = (float)data.Rows[i - 1].Cells[1].Value;
                float pa = (float)data.Rows[i - 1].Cells[2].Value;
                data.Rows[i].Cells[0].Value = pt + dt;
                data.Rows[i].Cells[1].Value = pv + pa * dt;
                data.Rows[i].Cells[2].Value = -(mua / m) * (float)data.Rows[i].Cells[1].Value + g;
            }

            vt = VtFromData(out tf);
            label9.Text = "Vt = " + vt + " (t = " + tf + "), Vt calcolata = " + (g * m / mua);
        }

        // Trova la velocità terminale con i dati
        private float VtFromData(out float time)
        {
            for (int i = 1; i < n; i++)
            {
                if ((float)data.Rows[i].Cells[1].Value - (float)data.Rows[i - 1].Cells[1].Value < epsilon)
                {
                    data.Rows[i].Selected = true;
                    time = (float)data.Rows[i].Cells[0].Value;
                    return (float)data.Rows[i].Cells[1].Value;
                }
            }
            time = float.PositiveInfinity;
            return float.PositiveInfinity;
        }

        // Trova tau con i dati
        private float TauFromData()
        {
            // Legge dati dalla form
            dt = float.Parse(dtt.Text);
            g = float.Parse(gt.Text);
            mua = float.Parse(muat.Text);
            m = float.Parse(mt.Text);
            float tdt = dt; // dt temporaneo
            for (float i = 1f; i < 1000000; i++)
            {
                float a = g - mua / m * g * tdt; // Calcola accelerazione
                tdt = tdt == 0 ? 0.1f : tdt; // Evita che tdt sia 0
                if (a < 0)
                    tdt -= tdt / i;
                else if (a > 0)
                    tdt += tdt / i;
                else break;

                i++;
            }
            return tdt;
        }
        #endregion

        #region File IO
        private void Save_Click(object sender, EventArgs e) // Salva Immagine
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                bitmap.Save(dialog.FileName);
        }

        private void LoadData_Click(object sender, EventArgs e) // Carica CSV
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] file = System.IO.File.ReadAllLines(dialog.FileName);
                n = file.Length;
                for (int i = 0; i < n; i++)
                {
                    data.Rows.Clear();
                    data.Rows.Add();
                    string[] explode = file[i].Split(';');
                    data.Rows[i].Cells[0].Value = float.Parse(explode[0]);
                    data.Rows[i].Cells[1].Value = float.Parse(explode[1]);
                    data.Rows[i].Cells[2].Value = float.Parse(explode[2]);
                }
            }
        }

        private void SaveData_Click(object sender, EventArgs e) // Salva CSV
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = "";
                for (int i = 0; i < n; i++)
                    file += (float)data.Rows[i].Cells[0].Value + ";" + (float)data.Rows[i].Cells[1].Value + ";"
                        + (float)data.Rows[i].Cells[1].Value + ";" + Environment.NewLine;
                System.IO.File.WriteAllText(dialog.FileName, file);
            }
        } 
        #endregion

        #region Riquadro Valore
        private void panel2_MouseUp(object sender, MouseEventArgs e) // Ridisegna quando mouse smette di cliccare
        {
            panel2.CreateGraphics().DrawImage(bitmap, 0, 0);
        }

        private void panel2_MouseLeave(object sender, EventArgs e) // Ridisegna quando mouse esce
        {
            panel2.CreateGraphics().DrawImage(bitmap, 0, 0);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e) // Ridisegna la finestra quando mouse muove
        {
            if (e.Button == MouseButtons.Left)
                DrawValueBox(e);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e) // Disegna la finestra quando mouse clicca
        {
            DrawValueBox(e);
        }

        private void DrawValueBox(MouseEventArgs e) // Disegna la finestra sul buffer
        {
            if (points != null && e.Location.X - 40 < (maxX != 0 ? maxX : 99999)
                && e.Location.X > 40 && e.Location.X < panel2.Width) // Se mouse sul grafico
            {
                Graphics g = Graphics.FromImage(buffer);
                g.DrawImage(bitmap, 0, 0); // Sfondo e grafico
                g.FillEllipse(Brushes.Gray, (float)points[e.Location.X - 40].X - 3f, (float)points[e.Location.X - 40].Y - 3f, 6f, 6f); // Pallina
                g.DrawLine(Pens.Gray, points[e.Location.X - 40], new Point((int)Clamp(e.Location.X - 1 + 19, 0, panel2.Width - 101), points[e.Location.X - 40].Y - 10)); // Linea
                g.DrawRectangle(Pens.DodgerBlue, Clamp(e.Location.X - 1 + 20, 0, panel2.Width - 101), points[e.Location.X - 40].Y - 21, 101, 16); // Bordo
                g.FillRectangle(Brushes.White, Clamp(e.Location.X + 20, 0, panel2.Width - 100), points[e.Location.X - 40].Y - 20, 100, 15); // Rettangolo
                g.DrawString("T: " + originalPoints[e.Location.X - 40].X + " V: " + originalPoints[e.Location.X - 40].Y, // Testo
                    new Font("Arial", 9, FontStyle.Regular), new SolidBrush(Color.Black), Clamp(e.Location.X + 20, 0, panel2.Width - 100), points[e.Location.X - 40].Y - 20);
                panel2.CreateGraphics().DrawImage(buffer, 0, 0); // Riquadro
            }
        } 
        #endregion

        #region Soglie
        private void DrawSoglie() // Disegna finestra soglie
        {
            soglieb = new Bitmap(soglieForm.Width, soglieForm.Height);
            Graphics sgr = Graphics.FromImage(soglieb);
            Rectangle rect = new Rectangle(0, 0, soglieForm.Width, soglieForm.Height);
            sgr.FillRectangle(new System.Drawing.Drawing2D.LinearGradientBrush(rect, Color.White, Color.FromArgb(149, 173, 173), 90), rect);
            int width = soglieForm.Width / 5 - 5;
            sgr.DrawImage(Resource1._1, new Rectangle(0, 0, width, soglieForm.Height - 70));
            sgr.DrawImage(Resource1._2, new Rectangle(width, 0, width, soglieForm.Height - 70));
            sgr.DrawImage(Resource1._3, new Rectangle(width * 2, 0, width, soglieForm.Height - 70));
            sgr.DrawImage(Resource1._4, new Rectangle(width * 3, 0, width, soglieForm.Height - 70));
            sgr.DrawImage(Resource1._5, new Rectangle(width * 4, 0, width, soglieForm.Height - 70));
            DrawSoglieText();
        }

        private void DrawSoglieText() // Disegna testo finestra soglie
        {
            try
            {
                int width = soglieForm.Width / 5 - 5;
                Graphics sgrf = soglieForm.CreateGraphics();
                sgrf.DrawImage(soglieb, 0, 0);
                mua = float.Parse(muat.Text); m = float.Parse(mt.Text);
                float tau = TauFromData();
                sgrf.DrawString("con dt < " + Math.Round(tau, 2), new Font("Arial", 12, FontStyle.Italic), new SolidBrush(Color.Black), 10, soglieForm.Height - 65);
                sgrf.DrawString("con dt = " + Math.Round(tau, 2), new Font("Arial", 12, FontStyle.Italic), new SolidBrush(Color.Black), width + 10, soglieForm.Height - 65);
                sgrf.DrawString("con dt > " + Math.Round(tau, 2), new Font("Arial", 12, FontStyle.Italic), new SolidBrush(Color.Black), 2 * width + 10, soglieForm.Height - 65);
                sgrf.DrawString("con dt = " + Math.Round(2f * tau, 2), new Font("Arial", 12, FontStyle.Italic), new SolidBrush(Color.Black), 3 * width + 10, soglieForm.Height - 65);
                sgrf.DrawString("con dt > " + Math.Round(2f * tau, 2), new Font("Arial", 12, FontStyle.Italic), new SolidBrush(Color.Black), 4 * width + 10, soglieForm.Height - 65);
            }
            catch (Exception) { }
        }

        private void soglie_Click(object sender, EventArgs e) // Mostra form soglie
        {
            if (soglieForm.Visible == true)
                soglieForm.Hide();
            else
            {
                soglieForm.StartPosition = FormStartPosition.Manual;
                soglieForm.Location = new Point(this.Location.X + (this.Width / 2) - (soglieForm.Width / 2), this.Location.Y + this.Height);
                soglieForm.Show(this);
                DrawSoglie();
            }
        }

        private void MainForm_Move(object sender, EventArgs e) // Sposta form soglie con form principale
        {
            soglieForm.Location = new Point(this.Location.X + (this.Width / 2) - (soglieForm.Width / 2), this.Location.Y + this.Height);
        }

        private void muat_TextChanged(object sender, EventArgs e) // Aggiorna valore soglia con modifica costanti
        {
            DrawSoglieText();
        }

        private void mt_TextChanged(object sender, EventArgs e)
        {
            DrawSoglieText();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            soglieForm.noClose = false;
        }
        #endregion

        // Interpolazione Lineare
        private float Linear(float x, float a, float b)
        {
            return a + (b - a) * x;
        }

        // Restringi valore
        private float Clamp(float v, float min, float max)
        {
            return v >= min ? (v <= max ? v : max) : min;
        }
    }
}
