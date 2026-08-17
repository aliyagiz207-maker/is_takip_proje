using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje.PersonelGorevFormlari
{
    public partial class FrmPersonelFormu : Form
    {
        public FrmPersonelFormu()
        {
            InitializeComponent();
        }

        public string mail;

        PersonelGorevFormlari.FrmAktifGorevler x;
        
        private void BtnAktifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (x == null || x.IsDisposed)
            x = new PersonelGorevFormlari.FrmAktifGorevler();
            x.MdiParent = this;
            x.mail2 = mail;
            x.Show();
        }
        PersonelGorevFormlari.FrmPasifGorevler y;
        private void BtnPasifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (y == null || y.IsDisposed)
            y = new PersonelGorevFormlari.FrmPasifGorevler();
            y.MdiParent = this;
            y.mail2 = mail;
            y.Show();
        }
        PersonelGorevFormlari.FrmCagriListesi z;
        private void BtnCagriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (z == null || z.IsDisposed)
                z = new PersonelGorevFormlari.FrmCagriListesi();
            z.MdiParent = this;
            z.mail2 = mail;
            z.Show();
        }

        private void FrmPersonelFormu_Load(object sender, EventArgs e)
        {
            //this.Text = mail.ToString();
            this.Text = "Personel Paneli";
        }
    }
}
