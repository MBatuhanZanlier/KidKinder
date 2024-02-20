using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidKinder.Models
{
    public class SendMessageViewModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı boş geçmeiyiniz")]
        [StringLength(30, ErrorMessage = "Lütfen en fazla 30 karekter veri girişi yapınız")]
        public string NameSurname { get; set; }

        [Required(ErrorMessage = "Lütfen Adınızı boş geçmeiyiniz")]
        [StringLength(30, ErrorMessage = "Lütfen en fazla 30 karekter veri girişi yapınız")]
        [EmailAddress(ErrorMessage ="Lütfen geçerli bir mail adresini giriniz")]
        public string Email { get; set; }
    }
}