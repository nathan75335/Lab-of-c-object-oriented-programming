using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace CoursWorkEv
{
    /// <summary>
    /// Interaction logic for RedactPage.xaml
    /// </summary>
    public partial class RedactPage : Window
    {
        MyPizzaCrud Admin = new MyPizzaCrud();

        public RedactPage()
        {
            InitializeComponent();
        }
        public RedactPage(MyPizza pizza)
        {
            InitializeComponent();
            TextBoxNameOfPizza.Text = pizza.Name;
            TextBoxDescriptionOfPizza.Text = pizza.Description;
            TextBoxPrice.Text = pizza.Price.ToString();
            TextBoxPicture.Text = pizza.Picture;
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            var name = TextBoxNameOfPizza.Text;
            var description = TextBoxDescriptionOfPizza.Text;
            decimal price = 0;
            try
            {
                price = Convert.ToDecimal(TextBoxPrice.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Enter the rigth Number" + exp);
            }
            var picture = TextBoxPicture.Text;

            var pizza = new MyPizza(name, description, price, picture);

            if (RadioButtonDelete.IsChecked == true)
            {
                bool testIfDeleted = Admin.DeletePizzaFromDataBase(pizza);

                if (testIfDeleted == true)
                    MessageBox.Show($"The Pizza {pizza.Name} Has Successfully Been Deleted.");
                else
                    MessageBox.Show($"The Pizza {pizza.Name} Has Not Been Deleted");
            }
            else if (RadioButtonRedact.IsChecked == true)
            {
                bool testIfUpdated = Admin.UpdatePizza(pizza);

                if (testIfUpdated == true)
                    MessageBox.Show($"The Pizza {pizza.Name} Has Successfully Been Updated.");
                else
                    MessageBox.Show($"The Pizza {pizza.Name} Has Not Been Updated");
            }
            else if (RadioButtonAdd.IsChecked == true)
            {
                bool testIfAdded = Admin.InsertANewPizzaToDatabase(pizza);

                if (testIfAdded == true && price != 0)
                {
                    MessageBox.Show($"The Pizza {pizza.Name} Has Successfully Been Added.");
                    this.Close();
                }
                else
                    MessageBox.Show($"The Pizza {pizza.Name} Has Not Been Added");
            }
        }

        private void ButtonAddLink_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();

            dialog.Title = "Open Image";

            dialog.Filter = "Image Files (*.jpg;*.png;*.jpeg)|*.JPG;*.PNG;*JPEG";

            Nullable<bool> result = dialog.ShowDialog();

            if (result == true)
            {
                TextBoxPicture.Text = dialog.FileName;
            }
            else
                TextBoxPicture.Text = "";

        }
    }
}
