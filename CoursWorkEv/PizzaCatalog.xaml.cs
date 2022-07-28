using MyPizzaClasses;
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

namespace CoursWorkEv
{
    /// <summary>
    /// Interaction logic for PizzaCatalog.xaml
    /// </summary>
    public partial class PizzaCatalog : Page
    {
        MyPizzaCrud pizzaCrud = new MyPizzaCrud();
        public PizzaCatalog()
        {

            InitializeComponent();
            pizzaCrud.LoadPizzaFromDataBase();
            ListBoxPizza.ItemsSource = pizzaCrud.pizzaList;
        }

        private void AddPizza_Click(object sender, RoutedEventArgs e)
        {
            var pizzaRedact = new RedactPage();
            pizzaRedact.Show();
        }

        private void ListBoxPizza_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var pizza = ListBoxPizza.SelectedItem as MyPizza;
            var pizzaRedact = new RedactPage(pizza);
            pizzaRedact.Show();
        }
    }
}
