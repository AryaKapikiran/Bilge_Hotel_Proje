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
    public partial class TatilPaketiForm : Form
    {
        public TatilPaketiForm()
        {
            InitializeComponent();
        }
        BaseRepository<TatilPaketi> tatilpaketiRepository = new BaseRepository<TatilPaketi>();

        private void PaketListele()
        {
            txtAd.Text = "";
            txtFiyat.Text = "";
            txtid.Text = "";
            lstPaket.Items.Clear();
            List<TatilPaketi> tatilPaketleri = tatilpaketiRepository.GetList();
            foreach(TatilPaketi tatilPaketi in tatilPaketleri)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = tatilPaketi.TatilPaketiID.ToString();
                lvi.SubItems.Add(tatilPaketi.TatilPaketiName);
                lvi.SubItems.Add(tatilPaketi.Fiyat.ToString());
                lstPaket.Items.Add(lvi);
            }
        }

        private void TatilPaketiForm_Load(object sender, EventArgs e)
        {
            PaketListele();
        }

        //Ekleme
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                TatilPaketi tatilPaketi = new TatilPaketi();
                tatilPaketi.TatilPaketiName = txtAd.Text;
                tatilPaketi.Fiyat = Convert.ToInt32(txtFiyat.Text);
                string result = tatilpaketiRepository.Create(tatilPaketi);
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            PaketListele();
        }

        //Güncelleme
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtid.Text != "")
                {
                    int deger;
                    deger = Convert.ToInt32(txtid.Text);
                    TatilPaketi updated = tatilpaketiRepository.FindById(deger);
                    if (txtAd.Text != "")
                    {
                        updated.TatilPaketiName = txtAd.Text;
                    }
                    if (txtFiyat.Text != "")
                    {
                        updated.Fiyat = Convert.ToInt32(txtFiyat.Text);


                    }
                    
                    
                    string result = tatilpaketiRepository.Update(updated);
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Güncelleme yapabilmek icin lütfen id girin");
                }
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            PaketListele();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int deger;
                deger = Convert.ToInt32(txtid.Text);
                string result = tatilpaketiRepository.Delete(deger);
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            PaketListele();
        }
    }
}
