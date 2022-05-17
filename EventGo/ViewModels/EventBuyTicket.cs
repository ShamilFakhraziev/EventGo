using EventGo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGo.ViewModels
{
    public class EventBuyTicket
    {
        public Event Event { get; set; }
        public bool? isPurchased { get;set; }
    }
}
