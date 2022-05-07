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

namespace Sloppy_Joe_s_Budget_House_o__Discount_Sandwiches_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeTheMenu();
        }

        private void MakeTheMenu()
        {
            MenuItem[] menuItems = new MenuItem[5];
            string guacamolePrice;

            for (int i = 0; i < menuItems.Length; i++)
            {
                menuItems[i] = new MenuItem();
                menuItems[i].Generate();
            }

            item1.Text = menuItems[0].Description;
            price1.Text = menuItems[0].Price;
            item2.Text = menuItems[1].Description;
            price2.Text = menuItems[1].Price;
            item3.Text = menuItems[2].Description;
            price3.Text = menuItems[2].Price;
            item4.Text = menuItems[3].Description;
            price4.Text = menuItems[3].Price;
            item5.Text = menuItems[4].Description;
            price5.Text = menuItems[4].Price;

            // Can also be done as MenuItem special = new MenuItem() { Breads = new string[] {'stuff'}, Proteins = new string[] {'stuff'}...};


            MenuItem special = new MenuItem();

            special.Breads = new string[] { "a gluten free roll", "a wrap", "pita" };
            special.Proteins = new string[] { "Organic ham", "Mushroom patty", "Mortadella" };
            special.Condiments = new string[] { "dijon mustard", "miso dressing", "au jus" };

            special.Generate();

            item6.Text = special.Description;
            price6.Text = special.Price;

            MenuItem guacamoleMenuItem = new MenuItem();
            guacamoleMenuItem.Generate();
            guacamolePrice = guacamoleMenuItem.Price;
            guacamoleTB.Text = "Add guacamole for ";
            guacamolePriceTB.Text = guacamoleMenuItem.Price;
        }

        private void generateAgainBtn_Click(object sender, RoutedEventArgs e)
        {
            MakeTheMenu();
        }
    }
}
