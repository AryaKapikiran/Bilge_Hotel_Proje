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
    public partial class TatilPaketBilgi : Form
    {
        public TatilPaketBilgi()
        {
            InitializeComponent();
        }

        BaseRepository<TatilPaketi> tatilpaketiRepository = new BaseRepository<TatilPaketi>();
        private void PaketListele()
        {
            
            lstPaket.Items.Clear();
            List<TatilPaketi> tatilPaketleri = tatilpaketiRepository.GetList();
            foreach (TatilPaketi tatilPaketi in tatilPaketleri)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = tatilPaketi.TatilPaketiID.ToString();
                lvi.SubItems.Add(tatilPaketi.TatilPaketiName);
                lvi.SubItems.Add(tatilPaketi.Fiyat.ToString());
                lstPaket.Items.Add(lvi);
            }
        }
        private void TatilPaketBilgi_Load(object sender, EventArgs e)
        {
            PaketListele();
        }
    }
}
