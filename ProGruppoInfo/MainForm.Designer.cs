namespace ProGruppoInfo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.soglie = new System.Windows.Forms.Button();
            this.SaveData = new System.Windows.Forms.Button();
            this.LoadData = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tht = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.t0t = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.v0t = new System.Windows.Forms.TextBox();
            this.mt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.muat = new System.Windows.Forms.TextBox();
            this.gt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtt = new System.Windows.Forms.TextBox();
            this.nct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Draw = new System.Windows.Forms.Button();
            this.DrawPoints = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.T = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.V = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 285F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(883, 557);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(288, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 551);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.data, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(279, 551);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.soglie);
            this.panel1.Controls.Add(this.SaveData);
            this.panel1.Controls.Add(this.LoadData);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tht);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.t0t);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.v0t);
            this.panel1.Controls.Add(this.mt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.muat);
            this.panel1.Controls.Add(this.gt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtt);
            this.panel1.Controls.Add(this.nct);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Draw);
            this.panel1.Controls.Add(this.DrawPoints);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 344);
            this.panel1.TabIndex = 1;
            // 
            // soglie
            // 
            this.soglie.Location = new System.Drawing.Point(191, 86);
            this.soglie.Name = "soglie";
            this.soglie.Size = new System.Drawing.Size(68, 22);
            this.soglie.TabIndex = 24;
            this.soglie.Text = "Soglie";
            this.soglie.UseVisualStyleBackColor = true;
            this.soglie.Click += new System.EventHandler(this.soglie_Click);
            // 
            // SaveData
            // 
            this.SaveData.Location = new System.Drawing.Point(182, 300);
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(77, 37);
            this.SaveData.TabIndex = 21;
            this.SaveData.Text = "Salva Dati";
            this.SaveData.UseVisualStyleBackColor = true;
            this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // LoadData
            // 
            this.LoadData.Location = new System.Drawing.Point(101, 300);
            this.LoadData.Name = "LoadData";
            this.LoadData.Size = new System.Drawing.Size(75, 37);
            this.LoadData.TabIndex = 20;
            this.LoadData.Text = "Carica Dati";
            this.LoadData.UseVisualStyleBackColor = true;
            this.LoadData.Click += new System.EventHandler(this.LoadData_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(9, 300);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(86, 37);
            this.Save.TabIndex = 19;
            this.Save.Text = "Salva Grafico";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Vt = NaN (t = NaN), Vt calcolata = NaN";
            // 
            // tht
            // 
            this.tht.Location = new System.Drawing.Point(92, 254);
            this.tht.Name = "tht";
            this.tht.Size = new System.Drawing.Size(167, 20);
            this.tht.TabIndex = 17;
            this.tht.Text = "0,01";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Epsilon:";
            // 
            // t0t
            // 
            this.t0t.Location = new System.Drawing.Point(92, 218);
            this.t0t.Name = "t0t";
            this.t0t.Size = new System.Drawing.Size(167, 20);
            this.t0t.TabIndex = 15;
            this.t0t.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "T0:";
            // 
            // v0t
            // 
            this.v0t.Location = new System.Drawing.Point(92, 192);
            this.v0t.Name = "v0t";
            this.v0t.Size = new System.Drawing.Size(167, 20);
            this.v0t.TabIndex = 13;
            this.v0t.Text = "0";
            // 
            // mt
            // 
            this.mt.Location = new System.Drawing.Point(92, 166);
            this.mt.Name = "mt";
            this.mt.Size = new System.Drawing.Size(167, 20);
            this.mt.TabIndex = 12;
            this.mt.Text = "1";
            this.mt.TextChanged += new System.EventHandler(this.mt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "V0:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Massa:";
            // 
            // muat
            // 
            this.muat.Location = new System.Drawing.Point(92, 140);
            this.muat.Name = "muat";
            this.muat.Size = new System.Drawing.Size(167, 20);
            this.muat.TabIndex = 9;
            this.muat.Text = "1";
            this.muat.TextChanged += new System.EventHandler(this.muat_TextChanged);
            // 
            // gt
            // 
            this.gt.Location = new System.Drawing.Point(92, 114);
            this.gt.Name = "gt";
            this.gt.Size = new System.Drawing.Size(167, 20);
            this.gt.TabIndex = 8;
            this.gt.Text = "9,81";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "muA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "g:";
            // 
            // dtt
            // 
            this.dtt.Location = new System.Drawing.Point(92, 88);
            this.dtt.Name = "dtt";
            this.dtt.Size = new System.Drawing.Size(93, 20);
            this.dtt.TabIndex = 5;
            this.dtt.Text = "0,1";
            // 
            // nct
            // 
            this.nct.Location = new System.Drawing.Point(92, 62);
            this.nct.Name = "nct";
            this.nct.Size = new System.Drawing.Size(167, 20);
            this.nct.TabIndex = 4;
            this.nct.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "dt:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "N Campioni:";
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(142, 9);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(117, 44);
            this.Draw.TabIndex = 1;
            this.Draw.Text = "Calcola e Disegna";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // DrawPoints
            // 
            this.DrawPoints.Location = new System.Drawing.Point(9, 9);
            this.DrawPoints.Name = "DrawPoints";
            this.DrawPoints.Size = new System.Drawing.Size(127, 44);
            this.DrawPoints.TabIndex = 0;
            this.DrawPoints.Text = "Disegna Punti e Calcola Accelerazione";
            this.DrawPoints.UseVisualStyleBackColor = true;
            this.DrawPoints.Click += new System.EventHandler(this.DrawPoints_Click);
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.T,
            this.V,
            this.a});
            this.data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data.Location = new System.Drawing.Point(3, 353);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(273, 195);
            this.data.TabIndex = 2;
            // 
            // T
            // 
            this.T.HeaderText = "T";
            this.T.Name = "T";
            this.T.Width = 70;
            // 
            // V
            // 
            this.V.HeaderText = "V";
            this.V.Name = "V";
            this.V.Width = 70;
            // 
            // a
            // 
            this.a.HeaderText = "a";
            this.a.Name = "a";
            this.a.Width = 70;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 557);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Attrito Viscoso - 2015, Giulio Zausa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.Move += new System.EventHandler(this.MainForm_Move);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tht;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox t0t;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox v0t;
        private System.Windows.Forms.TextBox mt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox muat;
        private System.Windows.Forms.TextBox gt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dtt;
        private System.Windows.Forms.TextBox nct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.DataGridViewTextBoxColumn T;
        private System.Windows.Forms.DataGridViewTextBoxColumn V;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DrawPoints;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.Button LoadData;
        private System.Windows.Forms.Button soglie;
    }
}