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

namespace GameShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Numpad.Visibility = Visibility.Hidden;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        public void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Seller_Checked(object sender, RoutedEventArgs e)
        {
            if(Manager.IsChecked == true)
            {
                Manager.IsChecked = false;
            }

            if (Admin.IsChecked == true)
            {
                Admin.IsChecked = false;
            }
        }

        private void Manager_Checked(object sender, RoutedEventArgs e)
        {
            if (Seller.IsChecked == true)
            {
                Seller.IsChecked = false;
            }

            if (Admin.IsChecked == true)
            {
                Admin.IsChecked = false;
            }

        }

        private void Admin_Checked(object sender, RoutedEventArgs e)
        {
            if (Manager.IsChecked == true)
            {
                Manager.IsChecked = false;
            }

            if (Seller.IsChecked == true)
            {
                Seller.IsChecked = false;
            }

        }

        private void Password_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Numpad.Visibility = Visibility.Visible;
        }
    }
}
