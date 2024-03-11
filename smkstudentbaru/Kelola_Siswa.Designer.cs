namespace smkstudentbaru
{
    partial class Kelola_Siswa
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbpencarian = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbnama = new System.Windows.Forms.TextBox();
            this.tbno_telepon = new System.Windows.Forms.TextBox();
            this.tbNISN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbOrtu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtBirth = new System.Windows.Forms.DateTimePicker();
            this.cbfilterkelas = new System.Windows.Forms.ComboBox();
            this.cbfilterjurusan = new System.Windows.Forms.ComboBox();
            this.cbkelas = new System.Windows.Forms.ComboBox();
            this.cbjurusan = new System.Windows.Forms.ComboBox();
            this.btnfilter = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.dgvsiswa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnbatal = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(571, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelola Siswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pencarian";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(573, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(781, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jurusan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 582);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "NISN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 526);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tanggal lahir";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 655);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "No Telepon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 465);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nama";
            // 
            // tbpencarian
            // 
            this.tbpencarian.Location = new System.Drawing.Point(168, 106);
            this.tbpencarian.Name = "tbpencarian";
            this.tbpencarian.Size = new System.Drawing.Size(374, 26);
            this.tbpencarian.TabIndex = 8;
            this.tbpencarian.TextChanged += new System.EventHandler(this.tbpencarian_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(222, 464);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(374, 26);
            this.tbnama.TabIndex = 10;
            this.tbnama.TextChanged += new System.EventHandler(this.tbnama_TextChanged);
            this.tbnama.Validating += new System.ComponentModel.CancelEventHandler(this.tbnama_Validating);
            // 
            // tbno_telepon
            // 
            this.tbno_telepon.Location = new System.Drawing.Point(222, 650);
            this.tbno_telepon.Name = "tbno_telepon";
            this.tbno_telepon.Size = new System.Drawing.Size(374, 26);
            this.tbno_telepon.TabIndex = 11;
            this.tbno_telepon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbno_telepon_KeyPress);
            this.tbno_telepon.Validating += new System.ComponentModel.CancelEventHandler(this.tbno_telepon_Validating);
            // 
            // tbNISN
            // 
            this.tbNISN.Location = new System.Drawing.Point(222, 581);
            this.tbNISN.Name = "tbNISN";
            this.tbNISN.Size = new System.Drawing.Size(374, 26);
            this.tbNISN.TabIndex = 12;
            this.tbNISN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNISN_KeyPress);
            this.tbNISN.Validating += new System.ComponentModel.CancelEventHandler(this.tbNISN_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(643, 463);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(228, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Nama Wali/Orang Tua";
            // 
            // tbOrtu
            // 
            this.tbOrtu.Location = new System.Drawing.Point(929, 462);
            this.tbOrtu.Name = "tbOrtu";
            this.tbOrtu.Size = new System.Drawing.Size(374, 26);
            this.tbOrtu.TabIndex = 14;
            this.tbOrtu.Validating += new System.ComponentModel.CancelEventHandler(this.tbOrtu_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(643, 526);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "Kelas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(643, 580);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "Jurusan";
            // 
            // dtBirth
            // 
            this.dtBirth.Location = new System.Drawing.Point(222, 526);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.Size = new System.Drawing.Size(374, 26);
            this.dtBirth.TabIndex = 17;
            // 
            // cbfilterkelas
            // 
            this.cbfilterkelas.FormattingEnabled = true;
            this.cbfilterkelas.Location = new System.Drawing.Point(648, 102);
            this.cbfilterkelas.Name = "cbfilterkelas";
            this.cbfilterkelas.Size = new System.Drawing.Size(97, 28);
            this.cbfilterkelas.TabIndex = 18;
            this.cbfilterkelas.SelectedIndexChanged += new System.EventHandler(this.cbfilterkelas_SelectedIndexChanged);
            // 
            // cbfilterjurusan
            // 
            this.cbfilterjurusan.FormattingEnabled = true;
            this.cbfilterjurusan.Location = new System.Drawing.Point(895, 102);
            this.cbfilterjurusan.Name = "cbfilterjurusan";
            this.cbfilterjurusan.Size = new System.Drawing.Size(366, 28);
            this.cbfilterjurusan.TabIndex = 19;
            this.cbfilterjurusan.SelectedIndexChanged += new System.EventHandler(this.cbfilterjurusan_SelectedIndexChanged);
            // 
            // cbkelas
            // 
            this.cbkelas.FormattingEnabled = true;
            this.cbkelas.Location = new System.Drawing.Point(929, 523);
            this.cbkelas.Name = "cbkelas";
            this.cbkelas.Size = new System.Drawing.Size(374, 28);
            this.cbkelas.TabIndex = 20;
            // 
            // cbjurusan
            // 
            this.cbjurusan.FormattingEnabled = true;
            this.cbjurusan.Location = new System.Drawing.Point(929, 577);
            this.cbjurusan.Name = "cbjurusan";
            this.cbjurusan.Size = new System.Drawing.Size(374, 28);
            this.cbjurusan.TabIndex = 21;
            this.cbjurusan.SelectedIndexChanged += new System.EventHandler(this.cbjurusan_SelectedIndexChanged);
            // 
            // btnfilter
            // 
            this.btnfilter.Location = new System.Drawing.Point(1301, 66);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(94, 30);
            this.btnfilter.TabIndex = 22;
            this.btnfilter.Text = "Filter";
            this.btnfilter.UseVisualStyleBackColor = true;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(1301, 107);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(94, 30);
            this.btnreset.TabIndex = 23;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // dgvsiswa
            // 
            this.dgvsiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsiswa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvsiswa.Location = new System.Drawing.Point(34, 161);
            this.dgvsiswa.Name = "dgvsiswa";
            this.dgvsiswa.RowHeadersWidth = 62;
            this.dgvsiswa.RowTemplate.Height = 28;
            this.dgvsiswa.Size = new System.Drawing.Size(1361, 282);
            this.dgvsiswa.TabIndex = 24;
            this.dgvsiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsiswa_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 62;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Nama";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tanggal Lahir";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "NISN";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "No Telepon";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Orang Tua";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Jurusan";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column8.HeaderText = "Kelas";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Width = 84;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Cyan;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle29;
            this.Column9.HeaderText = "Perbarui";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.Text = "Perbarui";
            this.Column9.UseColumnTextForButtonValue = true;
            this.Column9.Width = 74;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Red;
            this.Column10.DefaultCellStyle = dataGridViewCellStyle30;
            this.Column10.HeaderText = "Hapus";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.Text = "Hapus";
            this.Column10.UseColumnTextForButtonValue = true;
            this.Column10.Width = 62;
            // 
            // btnbatal
            // 
            this.btnbatal.Location = new System.Drawing.Point(1035, 650);
            this.btnbatal.Name = "btnbatal";
            this.btnbatal.Size = new System.Drawing.Size(116, 30);
            this.btnbatal.TabIndex = 25;
            this.btnbatal.Text = "Batal";
            this.btnbatal.UseVisualStyleBackColor = true;
            this.btnbatal.Click += new System.EventHandler(this.btnbatal_Click);
            // 
            // btnsimpan
            // 
            this.btnsimpan.Location = new System.Drawing.Point(1178, 650);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(110, 30);
            this.btnsimpan.TabIndex = 26;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = true;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // Kelola_Siswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.btnbatal);
            this.Controls.Add(this.dgvsiswa);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnfilter);
            this.Controls.Add(this.cbjurusan);
            this.Controls.Add(this.cbkelas);
            this.Controls.Add(this.cbfilterjurusan);
            this.Controls.Add(this.cbfilterkelas);
            this.Controls.Add(this.dtBirth);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbOrtu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbNISN);
            this.Controls.Add(this.tbno_telepon);
            this.Controls.Add(this.tbnama);
            this.Controls.Add(this.tbpencarian);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kelola_Siswa";
            this.Size = new System.Drawing.Size(1419, 750);
            this.Load += new System.EventHandler(this.Kelola_Siswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbpencarian;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.TextBox tbno_telepon;
        private System.Windows.Forms.TextBox tbNISN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbOrtu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtBirth;
        private System.Windows.Forms.ComboBox cbfilterkelas;
        private System.Windows.Forms.ComboBox cbfilterjurusan;
        private System.Windows.Forms.ComboBox cbkelas;
        private System.Windows.Forms.ComboBox cbjurusan;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.DataGridView dgvsiswa;
        private System.Windows.Forms.Button btnbatal;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn Column9;
        private System.Windows.Forms.DataGridViewButtonColumn Column10;
    }
}
