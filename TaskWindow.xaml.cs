﻿using System;
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
        public TaskWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
        public string Login { get; set; }
        public string Password { get; set; }

        private void Click_Button2(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Если зайдете, то все ваши данне будут слиты", "Предупреждение", MessageBoxButton.YesNoCancel) == MessageBoxResult.Yes)
            {
                string messageBoxText = "Успешная регистрация!" + "\n" + "Ваши данные: " + "\n" + "Логин: " + Login + "\n" + "Пароль: " + Password;
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxResult result;

                result = MessageBox.Show(messageBoxText);
            }

        }
    }
}
