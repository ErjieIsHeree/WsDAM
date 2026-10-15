using LearningWPF;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
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

namespace PruebaExamen00
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //White
        private void ToggleMode_Checked(object sender, RoutedEventArgs e)
        {
            ThemeManager.loadTheme(true);
            ThemeManager.ApplyTheme(this);
        }

        //Dark
        private void ToggleMode_Unchecked(object sender, RoutedEventArgs e)
        {
            ThemeManager.loadTheme(false);
            ThemeManager.ApplyTheme(this);
        }
    }
}