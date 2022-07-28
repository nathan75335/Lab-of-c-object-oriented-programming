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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserCrud userCrud = new UserCrud();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UserButton_Click(object sender, RoutedEventArgs e)
        {
            var user = new User(UserNameTextBox.Text, PasswordTextBox.Text);

            if (AccountCheckBox.IsChecked == true)
            {
                userCrud.LoadUserFromDatabase();

                var test = userCrud.GetUserByName(UserNameTextBox.Text);

                if (test != null && userCrud.InsertANewUser(user) == false)
                {
                        var userUI = new UserUI(user);
                        userUI.Show();
     
                }else
                    MessageBox.Show("Такого Аккаунта Нет");
            }else
            {
                var test = userCrud.InsertANewUser(user);

                if (test == true)
                {
                    MessageBox.Show("Вы Создали Новый Аккаунт");
                    var userUi = new UserUI(user);
                    userUi.Show();
                }
                else
                    MessageBox.Show("Что то не так Попробуйте еще раз");
            }
        }

        private void AdministratorButton_Click(object sender, RoutedEventArgs e)
        {
            Administrator admin = new Administrator();
            if (UserNameTextBox.Text == admin.UserId && PasswordTextBox.Text == admin.Password)
            {
                var adminUi = new AdministratorUI();
                adminUi.Show();
            }
        }

        private void VisitorButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
