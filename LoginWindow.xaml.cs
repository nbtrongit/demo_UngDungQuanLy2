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

namespace demo_UDQL2
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Hello", "Login", MessageBoxButton.YesNo, MessageBoxImage.Error, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
            {
                this.Title = "Yes";
            }
            else
            {
                this.Title = "No";
            }

            var images = new string[]
            {
                "animation.png",
                "checked.png",
                "animation.png",
                "fan.png",
                "fuji.png",
                "holy-gate.png",
                "kitsune.png"
            };

            var rng = new Random();
            var i = rng.Next(images.Length);

            //var image = new BitmapImage(new Uri("./Images/checked.png", UriKind.Relative));
            var image = new BitmapImage(new Uri("./Images/" + images[i], UriKind.Relative));
            accountImage.Source = image;
        }
    }
}
