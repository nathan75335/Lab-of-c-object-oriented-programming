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

namespace CoursWorkEv
{
    /// <summary>
    /// Interaction logic for AdministratorUI.xaml
    /// </summary>
    public partial class AdministratorUI : Window
    {
        public AdministratorUI()
        {
            InitializeComponent();
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListViewMenu.SelectedIndex == 0)
            {
                MyFrame.Content = new PizzaCatalog();

            }else if(ListViewMenu.SelectedIndex == 1)
            {
                MyFrame.Content = new HtmlPageUI();
            }else if(ListViewMenu.SelectedIndex == 2)
            {
                MyFrame.Content = new ListOfOrdersUI();
            }
        }
    }
}
