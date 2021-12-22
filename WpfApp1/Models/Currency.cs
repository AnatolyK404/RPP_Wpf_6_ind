using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    class Currency
    {
        public int Id { get; set; }
        public string CurrencyFull { get; set; }
        public string CurrencyShort { get; set; }

        public List<Deal> Deal { get; set; } // навигационное свойство
    }
}
