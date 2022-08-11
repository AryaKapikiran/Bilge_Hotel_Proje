using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEB_UI.Models
{
    public class KullaniciVM
    {
        [Required(ErrorMessage = "email zorunlu")]

        public string Email { get; set; }


        [Required(ErrorMessage = "şifre zorunlu")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre(Tekrar) boş geçilemez!")]
        [Display(Name = "Şifre Tekrar")]
        
        [Compare("Password", ErrorMessage = "şifreler aynı değil!")]
        public string ConfirmPassword { get; set; }


        [Required(ErrorMessage = "TC kimlik numarası zorunludur")]
        
        public string TCKN { get; set; }

        [Required(ErrorMessage = "isim zorunlu")]

        public string Ad { get; set; }
       
        [Required(ErrorMessage = "soyad zorunlu")]

        public string Soyad { get; set; }

        

        public string TelNo { get; set; }

       





    }
}