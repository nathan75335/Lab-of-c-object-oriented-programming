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
using System.Windows.Shapes;
using MyPizzaClasses;

namespace CoursWorkEv
{
    /// <summary>
    /// Interaction logic for UserUI.xaml
    /// </summary>
    public partial class UserUI : Window
    {
        User User1 { get; set; }
        public UserUI(User user)
        {
            InitializeComponent();
            User1 = user;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListViewMenu.SelectedIndex == 0)
            {
                MyFrame.Content = new PizzaCatalogUserUI(User1.UserName);

            }else if(ListViewMenu.SelectedIndex == 1)
            {
                MyFrame.Content = new TrashUI(User1);
            }
        }
    }
}
