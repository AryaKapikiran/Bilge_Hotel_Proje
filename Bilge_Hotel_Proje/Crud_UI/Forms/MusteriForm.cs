
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

        
    }
}
