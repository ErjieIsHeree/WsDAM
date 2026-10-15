using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;

namespace LearningWPF
{
    class UIHelper
    {
        public static List<Control> GetAllControls(DependencyObject parent)
        {
            List<Control> controls = new List<Control>();

            int count = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < count; i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(parent, i);

                if (child is Control control)
                    controls.Add(control);

                controls.AddRange(GetAllControls(child));
            }

            return controls;
        }

        public static List<Label> GetAllLabels(DependencyObject parent)
        {
            List<Label> labels = new List<Label>();

            int count = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < count; i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(parent, i);

                if (child is Label label)
                    labels.Add(label);

                labels.AddRange(GetAllLabels(child));
            }

            return labels;
        }

        public static List<Panel> GetAllPanels(DependencyObject parent)
        {
            List<Panel> panels = new List<Panel>();

            int count = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < count; i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(parent, i);

                if (child is Panel panel)
                    panels.Add(panel);

                panels.AddRange(GetAllPanels(child)); // Buscar dentro de los hijos
            }

            return panels;
        }

    }

}
