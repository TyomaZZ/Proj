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

namespace Game1
{
    /// <summary>
    /// Логика взаимодействия для WindowSettings.xaml
    /// </summary>
    public partial class WindowSettings : Window
    {

        Window father;

        public WindowSettings(Window window)
        {
            InitializeComponent();
            father = window;
            father.IsEnabled = false;
            
        }

        private void SaveSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            father.IsEnabled = true;
            Close();
        }
    }
}
