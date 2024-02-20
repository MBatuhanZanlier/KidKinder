using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidKinder.Models
{
    public class SendMessageModel
    {
        [Required(ErrorMessage ="Lütfen adınızı boş geçmeyiniz")]
        [StringLength(30,ErrorMessage ="Lütfen en fazla 30 karekter veri girişi yapabilirsiniz")] 
        public string NameSurname { get; set; }
        [Required(ErrorMessage = "Lütfen adınızı boş geçmeyiniz")]
        [StringLength(30, ErrorMessage = "Lütfen en fazla 50 karekter veri girişi yapabilirsiniz")]
        [EmailAddress(ErrorMessage ="Lütfen geçerli bir mail adresi giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen adınızı boş geçmeyiniz")]
        [StringLength(30, ErrorMessage = "Lütfen en fazla 50 karekter veri girişi yapabilirsiniz")]
        [MinLength(5,ErrorMessage = "Lütfen en az 5 karekter veri girişi yapınız")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Lütfen adınızı boş geçmeyiniz")]
        [StringLength(1000, ErrorMessage = "Lütfen daha az karekter veri girişi yapınız")]
        public string Message { get; set; }
    }
}