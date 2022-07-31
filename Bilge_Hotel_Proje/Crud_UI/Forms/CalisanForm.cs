
using BLL.Repository;
using DAL.Entity;
using DAL.Enums;
using DAL.Map;
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
    public partial class CalisanForm : Form
    {
        public CalisanForm()
        {
            InitializeComponent();
        }

        BaseRepository<Calisan> calisanRepository = new BaseRepository<Calisan>();
        
       
        //Listeleme 
        private void CalisanListele()
        {
            lstCalisan.Items.Clear();
            List<Calisan> calisanlar =  calisanRepository.GetList();
            

            foreach (Calisan calisan in calisanlar)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = calisan.CalisanID.ToString();
                lvi.SubItems.Add(calisan.FirstName);
                lvi.SubItems.Add(calisan.LastName);
                lvi.SubItems.Add(calisan.Email);
                lvi.SubItems.Add(calisan.Ucret.ToString());
                lvi.SubItems.Add(calisan.SaatSayisi.ToString());
                lvi.SubItems.Add(calisan.VardiyaID.ToString());
                lvi.SubItems.Add(calisan.Maas.ToString());
                lvi.SubItems.Add(calisan.Gorev);
                lstCalisan.Items.Add(lvi);
            }
        }
        

        private void CalisanForm_Load(object sender, EventArgs e)
        {
            CalisanListele();

            ////Enumları liste halinde gosterme

            //List<Gorev> gorevler = Enum.GetValues(typeof(Gorev)).Cast<Gorev>().ToList();
            
            //foreach(Gorev gorev in gorevler)
            //{
            //    RadioButton rb = new RadioButton();
            //    rb.Text = gorev.ToString();
            //    rb.Tag = gorev;
                
            //    flowLayoutPanel1.Controls.Add(rb);
            //    rb.Checked = false;
                
            //}
        }

        //Ekleme işlemi
        //Map'e göre eklemeye geri dönüp bak
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            
            
            try
            {
                Calisan calisan = new Calisan();
                calisan.FirstName = txtad.Text;
                calisan.LastName = txtsoyad.Text;
                calisan.Email = txtemail.Text;
                calisan.Password = txtsifre.Text;
                calisan.Ucret = Convert.ToDecimal(txtucret.Text);
                calisan.Gorev = txtgorev.Text;
                calisan.SaatSayisi = Convert.ToInt32(nudSaat.Value);
              
                if (txtvardiyaId.Text == "")
                {
                    calisan.VardiyaID = null;
                }
                else
                {
                    calisan.VardiyaID = Convert.ToInt32(txtvardiyaId.Text);
                }
               
                string result = calisanRepository.Create(calisan);
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            CalisanListele();
        }
                
            
        
        //Güncelleme
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int deger;
                deger = Convert.ToInt32(txtid.Text);

                Calisan updated = calisanRepository.FindById(deger);
                if (txtad.Text != "")
                {
                    updated.FirstName = txtad.Text;
                }

                if (txtsoyad.Text != "")
                {
                    updated.LastName = txtsoyad.Text;
                }

                if (txtemail.Text != "")
                {
                    updated.Email = txtemail.Text;


                }

                if (txtsifre.Text != "")
                {
                    updated.Password = txtsifre.Text;
                }
                if (txtucret.Text != "")
                {

                    try
                    {
                        updated.Ucret = Convert.ToDecimal(txtucret.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (txtgorev.Text != "")
                {
                    updated.Gorev = txtgorev.Text;
                }



                if (txtvardiyaId.Text != "")
                {
                    updated.VardiyaID = Convert.ToInt32(txtvardiyaId.Text);
                }


                string result = calisanRepository.Update(updated);
                MessageBox.Show(result);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
                       CalisanListele();

        }

        //Silme
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int deger;
                deger = Convert.ToInt32(txtid.Text);
                string result = calisanRepository.Delete(deger);
                MessageBox.Show(result);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            CalisanListele();
        }
    }

           
            
            
    }

