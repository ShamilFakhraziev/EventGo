using System.ComponentModel.DataAnnotations;

namespace EventGo.ViewModels
{
    public class Login
    {
        [Required(ErrorMessage = "Введите логин")]
        [Display(Name = "Логин")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Введите пароль")]
        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Запомнить?")]
        public bool RememberMe { get; set; }
    }
}
