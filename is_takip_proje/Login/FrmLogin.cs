using DevExpress.XtraEditors;
using is_takip_proje.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        Dbis_TakipEntities db = new Dbis_TakipEntities();

        private void BtnPersonel_Click(object sender, EventArgs e)
        {
            var personelvalue = db.TblPersonel.Where(x => x.Mail == TxtKullanici.Text && x.Sifre == TxtSifre.Text).FirstOrDefault();
            if (personelvalue != null)
            {
                PersonelGorevFormlari.FrmPersonelFormu fr = new PersonelGorevFormlari.FrmPersonelFormu();
                fr.mail = TxtKullanici.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
        }

        private void textEdit1_Click(object sender, EventArgs e)
        {
            panel3.BackColor = SystemColors.Control;
            panel2.BackColor = Color.LightGray;
        }

        private void textEdit2_Click(object sender, EventArgs e)
        {
            panel2.BackColor = SystemColors.Control;
            panel3.BackColor = Color.LightGray;
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            var adminvalue = db.TblAdmin.Where(x => x.Kullanici == TxtKullanici.Text && x.Sifre == TxtSifre.Text).FirstOrDefault();
            if (adminvalue != null)
            {
                XtraMessageBox.Show("Hoşgeldiniz!");
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
        }
    }
}
