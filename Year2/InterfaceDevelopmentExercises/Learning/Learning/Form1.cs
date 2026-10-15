using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace Learning
{
    public partial class Window: Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void darkMode_onClick(object sender, EventArgs e)
        {
            string theme = ConfigurationManager.AppSettings["Theme"];
            bool esOscuro = theme == "oscuro";
            GestorDeTemas.CargarTema(esOscuro);
            GestorDeTemas.AplicarTema(this);
        }

        private void darkModeCB_CheckedChanged(object sender, EventArgs e)
        {
            string theme = ConfigurationManager.AppSettings["Theme"];
            bool esOscuro = theme == "oscuro";
            GestorDeTemas.CargarTema(esOscuro);
            GestorDeTemas.AplicarTema(this);
        }
    }
}
