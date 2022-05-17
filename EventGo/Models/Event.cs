using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGo.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Введите название меропрития")]
        [Display(Name="Название мероприятия")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Введите описание")]
        [Display(Name = "Описание")]
        public string Description { get; set; }
        public string UserId { get; set; }
        [Required(ErrorMessage = "Введите дату проведения")]
        [Display(Name = "Дата проведения")]
        public DateTime DateOfTheEvent { get; set; }
        [Required(ErrorMessage = "Введите место проведения")]
        [Display(Name = "Место проведения")]
        public string Location { get; set; }
        [Display(Name = "Выберите картинку")]
        public string Image { get; set; }
        [Required(ErrorMessage = "Введите количество мест")]
        [Display(Name = "Количество мест")]
        public uint NumberOfSeats { get; set; }
        [Required(ErrorMessage = "Введите цену за билет")]
        [Display(Name = "Цена за билет")]
        public decimal Price { get; set; }
        public User User { get; set; }

    }
}
