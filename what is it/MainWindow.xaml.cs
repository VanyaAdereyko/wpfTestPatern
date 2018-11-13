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
using System.Windows.Threading;

namespace what_is_it
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += dtTicker;
            dt.Start();

            //string timeintextbox;

            //TimeSpan time = media.Position;
            //timeinmedia.Text = time.ToString();
            //timeintextbox = timeinmedia.Text;
            //if (timeintextbox == timeinmedia.Text)
            //    return;
            //for (timeintextbox = timeinmedia.Text; 





        }
        

        private void dtTicker(object sender, EventArgs e)
        {

            TimeSpan time = media.Position;
            timeinmedia.Text = time.ToString();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            media.Play();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            media.Pause();
        }

        private void value_changer(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            media.Volume = vois.Value;

        }

        private void vois_TouchUp(object sender, TouchEventArgs e)
        {

        }

        private void peremot_changer(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //media.Pause();
            media.Position = TimeSpan.FromSeconds(peremot.Value);
            media.Play();

        }

        private void Label_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
   