namespace smkstudentbaru
{
    partial class Form_Main
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
            this.btnsiswa = new System.Windows.Forms.Button();
            this.btnkelas = new System.Windows.Forms.Button();
            this.btnjurusan = new System.Windows.Forms.Button();
            this.btnguru = new System.Windows.Forms.Button();
            this.btnmapel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1016, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Esemka Student - Manajemen Data Sekolah Anda Dengan Mudah";
            // 
            // btnsiswa
            // 
            this.btnsiswa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsiswa.Location = new System.Drawing.Point(12, 81);
            this.btnsiswa.Name = "btnsiswa";
            this.btnsiswa.Size = new System.Drawing.Size(181, 51);
            this.btnsiswa.TabIndex = 1;
            this.btnsiswa.Text = "Kelola Siswa";
            this.btnsiswa.UseVisualStyleBackColor = true;
            this.btnsiswa.Click += new System.EventHandler(this.btnsiswa_Click);
            // 
            // btnkelas
            // 
            this.btnkelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkelas.Location = new System.Drawing.Point(12, 154);
            this.btnkelas.Name = "btnkelas";
            this.btnkelas.Size = new System.Drawing.Size(181, 51);
            this.btnkelas.TabIndex = 2;
            this.btnkelas.Text = "Kelola Kelas";
            this.btnkelas.UseVisualStyleBackColor = true;
            this.btnkelas.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnjurusan
            // 
            this.btnjurusan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjurusan.Location = new System.Drawing.Point(12, 226);
            this.btnjurusan.Name = "btnjurusan";
            this.btnjurusan.Size = new System.Drawing.Size(181, 51);
            this.btnjurusan.TabIndex = 3;
            this.btnjurusan.Text = "Kelola Jurusan";
            this.btnjurusan.UseVisualStyleBackColor = true;
            this.btnjurusan.Click += new System.EventHandler(this.btnjurusan_Click);
            // 
            // btnguru
            // 
            this.btnguru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguru.Location = new System.Drawing.Point(12, 304);
            this.btnguru.Name = "btnguru";
            this.btnguru.Size = new System.Drawing.Size(181, 51);
            this.btnguru.TabIndex = 4;
            this.btnguru.Text = "Kelola Guru";
            this.btnguru.UseVisualStyleBackColor = true;
            this.btnguru.Click += new System.EventHandler(this.btnguru_Click);
            // 
            // btnmapel
            // 
            this.btnmapel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmapel.Location = new System.Drawing.Point(12, 383);
            this.btnmapel.Name = "btnmapel";
            this.btnmapel.Size = new System.Drawing.Size(181, 79);
            this.btnmapel.TabIndex = 5;
            this.btnmapel.Text = "Kelola Mata Pelajaran";
            this.btnmapel.UseVisualStyleBackColor = true;
            this.btnmapel.Click += new System.EventHandler(this.btnmapel_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(209, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1419, 750);
            this.panel1.TabIndex = 7;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1640, 843);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnmapel);
            this.Controls.Add(this.btnguru);
            this.Controls.Add(this.btnjurusan);
            this.Controls.Add(this.btnkelas);
            this.Controls.Add(this.btnsiswa);
            this.Controls.Add(this.label1);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsiswa;
        private System.Windows.Forms.Button btnkelas;
        private System.Windows.Forms.Button btnjurusan;
        private System.Windows.Forms.Button btnguru;
        private System.Windows.Forms.Button btnmapel;
        private System.Windows.Forms.Panel panel1;
    }
}