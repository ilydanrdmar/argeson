using System.ComponentModel.DataAnnotations;

namespace argeson.Dto
{
    public class AppUserRegisterDto

    {
        [Display(Name = "Adınız")]
        [Required(ErrorMessage = "Adınızı Boş Geçemezsiniz")]
        public string FirstName { get; set; }
        [Display(Name = "Soyadınız")]
        [Required(ErrorMessage = "Adınızı Boş Geçemezsiniz")]

        public string LastName { get; set; }
        [Display(Name = "Kullanıcı Adını Girin")]
        [Required(ErrorMessage = "Kullanıcı Adınızı Boş Geçemezsiniz")]
        public string UserName { get; set; }
        [Display(Name = "Email Girin")]
        [Required(ErrorMessage = "Email Alanını Boş Geçemezsiniz")]
        public string Email { get; set; }

        [Display(Name = "Şifre Girin")]
        [Required(ErrorMessage = "Şifre Alanını Boş Geçemezsiniz")]
        public string Password { get; set; }


    }
}
