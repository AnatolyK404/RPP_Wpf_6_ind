using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    class Deal
    {
        public int Id { get; set; } // первичный ключ
        public int Number { get; set; } 

        public string Tiker { get; set; }
        public int Order { get; set; }
        public string Quantity { get; set; }
        public int Price { get; set; }
        public int TotalCost { get; set; }
        public string Trader { get; set; }
        public string Commition { get; set; }


        public int PlaceId { get; set; } // внешний ключ
        public int TypeId { get; set; } // внешний ключ 
        public int CurrencyId { get; set; } //внешний ключ


        public DealType DealType { get; set; } // навигационное свойство
        public DealPlace DealPlace { get; set; } // навигационное свойство
        public Currency Currency { get; set; } // навигационное свойство
    }
}
