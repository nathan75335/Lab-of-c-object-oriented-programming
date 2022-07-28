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
    /// Interaction logic for PizzaCatalogUserUI.xaml
    /// </summary>
    public partial class PizzaCatalogUserUI : Page
    {
        TrashCrud trashCrud = new TrashCrud();
        string UserName { get; set; }

        MyPizzaCrud pizzaCrud = new MyPizzaCrud();
        public PizzaCatalogUserUI(string userName)
        {
            InitializeComponent();
            UserName = userName;
            pizzaCrud.LoadPizzaFromDataBase();
            ListBoxPizza.ItemsSource = pizzaCrud.pizzaList;
        }

        private void ListBoxPizza_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var pizza = ListBoxPizza.SelectedItem as MyPizza;

            var order = new Order(UserName, pizza.Name, pizza.Price);

            MessageBoxResult result = MessageBox.Show("Вы Хотите Добавить Эту пиццу В Корзину ?" , "PizzaHome" , MessageBoxButton.YesNo);

            if(result == MessageBoxResult.Yes) 
            {
                var test = trashCrud.InsertANewOrder(order);

                if (test == true)
                {
                    MessageBox.Show("Вы добавили пиццу в корзину");
                }
                else
                    MessageBox.Show("Что то прошло не так");
            }
        }
       
    }
}
