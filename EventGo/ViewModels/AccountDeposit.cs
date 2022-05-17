using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EventGo.ViewModels
{
    public class AccountDeposit
    {
        [Required(ErrorMessage = ("Введите номер карты"))]
        [RegularExpression(@"(\d{4}([-]|)\d{4}([-]|)\d{4}([-]|)\d{4})", ErrorMessage = "Некорректный номер карты")]
        [Display(Name = "Номер карты")]
        public string CreditCard { get; set; }

        [Required(ErrorMessage = ("Введите сумму для пополнения"))]
        [Display(Name = "Сумма для пополнения")]
        public decimal? DepositAmount { get; set; }

    }
}
