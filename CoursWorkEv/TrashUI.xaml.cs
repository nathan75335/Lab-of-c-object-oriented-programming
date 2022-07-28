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
    /// Interaction logic for TrashUI.xaml
    /// </summary>
    public partial class TrashUI : Page
    {
        TrashCrud trashCrud = new TrashCrud();

        OrderCrud orderCrud = new OrderCrud();
        User User { get; set; } 
        public TrashUI(User user)
        {
            InitializeComponent();
            User = user;
            trashCrud.LoadOrdersFromDatabase();
            var pizzas = (from order in trashCrud.orders
                          where order.UserName == user.UserName
                          select order).ToList();
            DataGridDataTrash.ItemsSource = pizzas;
        }

        private void ButtonOrder_Click(object sender, RoutedEventArgs e)
        {
            var order1 = DataGridDataTrash.SelectedItem as Order;

            var order = new Order(User.UserName,order1.NameOfPizza,order1.Price, DateTime.Now);

            MessageBoxResult result = MessageBox.Show("Do You Want To Buy This Pizza ??", "Pizza Home", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes && order1 != null)
            {
                var test = orderCrud.InsertANewOrder(order);

                if (test == true)
                {
                    MessageBox.Show("You Successfully bought the Pizza");
                }
                else
                    MessageBox.Show("Couldn't Buy this Pizza ");

            }
            else
                MessageBox.Show("Oups....");
        }
    }
}
