namespace smkstudentbaru
{
    partial class Kelola_Jurusan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btnbatal = new System.Windows.Forms.Button();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvJurusan = new System.Windows.Forms.DataGridView();
            this.tbpencarian = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbjurusan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnperbarui = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnhapus = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJurusan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsimpan
            // 
            this.btnsimpan.Location = new System.Drawing.Point(1074, 682);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(113, 34);
            this.btnsimpan.TabIndex = 19;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = true;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // btnbatal
            // 
            this.btnbatal.Location = new System.Drawing.Point(907, 682);
            this.btnbatal.Name = "btnbatal";
            this.btnbatal.Size = new System.Drawing.Size(121, 34);
            this.btnbatal.TabIndex = 18;
            this.btnbatal.Text = "Batal";
            this.btnbatal.UseVisualStyleBackColor = true;
            this.btnbatal.Click += new System.EventHandler(this.btnbatal_Click);
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(175, 648);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(446, 26);
            this.tbnama.TabIndex = 17;
            this.tbnama.TextChanged += new System.EventHandler(this.tbnama_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 647);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pencarian";
            // 
            // dgvJurusan
            // 
            this.dgvJurusan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJurusan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbid,
            this.tbjurusan,
            this.btnperbarui,
            this.btnhapus});
            this.dgvJurusan.Location = new System.Drawing.Point(34, 158);
            this.dgvJurusan.Name = "dgvJurusan";
            this.dgvJurusan.RowHeadersWidth = 62;
            this.dgvJurusan.RowTemplate.Height = 28;
            this.dgvJurusan.Size = new System.Drawing.Size(1356, 417);
            this.dgvJurusan.TabIndex = 12;
            this.dgvJurusan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJurusan_CellContentClick);
            // 
            // tbpencarian
            // 
            this.tbpencarian.Location = new System.Drawing.Point(175, 100);
            this.tbpencarian.Name = "tbpencarian";
            this.tbpencarian.Size = new System.Drawing.Size(446, 26);
            this.tbpencarian.TabIndex = 11;
            this.tbpencarian.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(642, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kelola Jurusan";
            // 
            // tbid
            // 
            this.tbid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tbid.DataPropertyName = "id";
            this.tbid.HeaderText = "ID";
            this.tbid.MinimumWidth = 8;
            this.tbid.Name = "tbid";
            this.tbid.Width = 62;
            // 
            // tbjurusan
            // 
            this.tbjurusan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tbjurusan.DataPropertyName = "Jurusan";
            this.tbjurusan.HeaderText = "Jurusan";
            this.tbjurusan.MinimumWidth = 8;
            this.tbjurusan.Name = "tbjurusan";
            // 
            // btnperbarui
            // 
            this.btnperbarui.DataPropertyName = "Perbarui";
            this.btnperbarui.HeaderText = "Perbarui";
            this.btnperbarui.MinimumWidth = 8;
            this.btnperbarui.Name = "btnperbarui";
            this.btnperbarui.Text = "Perbarui";
            this.btnperbarui.UseColumnTextForButtonValue = true;
            this.btnperbarui.Width = 150;
            // 
            // btnhapus
            // 
            this.btnhapus.DataPropertyName = "Hapus";
            this.btnhapus.HeaderText = "Hapus";
            this.btnhapus.MinimumWidth = 8;
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseColumnTextForButtonValue = true;
            this.btnhapus.Width = 150;
            // 
            // Kelola_Jurusan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.btnbatal);
            this.Controls.Add(this.tbnama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvJurusan);
            this.Controls.Add(this.tbpencarian);
            this.Controls.Add(this.label1);
            this.Name = "Kelola_Jurusan";
            this.Size = new System.Drawing.Size(1419, 750);
            this.Load += new System.EventHandler(this.Kelola_Jurusan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJurusan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btnbatal;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvJurusan;
        private System.Windows.Forms.TextBox tbpencarian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbid;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbjurusan;
        private System.Windows.Forms.DataGridViewButtonColumn btnperbarui;
        private System.Windows.Forms.DataGridViewButtonColumn btnhapus;
    }
}
