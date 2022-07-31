using BLL.Repository;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_UI.Forms
{
    public partial class RezervasyonForm : Form
    {
        public RezervasyonForm()
        {
            InitializeComponent();
        }

        BaseRepository<Rezervasyon> rezRepository = new BaseRepository<Rezervasyon>();

        private void RezListele()
        {
            listView1.Items.Clear();
            

            List<Rezervasyon> rezervasyonlar = rezRepository.GetList();
            foreach(Rezervasyon rez in rezervasyonlar)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = rez.RezervasyonID.ToString();
                lvi.SubItems.Add(rez.KonaklamaBaslangic.ToString());
                lvi.SubItems.Add(rez.KonaklamaBitis.ToString());
                lvi.SubItems.Add(rez.GunSayisi.ToString());
                lvi.SubItems.Add(rez.ToplamFiyat.ToString());
                lvi.SubItems.Add(rez.TatilPaketiID.ToString());
                lvi.SubItems.Add(rez.OdaID.ToString());
                lvi.SubItems.Add(rez.RezervasyonTarihi.ToString());
                lvi.SubItems.Add(rez.MusteriID.ToString());
                listView1.Items.Add(lvi);
                
                
                int toplamrez;
                toplamrez = rezervasyonlar.Count;

                lbltoplamrez.Text = toplamrez.ToString();
               

                
               

            }


        }

        private void RezervasyonForm_Load(object sender, EventArgs e)
        {
            RezListele();
        }
    }
}
