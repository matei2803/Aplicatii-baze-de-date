using expences.mvvm.viewmodel;
using expences.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

namespace expences.mvvm.view
{
    /// <summary>
    /// Interaction logic for UserView.xaml
    /// </summary>
    public partial class UserView : UserControl
    {
        public UserView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyNewWindow newWindow = new MyNewWindow();
            newWindow.Show();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Login newWindow = new Login();
            newWindow.Show();
        }
        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}
