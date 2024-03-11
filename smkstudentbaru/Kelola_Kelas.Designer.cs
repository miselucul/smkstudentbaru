namespace smkstudentbaru
{
    partial class Kelola_Kelas
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbpencarian = new System.Windows.Forms.TextBox();
            this.dgvkelas = new System.Windows.Forms.DataGridView();
            this.tbid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbwali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbwalikelas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbkelas = new System.Windows.Forms.TextBox();
            this.btnbatal = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkelas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(639, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelola Kelas";
            // 
            // tbpencarian
            // 
            this.tbpencarian.Location = new System.Drawing.Point(172, 101);
            this.tbpencarian.Name = "tbpencarian";
            this.tbpencarian.Size = new System.Drawing.Size(446, 26);
            this.tbpencarian.TabIndex = 1;
            this.tbpencarian.TextChanged += new System.EventHandler(this.tbpencarian_TextChanged);
            // 
            // dgvkelas
            // 
            this.dgvkelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbid,
            this.Column5,
            this.tbwali,
            this.Column3,
            this.Column4});
            this.dgvkelas.Location = new System.Drawing.Point(31, 159);
            this.dgvkelas.Name = "dgvkelas";
            this.dgvkelas.RowHeadersWidth = 62;
            this.dgvkelas.RowTemplate.Height = 28;
            this.dgvkelas.Size = new System.Drawing.Size(1356, 417);
            this.dgvkelas.TabIndex = 2;
            // 
            // tbid
            // 
            this.tbid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tbid.DataPropertyName = "ID";
            this.tbid.HeaderText = "ID";
            this.tbid.MinimumWidth = 8;
            this.tbid.Name = "tbid";
            this.tbid.Width = 62;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Kelas";
            this.Column5.HeaderText = "Kelas";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // tbwali
            // 
            this.tbwali.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tbwali.DataPropertyName = "Wali Kelas";
            this.tbwali.HeaderText = "Wali Kelas";
            this.tbwali.MinimumWidth = 8;
            this.tbwali.Name = "tbwali";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Perbarui";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Text = "Perbarui";
            this.Column3.UseColumnTextForButtonValue = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Hapus";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Text = "Hapus";
            this.Column4.UseColumnTextForButtonValue = true;
            this.Column4.Width = 150;
            // 
            // cbwalikelas
            // 
            this.cbwalikelas.FormattingEnabled = true;
            this.cbwalikelas.Location = new System.Drawing.Point(172, 669);
            this.cbwalikelas.Name = "cbwalikelas";
            this.cbwalikelas.Size = new System.Drawing.Size(446, 28);
            this.cbwalikelas.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pencarian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 624);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 672);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Wali Kelas";
            // 
            // tbkelas
            // 
            this.tbkelas.Location = new System.Drawing.Point(172, 623);
            this.tbkelas.Name = "tbkelas";
            this.tbkelas.Size = new System.Drawing.Size(446, 26);
            this.tbkelas.TabIndex = 7;
            this.tbkelas.TextChanged += new System.EventHandler(this.tbkelas_TextChanged);
            // 
            // btnbatal
            // 
            this.btnbatal.Location = new System.Drawing.Point(904, 683);
            this.btnbatal.Name = "btnbatal";
            this.btnbatal.Size = new System.Drawing.Size(121, 34);
            this.btnbatal.TabIndex = 8;
            this.btnbatal.Text = "Batal";
            this.btnbatal.UseVisualStyleBackColor = true;
            this.btnbatal.Click += new System.EventHandler(this.btnbatal_Click);
            // 
            // btnsimpan
            // 
            this.btnsimpan.Location = new System.Drawing.Point(1071, 683);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(113, 34);
            this.btnsimpan.TabIndex = 9;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = true;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // Kelola_Kelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.btnbatal);
            this.Controls.Add(this.tbkelas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbwalikelas);
            this.Controls.Add(this.dgvkelas);
            this.Controls.Add(this.tbpencarian);
            this.Controls.Add(this.label1);
            this.Name = "Kelola_Kelas";
            this.Size = new System.Drawing.Size(1419, 750);
            this.Load += new System.EventHandler(this.Kelola_Kelas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbpencarian;
        private System.Windows.Forms.DataGridView dgvkelas;
        private System.Windows.Forms.ComboBox cbwalikelas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbkelas;
        private System.Windows.Forms.Button btnbatal;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbwali;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
    }
}
