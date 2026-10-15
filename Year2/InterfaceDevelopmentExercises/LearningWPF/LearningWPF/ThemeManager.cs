using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Configuration;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LearningWPF
{
    public static class ThemeManager
    {

        private static ResourceManager actualResources;

        public static void loadTheme(bool isDarkMode)
        {
            if (isDarkMode)
            {
                actualResources = new ResourceManager("LearningWPF.Properties.WhiteTheme", Assembly.GetExecutingAssembly());
                SaveThemeSettings("white");
            }
            else
            {
                actualResources = new ResourceManager("LearningWPF.Properties.DarkTheme", Assembly.GetExecutingAssembly());
                SaveThemeSettings("dark");
            }
        }

        public static void ApplyTheme(Window window)
        {
            window.Background = ThemeManager.GetColor("Background");
            
            foreach (Control ctrl in UIHelper.GetAllControls(window))
            {
                ctrl.Background = ThemeManager.GetColor("Control");
                ctrl.Foreground = ThemeManager.GetColor("Text");
            }
            foreach (Label lbl in UIHelper.GetAllLabels(window))
            {
                lbl.Foreground = ThemeManager.GetColor("Text");
            }
        }

        private static void SaveThemeSettings(string newTheme)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["Theme"].Value = newTheme;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static SolidColorBrush GetColor(string clave)
        {
            string colorHex = actualResources.GetString(clave);
            return (SolidColorBrush)new BrushConverter().ConvertFromString(colorHex);
        }
    }
}
