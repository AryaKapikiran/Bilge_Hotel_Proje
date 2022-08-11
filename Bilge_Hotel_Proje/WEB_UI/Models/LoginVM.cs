using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEB_UI.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage = "email zorunlu")]

        public string Email { get; set; }


        [Required(ErrorMessage = "şifre zorunlu")]
        public string Password { get; set; }
    }
}