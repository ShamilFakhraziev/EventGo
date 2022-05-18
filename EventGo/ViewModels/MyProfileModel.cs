using EventGo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGo.ViewModels
{
    public class MyProfileModel
    {
        public User User { get; set; }
        public List<Event> Events { get; set; }
     }
}
