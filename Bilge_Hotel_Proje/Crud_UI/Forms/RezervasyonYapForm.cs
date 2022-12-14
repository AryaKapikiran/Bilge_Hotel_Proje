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
    public partial class RezervasyonYapForm : Form
    {
        public RezervasyonYapForm()
        {
            InitializeComponent();
        }
        BaseRepository<Rezervasyon> rezRepository = new BaseRepository<Rezervasyon>();
        BilgeHotelContext db = new BilgeHotelContext();
        
        private void RezListele()
        {
            listView1.Items.Clear();
            txtid.Text = "";
            txtmusteri.Text = "";
            txtOdaid.Text = "";
            txtTatilPaketiId.Text = "";
            dtBaslangic.Value = DateTime.Now;
            dtBitis.Value = DateTime.Now;


            List<Rezervasyon> rezervasyonlar = rezRepository.GetList();
            foreach (Rezervasyon rez in rezervasyonlar)
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








            }
        }

        private void RezervasyonYapForm_Load(object sender, EventArgs e)
        {
            RezListele();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Rezervasyon rezervasyon = new Rezervasyon();
                Oda secilioda = db.Odalar.FirstOrDefault(x => x.OdaID == rezervasyon.OdaID);
                if (dtBaslangic.Value>= DateTime.Now&& dtBaslangic.Value<dtBitis.Value)
                {
                    rezervasyon.KonaklamaBaslangic = dtBaslangic.Value;
                    rezervasyon.KonaklamaBitis = dtBitis.Value;
                    rezervasyon.TatilPaketiID = Convert.ToInt32(txtTatilPaketiId.Text);
                    
                    rezervasyon.OdaID = Convert.ToInt32(txtOdaid.Text);
                    if (txtmusteri.Text != "")
                    {
                        rezervasyon.MusteriID = Convert.ToInt32(txtmusteri.Text);

                    }
                    else
                    {
                        //rezervasyon.MusteriID = 0;
                        MessageBox.Show("Dikkat müşteri bilgileri girişte alınacaktır");

                    }
                   
                    string result = rezRepository.Create(rezervasyon);
                    MessageBox.Show(result);



                }
                else
                {
                    MessageBox.Show("Lütfen Geçerli tarihler giriniz");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            RezListele();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int deger;
                deger = Convert.ToInt32(txtid.Text);
                Rezervasyon updated = rezRepository.FindById(deger);
                
                if (dtBaslangic.Value!=DateTime.Now && dtBitis.Value != DateTime.Now && dtBitis.Value>dtBaslangic.Value)
                {
                    updated.KonaklamaBaslangic = dtBaslangic.Value;
                    updated.KonaklamaBitis = dtBitis.Value;


                }
                else
                {
                    MessageBox.Show("Lütfen Geçerli tarihler giriniz");
                }
                if (txtOdaid.Text !="")
                {
                    updated.OdaID = Convert.ToInt32(txtOdaid.Text);
                }
                if (txtTatilPaketiId.Text !="")
                {
                    updated.TatilPaketiID = Convert.ToInt32(txtTatilPaketiId.Text);
                }
                if(txtmusteri.Text !="")
                {
                    updated.MusteriID = Convert.ToInt32(txtmusteri.Text);
                }
                updated.GunSayisi = Convert.ToInt32(dtBitis.Value - dtBaslangic.Value);


                Oda secilioda = db.Odalar.FirstOrDefault(x => x.OdaID == updated.OdaID);
                TatilPaketi seciliPaket = db.TatilPaketleri.FirstOrDefault(x => x.TatilPaketiID == updated.TatilPaketiID);

                updated.ToplamFiyat = (secilioda.Fiyat + seciliPaket.Fiyat) * updated.GunSayisi;

                string result = rezRepository.Update(updated);
                MessageBox.Show(result);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            RezListele();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int deger;
                deger = Convert.ToInt32(txtid.Text);
                string result = rezRepository.Delete(deger);
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            RezListele();
        }
    }

}
