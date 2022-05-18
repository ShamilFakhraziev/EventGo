using System.ComponentModel.DataAnnotations;

namespace EventGo.ViewModels
{
    public class Register
    {
        [Required(ErrorMessage = "Введите логин")]
        [Display(Name = "Логин")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Введите ФИО или название организации (если Вы являетесь организатором)")]
        [Display(Name = "ФИО или название организации (если Вы являетесь организатором)")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите электронную почту")]
        [Display(Name = "Электронная почта")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Введите пароль")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Введите пароль для подтверждения")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Потвердите пароль")]
        public string ConfrimPassword { get; set; } 
        
        [Display(Name="Адрес")]
        public string Address { get;set; }
        
        [Required(ErrorMessage = "Введите телефон")]
        [Display(Name="Телефон")]
        public string PhoneNumber { get;set; }
        
        [Display(Name = "Являетесь ли Вы организатором?")]
        public bool IsOrganizer { get; set; }


    }
}
