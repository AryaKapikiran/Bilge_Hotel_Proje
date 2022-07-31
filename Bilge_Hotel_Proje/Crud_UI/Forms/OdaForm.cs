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
    public partial class OdaForm : Form
    {
        public OdaForm()
        {
            InitializeComponent();
        }

        BaseRepository<Oda> odaRepository = new BaseRepository<Oda>();

        private void OdaListele()
        {
            listView1.Items.Clear();
            cmbOdaDurumu.Items.Clear();
            cmbOdaTipi.Items.Clear();
            cmbOdaDurumu.Text = "";
            cmbOdaTipi.Text = "";
            txtid.Text = "";
            txtfiyat.Text = "";
            List<Oda> odalar = odaRepository.GetList();
            List<OdaDurumu> odadurumları = Enum.GetValues(typeof(OdaDurumu)).Cast<OdaDurumu>().ToList();
            List<OdaTipiName> odatipleri = Enum.GetValues(typeof(OdaTipiName)).Cast<OdaTipiName>().ToList();
            foreach (Oda oda in odalar)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = oda.OdaID.ToString();
                lvi.SubItems.Add(oda.OdaDurumu.ToString());
                lvi.SubItems.Add(oda.OdaTipiName.ToString());
                lvi.SubItems.Add(oda.Fiyat.ToString());
                listView1.Items.Add(lvi);
            }
           
            foreach(OdaDurumu oda in odadurumları )
            {
                cmbOdaDurumu.Items.Add(oda.ToString());
                cmbOdaDurumu.Tag = oda;

            }

            foreach(OdaTipiName odaTipi in odatipleri)
            {
                cmbOdaTipi.Items.Add(odaTipi.ToString());
                cmbOdaTipi.Tag= odaTipi;
            }
        }

        private void OdaForm_Load(object sender, EventArgs e)
        {
            OdaListele();
        }

        //ekleme
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {

                Oda oda = new Oda();
                
                oda.OdaDurumu = (OdaDurumu)cmbOdaDurumu.SelectedIndex;
                oda.OdaTipiName = (OdaTipiName)cmbOdaTipi.SelectedIndex;
                oda.Fiyat = Convert.ToInt32(txtfiyat.Text);

                string result = odaRepository.Create(oda);
                MessageBox.Show(result);
            }
           catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            OdaListele();
        }
        //Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int deger;
                deger = Convert.ToInt32(txtid.Text);
                Oda updated = odaRepository.FindById(deger);
                if(txtfiyat.Text!="")
                {
                    updated.Fiyat = Convert.ToInt32(txtfiyat.Text);


                }
                if(cmbOdaDurumu.Text!="")
                {
                    updated.OdaDurumu = (OdaDurumu)cmbOdaDurumu.SelectedIndex;
                }
                if(cmbOdaTipi.Text!="")
                {
                    updated.OdaTipiName= (OdaTipiName)cmbOdaTipi.SelectedIndex;
                }
               string result = odaRepository.Update(updated);
                MessageBox.Show(result);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            OdaListele();
        }
        //Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int deger;
                deger = Convert.ToInt32(txtid.Text);
                string result = odaRepository.Delete(deger);
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            OdaListele();
        }
    }
}
