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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для TaskWindow.xaml
    /// </summary>
    public partial class TaskWindow : Window
    {

        LoginData loginData = new();
        public TaskWindow()
        {
            InitializeComponent();
            DataContext = loginData;
        }

        public void Click_Button2(object sender, RoutedEventArgs e)
        {


            if (MessageBox.Show("Если зайдете, то все ваши данне будут слиты", "Предупреждение", MessageBoxButton.YesNoCancel) == MessageBoxResult.Yes)
            {
                string messageBoxText = "Успешная регистрация!" + "\n" + "Ваши данные: " + "\n" + "Логин: " + loginData.Login + "\n" + "Пароль: " + loginData.Password;
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxResult result;

                result = MessageBox.Show(messageBoxText);
                Saving.GetInstance().Save(loginData);
            }

        }
    }
}
