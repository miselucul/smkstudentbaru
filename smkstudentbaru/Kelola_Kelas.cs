using smkstudentbaru.Class;
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
    public partial class Kelola_Kelas : UserControl
    {
        Kela kelas;
        bool isInsert = true;
        public Kelola_Kelas()
        {
            InitializeComponent();
        }

        private void Kelola_Kelas_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData(string search = "") 
        {
            var data_kelas = Global.db.Kelas
                   .Where(w => w.Nama.StartsWith(search))
                   .Select(x => new
                   {
                       tbid = x.ID,
                       kelas = x.Nama,
                       tbwali = x.Wali_Kelas_ID,
                       
                   }).OrderBy(i => i.tbid)
                     .ToArray();
            dgvkelas.DataSource = data_kelas;
            dgvkelas.RowTemplate.Height = 35;
        }
        private void tbpencarian_TextChanged(object sender, EventArgs e)
        {
            LoadData(tbpencarian.Text);
        }

        private void tbkelas_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsimpan_Click(object sender, EventArgs e) //apa yang perlu ditambahkan pada cbwalikelas?
        {
            if (isInsert)
            {
                kelas = new Kela();
                var cekNama = Global.db.Kelas.FirstOrDefault(f => f.Nama == tbkelas.Text);
                if (cekNama == null)
                {
                    kelas.Nama = tbkelas.Text;
                    Global.db.Kelas.Add(kelas);
                    Global.db.SaveChanges();
                    LoadData();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Nama Kelas sudah ada !!", "Esemka Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                var cekNama = Global.db.Kelas.FirstOrDefault(f => f.Nama == tbkelas.Text);

                if (cekNama == null || kelas.Nama == tbkelas.Text)
                {
                    kelas.Nama = tbkelas.Text;
                    Global.db.SaveChanges();
                    LoadData();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Nama Kelas sudah ada !!", "Esemka Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        void Clear()
        {
            tbpencarian.Clear();
            tbkelas.Clear();
            cbwalikelas.ResetText();

        }
        private void btnbatal_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
