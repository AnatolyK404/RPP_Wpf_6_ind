using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Models;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }
        private void Initdb()
        {
            using (ApplicationContext db = new ApplicationContext())
            {

                DealType deatyp1 = new DealType { Type = "Тип" };
                db.DealTypes.Add(deatyp1);


                DealPlace delpla1 = new DealPlace { PlaceFull = "фулл", PlaceShort = "шорт" };
                db.DealPlaces.Add(delpla1);


                Currency cur1 = new Currency { CurrencyFull = "фулл", CurrencyShort = "шорт" };
                db.Currencys.Add(cur1);


                db.SaveChanges();


                // создаем два объекта Agreement
                Deal deal1 = new Deal
                {
                    Number = 1,
                    Tiker = "dffd",
                    Order = 3,
                    Quantity = "fd",
                    Price = 33,
                    TotalCost = 444,
                    Trader = "fedfd",
                    Commition = "fdd",
                    DealType = deatyp1,
                    DealPlace = delpla1,
                    Currency = cur1

                };




                // добавляем их в БД
                db.Deals.Add(deal1);


                db.SaveChanges();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Initdb();
            textBlock.Text = "База данных создана. Объекты успешно сохранены. ";
        }
    }


}
