using System.Configuration;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace Learning
{
    public static class GestorDeTemas
    {
        private static ResourceManager recursosActuales;

        public static void CargarTema(bool esOscuro)
        {
            if (esOscuro)
            {
                recursosActuales = new ResourceManager("Learning.Properties.WhiteTheme", Assembly.GetExecutingAssembly());
                SaveThemeSettings("claro");
            } else
            {
                recursosActuales = new ResourceManager("Learning.Properties.DarkTheme", Assembly.GetExecutingAssembly());
                SaveThemeSettings("oscuro");
            }
        }

        public static void AplicarTema(Form form)
        {
            form.BackColor = GestorDeTemas.ObtenerColor("Background");

            foreach (Control ctrl in form.Controls)
            {
                ctrl.BackColor = GestorDeTemas.ObtenerColor("Button");
            }

        }

        private static void SaveThemeSettings(string newTheme)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["Theme"].Value = newTheme;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static Color ObtenerColor(string clave)
        {
            string colorHex = recursosActuales.GetString(clave);
            return ColorTranslator.FromHtml(colorHex);
        }

    }
}
