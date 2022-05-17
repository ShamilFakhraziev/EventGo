using System.ComponentModel.DataAnnotations;

namespace EventGo.ViewModels
{
    public class AccountCashOut
    {
        [Required(ErrorMessage = ("Введите номер карты"))]
        [Display(Name = "Номер карты")]
        [RegularExpression(@"(\d{4}([-]|)\d{4}([-]|)\d{4}([-]|)\d{4})", ErrorMessage = "Некорректный номер карты")]
        public string CreditCard { get; set; }

        [Required(ErrorMessage = ("Введите сумму для вывода"))]
        [Display(Name = "Сумма для вывода")]
        public decimal? CashOutAmount { get; set; }
    }
}
