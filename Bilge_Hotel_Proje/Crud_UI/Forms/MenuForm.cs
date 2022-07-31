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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        void childForm(Form _childForm)
        {
            this.Width = _childForm.Width + 22;
            this.Height = _childForm.Height + 60;
            bool durum = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    durum = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }

            }

            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.StartPosition = FormStartPosition.Manual;
                _childForm.WindowState = FormWindowState.Maximized;
                _childForm.FormBorderStyle = FormBorderStyle.None;
                _childForm.Show();
            }
        }

        private void çalışanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new CalisanForm());
        }

        private void vardiyalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new VardiyaForm());
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new MusteriForm());
        }

        private void odalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new OdaForm());
        }

        private void rezervasyonlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new RezervasyonForm());
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
