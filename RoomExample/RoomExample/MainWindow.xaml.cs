using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
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
using RoomLibrary;

namespace RoomExample
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Room room1 = new Room();
        Room room2 = new Room();  
        Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonOpen1_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpen2.IsEnabled = true;
            room1.RoomLenght = rnd.Next(1, 11);
            room1.RoomWidth = rnd.Next(1, 11);
            int numP = rnd.Next(1, 9);

            LabelLength1.Content = room1.RoomLenght;
            LabelWidth1.Content = room1.RoomWidth;
            LabelNumPerson1.Content = numP;

            LabelPerimetr1.Content = room1.RoomPerimetr();
            LabelArea1.Content = room1.RoomArea();
            LabelPersonArea1.Content = Math.Round(room1.PersonArea(numP),3);
        }

        private void ButtonOpen2_Click(object sender, RoutedEventArgs e)
        {
            buttonAll.IsEnabled = true;

            room2.RoomLenght = Convert.ToDouble(TBLength2.Text);
            room2.RoomWidth = Convert.ToDouble(TBWIdth2.Text);
            int numP = Convert.ToInt32(TBNumPerson2.Text);

            LabelPerimetr2.Content = room2.RoomPerimetr();
            LabelArea2.Content = room2.RoomArea();
            LabelPersonArea2.Content = Math.Round(room2.PersonArea(numP),3);
        }

        private void buttonAll_Click(object sender, RoutedEventArgs e)
        {
            LabelAllArea.Content = room1.RoomArea() + room2.RoomArea();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void TBLength2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
