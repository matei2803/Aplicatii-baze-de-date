using expences.mvvm.view;
using expences.mvvm.viewmodel;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace expences
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MyNewWindow : Window
    {
        public MyNewWindow()
        {
            InitializeComponent();
        }

        private Button activeButton = null;

        private void Window_Left(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }

        private bool isButtonPressed = false;

        private void ImageButton_Click(object sender, RoutedEventArgs e)
        {
            isButtonPressed = !isButtonPressed;
            if (isButtonPressed)
            {
                imageButton.Background = Brushes.Black;
                imageButton.Opacity = 0.5;
                imageButton.RenderTransform = new ScaleTransform(1.05, 1.05);
                ImageButton2_Click(sender, e);
            }
            else
            {
                imageButton.ClearValue(Button.BackgroundProperty);
                imageButton.ClearValue(Button.OpacityProperty);
                imageButton.ClearValue(Button.RenderTransformProperty);
            }
        }

        private void ImageButton2_Click(object sender, RoutedEventArgs e)
        {
            isButtonPressed = !isButtonPressed;
            if (isButtonPressed)
            {
                imageButton2.Background = Brushes.Black;
                imageButton2.Opacity = 0.5;
                imageButton2.RenderTransform = new ScaleTransform(1.05, 1.05);
                ImageButton_Click(sender, e);
            }
            else
            {
                imageButton2.ClearValue(Button.BackgroundProperty);
                imageButton2.ClearValue(Button.OpacityProperty);
                imageButton2.ClearValue(Button.RenderTransformProperty);
            }
        }

        private void ImageButton3_Click(object sender, RoutedEventArgs e)
        {
            imageButton3.Background = Brushes.Transparent;
            imageButton3.Opacity = 1.0;
            imageButton3.RenderTransform = null;

            imageButton4.Background = Brushes.Transparent;
            imageButton4.Opacity = 1.0;
            imageButton4.RenderTransform = null;

            imageButton5.Background = Brushes.Transparent;
            imageButton5.Opacity = 1.0;
            imageButton5.RenderTransform = null;

            // Activează butonul apăsat
            if (sender is Button clickedButton)
            {
                clickedButton.Background = Brushes.Black;
                clickedButton.Opacity = 0.5;
                clickedButton.RenderTransform = new ScaleTransform(1.05, 1.05);
                activeButton = clickedButton;
            }
        }
    

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
                WindowState = WindowState.Normal;
            else WindowState = WindowState.Maximized;
        }

        private void Image_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Image_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation
            {
                To = this.ActualWidth - column1.ActualWidth,
                Duration = TimeSpan.FromSeconds(0.5)
            };

            column1.BeginAnimation(ColumnDefinition.WidthProperty, animation);
        }




        /* private void Window_Left(object sender, System.Windows.Input.MouseButtonEventArgs e)
{
    DragMove();
}

private void MinimizeClick(object sender, RoutedEventArgs e)
{
    WindowState = WindowState.Minimized;
}
private void MaximizeClick(object sender, RoutedEventArgs e)
{
    if (WindowState == WindowState.Maximized)
        WindowState = WindowState.Normal;
    else WindowState = WindowState.Maximized;
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
}*/
    }
}
