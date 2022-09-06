
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
    public partial class MusteriForm : Form
    {
        public MusteriForm()
        {
            InitializeComponent();
        }
        BaseRepository<Musteri> musteriRepository =new BaseRepository<Musteri>();
        
        

        private void MusteriListele()
        {
            listView1.Items.Clear();
            txtid.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtmail.Text = "";
            txtTCKN.Text = "";
            txtTelNo.Text = "";
            List<Musteri> musteriler = musteriRepository.GetList();
            
           
            foreach(Musteri musteri in musteriler)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = musteri.MusteriID.ToString();
                lvi.SubItems.Add(musteri.Ad);
                lvi.SubItems.Add(musteri.Soyad);
                lvi.SubItems.Add(musteri.TCKN);
                lvi.SubItems.Add(musteri.Email);
                lvi.SubItems.Add(musteri.TelNo);
                
                listView1.Items.Add(lvi);
            }
        }
        private void MusteriForm_Load(object sender, EventArgs e)
        {
            MusteriListele();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Musteri musteri = new Musteri();
                musteri.Ad = txtAd.Text;
                musteri.Soyad = txtSoyad.Text;
                musteri.Email = txtmail.Text;
                musteri.TCKN = txtTCKN.Text;
                musteri.TelNo = txtTelNo.Text;
                musteri.Password = "1234";
                string result = musteriRepository.Create(musteri);
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            MusteriListele();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
                try
                {
                    int deger;
                    deger = Convert.ToInt32(txtid.Text);
                    Musteri updated = musteriRepository.FindById(deger);
                    if (txtAd.Text !="")
                    {

                        updated.Ad = txtAd.Text;

                    }
                   
                    if (txtSoyad.Text != "")
                    {
                        updated.Soyad = txtAd.Text;
                    }
                    if (txtmail.Text != "")
                    {
                        updated.Email = txtmail.Text;
                    }
                    if (txtTCKN.Text != "")
                    {
                        updated.TCKN = txtTCKN.Text;
                    }
                   if(txtTelNo.Text !="")
                    {
                        updated.TelNo = txtTelNo.Text;
                    }

                    string result = musteriRepository.Update(updated);
                    MessageBox.Show(result);
                }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            MusteriListele();
        }
    }
}
