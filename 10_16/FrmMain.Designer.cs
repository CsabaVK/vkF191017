namespace _10_16
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_nev = new System.Windows.Forms.ComboBox();
            this.tb_nev = new System.Windows.Forms.TextBox();
            this.cb_vega = new System.Windows.Forms.CheckBox();
            this.rd_no = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_asztal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_kaja = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rd_ferfi = new System.Windows.Forms.RadioButton();
            this.tb_asztal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendég neve:";
            // 
            // cb_nev
            // 
            this.cb_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_nev.FormattingEnabled = true;
            this.cb_nev.Location = new System.Drawing.Point(155, 9);
            this.cb_nev.Name = "cb_nev";
            this.cb_nev.Size = new System.Drawing.Size(165, 32);
            this.cb_nev.TabIndex = 1;
            this.cb_nev.SelectedIndexChanged += new System.EventHandler(this.cb_nev_SelectedIndexChanged);
            // 
            // tb_nev
            // 
            this.tb_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_nev.Location = new System.Drawing.Point(158, 222);
            this.tb_nev.Name = "tb_nev";
            this.tb_nev.Size = new System.Drawing.Size(162, 29);
            this.tb_nev.TabIndex = 2;
            // 
            // cb_vega
            // 
            this.cb_vega.AutoSize = true;
            this.cb_vega.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_vega.Location = new System.Drawing.Point(240, 302);
            this.cb_vega.Name = "cb_vega";
            this.cb_vega.Size = new System.Drawing.Size(80, 28);
            this.cb_vega.TabIndex = 3;
            this.cb_vega.Text = "vega?";
            this.cb_vega.UseVisualStyleBackColor = true;
            // 
            // rd_no
            // 
            this.rd_no.AutoSize = true;
            this.rd_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rd_no.Location = new System.Drawing.Point(158, 263);
            this.rd_no.Name = "rd_no";
            this.rd_no.Size = new System.Drawing.Size(53, 28);
            this.rd_no.TabIndex = 4;
            this.rd_no.TabStop = true;
            this.rd_no.Text = "Nő";
            this.rd_no.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(89, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 59);
            this.button1.TabIndex = 5;
            this.button1.Text = "Vendég Hozzáadása";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lb_asztal
            // 
            this.lb_asztal.AutoSize = true;
            this.lb_asztal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_asztal.Location = new System.Drawing.Point(194, 82);
            this.lb_asztal.Name = "lb_asztal";
            this.lb_asztal.Size = new System.Drawing.Size(40, 24);
            this.lb_asztal.TabIndex = 6;
            this.lb_asztal.Text = "###";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vendég adatai:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(85, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Asztal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(98, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kaja:";
            // 
            // lb_kaja
            // 
            this.lb_kaja.AutoSize = true;
            this.lb_kaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_kaja.Location = new System.Drawing.Point(194, 121);
            this.lb_kaja.Name = "lb_kaja";
            this.lb_kaja.Size = new System.Drawing.Size(40, 24);
            this.lb_kaja.TabIndex = 6;
            this.lb_kaja.Text = "###";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(85, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "ÚJ VENDÉG RÖGZÍTÉSE:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(103, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Név:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(88, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "Asztal:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(96, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "Nem:";
            // 
            // rd_ferfi
            // 
            this.rd_ferfi.AutoSize = true;
            this.rd_ferfi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rd_ferfi.Location = new System.Drawing.Point(217, 265);
            this.rd_ferfi.Name = "rd_ferfi";
            this.rd_ferfi.Size = new System.Drawing.Size(65, 28);
            this.rd_ferfi.TabIndex = 4;
            this.rd_ferfi.TabStop = true;
            this.rd_ferfi.Text = "Férfi";
            this.rd_ferfi.UseVisualStyleBackColor = true;
            // 
            // tb_asztal
            // 
            this.tb_asztal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_asztal.Location = new System.Drawing.Point(158, 302);
            this.tb_asztal.Name = "tb_asztal";
            this.tb_asztal.Size = new System.Drawing.Size(76, 29);
            this.tb_asztal.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 442);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_kaja);
            this.Controls.Add(this.lb_asztal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rd_ferfi);
            this.Controls.Add(this.rd_no);
            this.Controls.Add(this.cb_vega);
            this.Controls.Add(this.tb_asztal);
            this.Controls.Add(this.tb_nev);
            this.Controls.Add(this.cb_nev);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "Ülésrend Editor Pro 2000";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_nev;
        private System.Windows.Forms.TextBox tb_nev;
        private System.Windows.Forms.CheckBox cb_vega;
        private System.Windows.Forms.RadioButton rd_no;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_asztal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_kaja;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rd_ferfi;
        private System.Windows.Forms.TextBox tb_asztal;
    }
}

