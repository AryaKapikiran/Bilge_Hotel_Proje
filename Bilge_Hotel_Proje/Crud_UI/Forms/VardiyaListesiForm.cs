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
    public partial class VardiyaListesiForm : Form
    {
        public VardiyaListesiForm()
        {
            InitializeComponent();

           

            
            
        }
        BaseRepository<Calisan> vardiyaRepository = new BaseRepository<Calisan>();
        private void VardiyaListele()
        {
            lvVardiya.Items.Clear();

            List<Calisan> calisanlar = vardiyaRepository.GetList();


            foreach (Calisan calisan in calisanlar)
            {

                ListViewItem lvi = new ListViewItem();
                lvi.Text = calisan.CalisanID.ToString();
                lvi.SubItems.Add(calisan.FirstName);
                lvi.SubItems.Add(calisan.LastName);
                lvi.SubItems.Add(calisan.Email);
                lvi.SubItems.Add(calisan.Gorev);
                lvi.SubItems.Add(calisan.VardiyaZamani.ToString());
                lvVardiya.Items.Add(lvi);


            }
        }

        private void VardiyaListesiForm_Load(object sender, EventArgs e)
        {
            VardiyaListele();
        }
    }
}
