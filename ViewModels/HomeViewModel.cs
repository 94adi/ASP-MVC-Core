using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.ViewModels
{
    public class HomeViewModel
    {
        public String Title { get; set; }
        public List<Pie> Pies { get; set; }
    }
}
