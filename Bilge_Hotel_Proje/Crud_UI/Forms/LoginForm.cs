using DAL.Context;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //Emailler ve sifreler database ve dısarıdan girilen ile esitleniyor ve sistem karar yapılarıyla kontrol ediliyor, eger girili email e dair eşleşen görev her ne ise ve email ile şifre sistemdeki ile dogrulanıyorsa kişi görevine göre gorebildiği formlara yetki saglıyor,
        BilgeHotelContext db = new BilgeHotelContext();

        private void button1_Click(object sender, EventArgs e)
        {
            Calisan calisan = db.Calisanlar.FirstOrDefault(x => x.Email == txtemail.Text);
            if (txtemail.Text != "" && txtsifre.Text != "")
            {
                if (txtemail.Text == calisan.Email && txtsifre.Text == calisan.Password)
                {
                    if (calisan.Gorev == "İnsan Kaynakları yöneticisi")
                    {

                        IKForm ikform = new IKForm();
                        ikform.Show();
                        this.Hide();
                    }




                    else if (calisan.Gorev == "Satış yöneticisi")
                    {

                        SatisForm satform = new SatisForm();
                        satform.Show();
                        this.Hide();

                    }
                    else if (calisan.Gorev == "Resepsiyon sorumlusu")
                    {


                        ResepsiyonForm resepsiyonform = new ResepsiyonForm();
                        resepsiyonform.Show();
                        this.Hide();


                    }

                    else if (calisan.Gorev== "Resepsiyon görevlisi")
                    {
                        ResepsiyonForm resepsiyonform = new ResepsiyonForm();
                        resepsiyonform.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Diğer alanlara giriş yetkiniz yok, bilgilendirme formuna aktarılıyorsunuz");

                        VardiyaListesiForm vardiyaListesiForm = new VardiyaListesiForm();
                        vardiyaListesiForm.Show();
                        this.Hide();

                    }
                }


                else
                {
                    MessageBox.Show("Bilgiler hatalı lütfen bilgilerinizi kontrol ediniz");
                }

             }
                else
                {
                    MessageBox.Show("Lütfen bilgileri doldurdugunuzdan emin olunuz");
                }
}
    }
}
