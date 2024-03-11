using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using smkstudentbaru.Class;

namespace smkstudentbaru
{
    public partial class Kelola_Jurusan : UserControl
    {
        Jurusan jurusan;
        bool isInsert = true;

        public Kelola_Jurusan()
        {
            InitializeComponent();
        }

        private void Kelola_Jurusan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData(string search = "")
        { 
            var data_jurusan = Global.db.Jurusans
                .Where(w => w.Nama.StartsWith(search))
                .Select(x => new
                {
                    tbid = x.ID,  //untuk tbid dan tbjurusan itu kembali ke mana?
                    tbjurusan = x.Nama,
                }).OrderBy(i => i.tbid)
                  .ToArray();
            dgvJurusan.DataSource = data_jurusan;
            dgvJurusan.RowTemplate.Height = 35;
        }

        private void dgvJurusan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvJurusan.Columns[e.ColumnIndex].Name == "Perbarui") 
            {
                isInsert = false;
                if (e.RowIndex == -1 || e.ColumnIndex == -1)
                {
                    return;
                }

                int id = Convert.ToInt32(dgvJurusan[2, e.RowIndex].Value); // maksudnya Convert.ToInt32?
                jurusan = Global.db.Jurusans.Find(id);
                tbnama.Text = jurusan.Nama;

            }
            else if (dgvJurusan.Columns[e.ColumnIndex].Name == "Hapus")
            {
                DialogResult result = MessageBox.Show("Yakin ingin menghapus data ini?", "Esemka Student", MessageBoxButtons.YesNo);
                {
                    int id = Convert.ToInt32(dgvJurusan[2, e.RowIndex].Value);
                    jurusan = Global.db.Jurusans.Find(id);
                    Global.db.Jurusans.Remove(jurusan);
                    Global.db.SaveChanges();
                    LoadData();
                }
            }
        }

        private void btnbatal_Click(object sender, EventArgs e) // tb clear nya juga
        {
            Clear();
        }
        void Clear() 
        {
            tbpencarian.Clear();
            tbnama.Clear();
            isInsert = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadData(tbpencarian.Text); //ini kenapa ga berfungsi?
        }

        private void btnsimpan_Click(object sender, EventArgs e) //tb simpannya ga berfungsi
        {
            if (isInsert)
            {
                jurusan = new Jurusan();
                var cekNama = Global.db.Kelas.FirstOrDefault(f => f.Nama == tbnama.Text);
                if (cekNama == null)
                {
                    jurusan.Nama = tbnama.Text;
                    Global.db.Jurusans.Add(jurusan);
                    Global.db.SaveChanges();
                    LoadData();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Nama Jurusan sudah ada !!", "Esemka Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                var cekNama = Global.db.Kelas.FirstOrDefault(f => f.Nama == tbnama.Text);

                if (cekNama == null || jurusan.Nama == tbnama.Text)
                {
                    jurusan.Nama = tbnama.Text;
                    Global.db.SaveChanges();
                    LoadData();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Nama Jurusan sudah ada !!", "Esemka Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbnama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
