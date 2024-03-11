using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smkstudentbaru
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void btnsiswa_Click(object sender, EventArgs e)
        {
            ChangeForm(new Kelola_Siswa());
        }

        void ChangeForm(UserControl form) 
        {
            panel1.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeForm(new Kelola_Kelas());
        }

        private void btnjurusan_Click(object sender, EventArgs e)
        {
            ChangeForm(new Kelola_Jurusan());
        }

        private void btnguru_Click(object sender, EventArgs e)
        {
            ChangeForm(new Kelola_Guru());
        }

        private void btnmapel_Click(object sender, EventArgs e)
        {
            ChangeForm(new Kelola_Mapel());
        }
    }
}
