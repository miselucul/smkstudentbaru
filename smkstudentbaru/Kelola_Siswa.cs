using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using smkstudentbaru.Class;

namespace smkstudentbaru
{
    public partial class Kelola_Siswa : UserControl
    {
        Siswa siswa;
        bool isInsert = true;

        public Kelola_Siswa()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        
        }
        
        private void Kelola_Siswa_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadKelas();
            LoadJurusan();
        }

        void LoadData(string search = "", int jurusan = 0, int kelas = 0) //int jurusan dan kelas itu kembalinya kemana? parameter adalah?
        {
            var query = Global.db.Siswas.ToList(); //fungsi to list adalah?
            if (jurusan != 0 && kelas != 0)
            {
                query = query.Where(w => w.Jurusan_id == jurusan && w.Kelas_id == kelas).ToList();
            }
            else //dapat w darimana?
            {
                query = query.Where(w => w.Nama.StartsWith(search)).ToList();
            }
            var data_siswa = query.ToList()
                .Select(s => new
                {
                    ID = s.ID,
                    Nama = s.Nama,
                    Tanggal_lahir = s.Tanggal_lahir.ToString("yyyy-MM-dd"),
                    NISN = s.NISN,
                    No_Telepon = s.No_Telepon,
                    Orang_Tua = s.Orang_tua,
                    jurusan = s.Jurusan_id,
                    kelas = s.Kelas_id,
                }).ToArray();
            dgvsiswa.DataSource = data_siswa;
            dgvsiswa.RowTemplate.Height = 35;
        }

        void LoadKelas() 
        {
            var kelas = Global.db.Kelas.Select(s => new
            {
                ID = s.ID,
                Nama = s.Nama,
            }).ToArray();

            cbfilterkelas.DataSource = kelas;
            cbfilterkelas.DisplayMember = "Nama";
            cbfilterkelas.ValueMember = "ID";

            cbkelas.DataSource = kelas;
            cbkelas.DisplayMember = "Nama";
            cbkelas.ValueMember = "ID";

        }

        void LoadJurusan() 
        {
            var jurusan = Global.db.Jurusans.Select(s => new
            {
                ID = s.ID,
                Nama = s.Nama,
            }).ToArray();

            cbfilterjurusan.DataSource = jurusan;
            cbfilterjurusan.DisplayMember = "Nama";
            cbfilterjurusan.ValueMember = "ID";

            cbjurusan.DataSource = jurusan;
            cbjurusan.DisplayMember = "Nama";
            cbjurusan.ValueMember = "ID";
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvsiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isInsert)
            {
                siswa = new Siswa();
            }
            var cekNama = Global.db.Siswas.FirstOrDefault(f => f.Nama == tbnama.Text);
            if (cekNama == null || siswa.Nama == tbnama.Text)
            {
                siswa.Nama = tbnama.Text;
                siswa.NISN = tbNISN.Text.ToString();
                siswa.Tanggal_lahir = dtBirth.Value;
                siswa.No_Telepon = tbno_telepon.Text;
                siswa.Orang_tua = tbOrtu.Text;
                siswa.Kelas_id = Convert.ToInt32(cbkelas.SelectedValue);
                siswa.Jurusan_id = Convert.ToInt32(cbjurusan.SelectedValue);
                if (isInsert)
                {
                    Global.db.Siswas.Add(siswa);

                }
                Global.db.SaveChanges();
                LoadData();
                Clear();

            }
            else
            {
                MessageBox.Show("Nama Siswa sudah ada!!", "Esemka Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            void Clear() 
            {
                tbnama.Clear();
                tbNISN.Clear();
                tbOrtu.Clear();
                tbno_telepon.Clear();
                LoadKelas();
                LoadJurusan();
                dtBirth.Value = DateTime.Now;
            }
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear() 
        {
            void Clear()
            {
                tbnama.Clear();
                tbNISN.Clear();
                tbOrtu.Clear();
                tbno_telepon.Clear();
                LoadKelas();
                LoadJurusan();
                dtBirth.Value = DateTime.Now;
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tbpencarian_TextChanged(object sender, EventArgs e)
        {
            LoadData(tbpencarian.Text);
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (isInsert) 
            {
                siswa = new Siswa();
            }
            var cekNama = Global.db.Siswas.FirstOrDefault(f => f.Nama == tbnama.Text);
            if (cekNama == null || siswa.Nama == tbnama.Text)
            {
                siswa.Nama = tbnama.Text;
                siswa.NISN = tbNISN.Text.ToString();
                siswa.Tanggal_lahir = dtBirth.Value;
                siswa.No_Telepon = tbno_telepon.Text;
                siswa.Orang_tua = tbOrtu.Text;
                siswa.Kelas_id = Convert.ToInt32(cbkelas.SelectedValue);
                siswa.Jurusan_id = Convert.ToInt32(cbjurusan.SelectedValue);
                if (isInsert)
                {
                    Global.db.Siswas.Add(siswa);

                }
                Global.db.SaveChanges();
                LoadData();
                Clear();

            }
            else
            {
                MessageBox.Show("Nama Siswa sudah ada!!", "Esemka Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbnama_Validating(object sender, CancelEventArgs e)
        {
            if (tbnama.Text == "")
            {
                e.Cancel = true;
                MessageBox.Show("Nama Belum Terisi!!", "Esemka Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbNISN_Validating(object sender, CancelEventArgs e)
        {
            if (tbNISN.Text == "")
            {
                e.Cancel = true;
                MessageBox.Show("Nama Belum Terisi!!", "Esemka Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbno_telepon_Validating(object sender, CancelEventArgs e)
        {
            if (tbno_telepon.Text == "")
            {
                e.Cancel = true;
                MessageBox.Show("Nama Belum Terisi!!", "Esemka Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tbno_telepon.Text.Length > 15 || tbno_telepon.Text.Length < 10)
                {
                    e.Cancel = true;
                    MessageBox.Show("Minimum 10 angka dan Maksimal 15 angka!!", "Esemka Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbOrtu_Validating(object sender, CancelEventArgs e)
        {
            if (tbOrtu.Text == "")
            {
                e.Cancel = true;
                MessageBox.Show("Nama Belum Terisi!!", "Esemka Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbNISN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbno_telepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbjurusan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbfilterkelas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbfilterjurusan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
