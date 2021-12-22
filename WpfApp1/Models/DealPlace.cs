using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    class DealPlace
    {
        public int Id { get; set; }
        public string PlaceFull { get; set; }
        public string PlaceShort { get; set; }

        public List<Deal> Deal { get; set; } // навигационное свойство
    }
}
