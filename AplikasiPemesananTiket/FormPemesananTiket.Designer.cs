namespace AplikasiPemesananTiket
{
    partial class FormPemesananTiket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPemesananTiket));
            txtNamaPemesan = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTujuan = new TextBox();
            numJumlahTiket = new NumericUpDown();
            btnPesan = new Button();
            monthCalendar1 = new MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)numJumlahTiket).BeginInit();
            SuspendLayout();
            // 
            // txtNamaPemesan
            // 
            txtNamaPemesan.BackColor = SystemColors.InactiveCaption;
            txtNamaPemesan.Location = new Point(207, 48);
            txtNamaPemesan.Margin = new Padding(4, 5, 4, 5);
            txtNamaPemesan.Name = "txtNamaPemesan";
            txtNamaPemesan.Size = new Size(251, 27);
            txtNamaPemesan.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(60, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 1;
            label1.Text = "Nama Pemesan :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(60, 112);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 2;
            label2.Text = "Tujuan :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(60, 175);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 3;
            label3.Text = "Jumlah Tiket  :";
            // 
            // txtTujuan
            // 
            txtTujuan.BackColor = SystemColors.InactiveCaption;
            txtTujuan.Location = new Point(207, 108);
            txtTujuan.Margin = new Padding(4, 5, 4, 5);
            txtTujuan.Name = "txtTujuan";
            txtTujuan.Size = new Size(251, 27);
            txtTujuan.TabIndex = 4;
            // 
            // numJumlahTiket
            // 
            numJumlahTiket.BackColor = SystemColors.InactiveCaption;
            numJumlahTiket.Location = new Point(207, 172);
            numJumlahTiket.Margin = new Padding(4, 5, 4, 5);
            numJumlahTiket.Name = "numJumlahTiket";
            numJumlahTiket.Size = new Size(89, 27);
            numJumlahTiket.TabIndex = 5;
            // 
            // btnPesan
            // 
            btnPesan.BackColor = SystemColors.ActiveCaption;
            btnPesan.Location = new Point(207, 246);
            btnPesan.Margin = new Padding(4, 5, 4, 5);
            btnPesan.Name = "btnPesan";
            btnPesan.Size = new Size(100, 35);
            btnPesan.TabIndex = 6;
            btnPesan.Text = "Pesan";
            btnPesan.UseVisualStyleBackColor = false;
            btnPesan.Click += btnPesan_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.RosyBrown;
            monthCalendar1.Location = new Point(509, 48);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 7;
            // 
            // FormPemesananTiket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(821, 483);
            Controls.Add(monthCalendar1);
            Controls.Add(btnPesan);
            Controls.Add(numJumlahTiket);
            Controls.Add(txtTujuan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNamaPemesan);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormPemesananTiket";
            Text = "tiket.co.id";
            ((System.ComponentModel.ISupportInitialize)numJumlahTiket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNamaPemesan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTujuan;
        private System.Windows.Forms.NumericUpDown numJumlahTiket;
        private System.Windows.Forms.Button btnPesan;
        private MonthCalendar monthCalendar1;
    }
}
