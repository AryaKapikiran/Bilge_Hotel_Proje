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
    public partial class VardiyaForm : Form
    {
        public VardiyaForm()
        {
            InitializeComponent();
        }

        BaseRepository<Vardiya> vardiyaRepository = new BaseRepository<Vardiya>();

        //Listeleme Metotu
        private void VardiyaListele()
        {
            lvVardiya.Items.Clear();
            List<Vardiya> vardiyalar = vardiyaRepository.GetList();
            foreach(Vardiya vardiya in vardiyalar)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = vardiya.VardiyaID.ToString();
                lvi.SubItems.Add(vardiya.Baslangic.ToString());
                lvi.SubItems.Add(vardiya.Bitis.ToString());
                lvVardiya.Items.Add(lvi);

            }
        }

       
        
        private void VardiyaForm_Load(object sender, EventArgs e)
        {
            VardiyaListele();
        }
        //Vardiya Ekle

        private void btnAdd_Click(object sender, EventArgs e)
        {
           Vardiya vardiya = new Vardiya();
            try
            {
                if (dtbaslangic.Value < DateTime.Now || dtbitis.Value <= DateTime.Now)
                {
                    MessageBox.Show("Lütfen ileri tarih giriniz");
                }
                else
                {
                    vardiya.Baslangic = dtbaslangic.Value;
                    vardiya.Bitis = dtbitis.Value;
                    string result = vardiyaRepository.Create(vardiya);
                    MessageBox.Show(result);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


            VardiyaListele();

            dtbaslangic.Value = DateTime.Now;
            dtbitis.Value = DateTime.Now;


        }
        //Güncelleme 

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtid.Text != "")
                {
                    int deger;
                    deger = Convert.ToInt32(txtid.Text);
                    Vardiya updated = vardiyaRepository.FindById(deger);
                    if (dtbaslangic.Value <= DateTime.Now && dtbitis.Value <= DateTime.Now || dtbaslangic.Value > dtbitis.Value)
                    {
                        MessageBox.Show("Tarih güncellemek için Lütfen ileri tarih giriniz");
                    }
                    else
                    {
                        updated.Baslangic = dtbaslangic.Value;
                        updated.Bitis = dtbitis.Value;
                        string result = vardiyaRepository.Update(updated);
                        MessageBox.Show(result);
                    }
                }

                else
                {
                    MessageBox.Show("Güncelleme yapabilmek için id giriniz");
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
           
           
            
            VardiyaListele();

            dtbaslangic.Value = DateTime.Now;
            dtbitis.Value = DateTime.Now;
        }

        //Silme

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int deger;
                deger = Convert.ToInt32(txtid.Text);
                string result = vardiyaRepository.Delete(deger);
                MessageBox.Show(result);
                VardiyaListele();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
