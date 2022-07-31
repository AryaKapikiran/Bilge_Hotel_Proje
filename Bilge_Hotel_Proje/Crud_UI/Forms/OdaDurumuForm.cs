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
    public partial class OdaDurumuForm : Form
    {
        public OdaDurumuForm()
        {
            InitializeComponent();
        }

        BaseRepository<Oda> odaRepository = new BaseRepository<Oda>();

        private void OdaListele()
        {
            listView1.Items.Clear();
            cmbOdaDurumu.Items.Clear();
            
            cmbOdaDurumu.Text = "";
            
            txtid.Text = "";
            
            List<Oda> odalar = odaRepository.GetList();
            List<OdaDurumu> odadurumları = Enum.GetValues(typeof(OdaDurumu)).Cast<OdaDurumu>().ToList();
           
            foreach (Oda oda in odalar)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = oda.OdaID.ToString();
                lvi.SubItems.Add(oda.OdaDurumu.ToString());
                lvi.SubItems.Add(oda.OdaTipiName.ToString());
                lvi.SubItems.Add(oda.Fiyat.ToString());
                listView1.Items.Add(lvi);
            }

            foreach (OdaDurumu oda in odadurumları)
            {
                cmbOdaDurumu.Items.Add(oda.ToString());
                cmbOdaDurumu.Tag = oda;

            }

            
        }

        private void OdaDurumuForm_Load(object sender, EventArgs e)
        {
            OdaListele();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtid.Text!="")
                {
                    int deger;
                    deger = Convert.ToInt32(txtid.Text);
                    Oda updated = odaRepository.FindById(deger);

                    if (cmbOdaDurumu.Text != "")
                    {
                        updated.OdaDurumu = (OdaDurumu)cmbOdaDurumu.SelectedIndex;
                    }

                    string result = odaRepository.Update(updated);
                    MessageBox.Show(result);
                }

                else
                {
                    MessageBox.Show("Lütfen ID girdiğinizden emin olunuz");
                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            OdaListele();
        }
    }
}
