using expences.mvvm.view;
using expences.mvvm.viewmodel;
using System.Windows;
using System.Windows.Input;

namespace expences
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Left(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
                WindowState = WindowState.Normal;
            else WindowState = WindowState.Maximized;
        }

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void CloseClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Open_Click(object sender, RoutedEventArgs e)
        {
            ((MainViewModel)this.DataContext).CurrentView = ((MainViewModel)this.DataContext).UserVM;
        }

        private void DashClick(object sender, RoutedEventArgs e)
        {
            ((MainViewModel)this.DataContext).CurrentView = ((MainViewModel)this.DataContext).DashboardVM;
        }
        private void RecordClick(object sender, RoutedEventArgs e)
        {
            ((MainViewModel)this.DataContext).CurrentView = ((MainViewModel)this.DataContext).RecordVM;
        }
    }
}
