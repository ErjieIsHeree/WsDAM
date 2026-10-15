using System.Configuration;
using System.Windows;

namespace LearningWPF
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

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            ThemeManager.loadTheme(ConfigurationManager.AppSettings["Theme"] == "dark");
            ThemeManager.ApplyTheme(this);
        }
    }
}
