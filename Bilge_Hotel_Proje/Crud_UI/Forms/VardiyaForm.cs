using BLL.Repository;
using DAL.Entity;
using DAL.Enums;
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
    public partial class VardiyaForm : Form
    {
        public VardiyaForm()
        {
            InitializeComponent();
        }

        BaseRepository<Calisan> vardiyaRepository = new BaseRepository<Calisan>();

        //Listeleme Metotu
        private void VardiyaListele()
        {
            lvVardiya.Items.Clear();
            cmbVardiya.Items.Clear();
            cmbVardiya.Text = "";
            List<Calisan> calisanlar = vardiyaRepository.GetList();
            List<VardiyaZamani> vardiyazamanlari = Enum.GetValues(typeof(VardiyaZamani)).Cast<VardiyaZamani>().ToList();

            foreach (Calisan calisan in calisanlar)
            {
                
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = calisan.CalisanID.ToString();
                    lvi.SubItems.Add(calisan.FirstName);
                    lvi.SubItems.Add(calisan.VardiyaZamani.ToString());
                    lvVardiya.Items.Add(lvi);
                
                
            }

            foreach(VardiyaZamani vardiyaZamani in vardiyazamanlari)
            {
                cmbVardiya.Items.Add(vardiyaZamani);
                cmbVardiya.Tag = vardiyaZamani;
            }





        }

       
        
        private void VardiyaForm_Load(object sender, EventArgs e)
        {
            VardiyaListele();
        }
        //Vardiya Ekle

       
        //Güncelleme 

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtid.Text!="")
                {
                    if(cmbVardiya.Text!="")
                    {
                        int deger;
                        deger = Convert.ToInt32(txtid.Text);
                        Calisan updated = vardiyaRepository.FindById(deger);
                        updated.VardiyaZamani = (VardiyaZamani)cmbVardiya.SelectedIndex;
                        string result = vardiyaRepository.Update(updated);
                        MessageBox.Show(result);

                    }
                   
                }

                else
                {
                    MessageBox.Show("Vardiya zamanlarını degistirmek icin lütfen id giriniz.");
                    }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
           
            
            VardiyaListele();

            
        }

       

       
    }
}
