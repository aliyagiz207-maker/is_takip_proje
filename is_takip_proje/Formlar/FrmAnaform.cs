using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using is_takip_proje.Entity;

namespace is_takip_proje.Formlar
{
    public partial class FrmAnaform : Form
    {
        public FrmAnaform()
        {
            InitializeComponent();
        }
        Dbis_TakipEntities db = new Dbis_TakipEntities();
        private void FrmAnaform_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblGorevler select new
        {
            x.Aciklama,
            x.Durum,
            GorevVeren = x.TblPersonel.Ad + " " + x.TblPersonel.Soyad,
            GorevAlan = x.TblPersonel.Ad + " " + x.TblPersonel.Soyad
            }).Where(x => x.Durum == true).ToList();

            gridView1.Columns["Durum"].Visible = false;

            //Bugün Yapılan Görevler
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            //MessageBox.Show(bugun.ToString());
            gridControl2.DataSource = (from x in db.TblGorevDetaylar select new
            {  
            Gorev = x.TblGorevler.Aciklama,
            x.Aciklama,
            x.Tarih
            }).Where(x => x.Tarih == bugun).ToList();
        

        //Aktif Çağrı Listesi
        gridControl3.DataSource = (from x in db.TblCagrilar select new
        {
            x.TblFirmalar.Ad,
            x.Konu,
            x.Tarih,
            x.Durum
        }).Where(x => x.Durum == true).ToList();
            gridView3.Columns["Durum"].Visible = false;

        // Fihrist Komutları

            gridControl4.DataSource = (from x in db.TblFirmalar select new
        {
         x.Ad,
         x.Telefon,
         x.Mail
        }).ToList();


        //Çağrı Grafikleri

        int aktif_cagrilar = db.TblCagrilar.Where(x => x.Durum == true).Count();
        int pasif_cagrilar = db.TblCagrilar.Where(x => x.Durum == false).Count();

           if (chartControl1.Series.Count > 0)
            {
                var series = chartControl1.Series[0];
                series.Points.Clear();
                series.Points.AddPoint("Aktif Çağrılar", aktif_cagrilar);
                series.Points.AddPoint("Pasif Çağrılar", pasif_cagrilar);
            }
            else
            {
                MessageBox.Show("Grafikte hiçbir seri tanımlanmamış!");
            }

        }

        }
    }