using BLL.Repository;
using DAL.Context;
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
    public partial class MusteriOda : Form
    {
        public MusteriOda()
        {
            InitializeComponent();
        }

        BilgeHotelContext db = new BilgeHotelContext();
       
        BaseRepository<Rezervasyon> rezRepo = new BaseRepository<Rezervasyon>();

        private void Listele()
        {
            listView1.Items.Clear();
            List<Rezervasyon> rezervasyons = rezRepo.GetList();
            
            foreach(Rezervasyon rezervasyon in rezervasyons)
            {
                Musteri musteri = db.Musteriler.FirstOrDefault(x => x.MusteriID == rezervasyon.MusteriID);
                Oda oda = db.Odalar.FirstOrDefault(x => x.OdaID == rezervasyon.OdaID);
                TatilPaketi tatilPaketi = db.TatilPaketleri.FirstOrDefault(x=>x.TatilPaketiID==rezervasyon.TatilPaketiID);
                ListViewItem lvi = new ListViewItem();
                lvi.Text = rezervasyon.MusteriID.ToString();
                lvi.SubItems.Add(musteri.Ad);
                lvi.SubItems.Add(musteri.Soyad);
                lvi.SubItems.Add(oda.OdaTipiName.ToString());
                lvi.SubItems.Add(tatilPaketi.TatilPaketiName);
                lvi.SubItems.Add(rezervasyon.OdaID.ToString());
                lvi.SubItems.Add(rezervasyon.RezervasyonID.ToString());
                lvi.SubItems.Add(musteri.TCKN).ToString();
                lvi.SubItems.Add(musteri.TelNo);
                lvi.SubItems.Add(rezervasyon.KonaklamaBaslangic.ToString());
                lvi.SubItems.Add(rezervasyon.KonaklamaBitis.ToString());
                listView1.Items.Add(lvi);
            }

        }
        private void MusteriOda_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
