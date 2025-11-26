using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Helpers
{
    public static class RoundedControlHelper
    {
        public static void RedondearBordes(Control control, int radius)
        {
            if (control == null || radius <= 0) return;

            void ApplyRegion(Control c)
            {
                var path = new GraphicsPath();
                int w = Math.Max(0, c.Width);
                int h = Math.Max(0, c.Height);
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(w - radius, 0, radius, radius, 270, 90);
                path.AddArc(w - radius, h - radius, radius, radius, 0, 90);
                path.AddArc(0, h - radius, radius, radius, 90, 90);
                path.CloseFigure();
                c.Region = new Region(path);
            }

            ApplyRegion(control);

            // Reaplicar cuando cambie el tamaño
            control.Resize += (s, e) =>
            {
                if (s is Control c && c != null)
                {
                    ApplyRegion(c);
                }
            };
        }

        public static void RedondearTodosLosPaneles(Control parent, int radius)
        {
            if (parent == null) return;
            foreach (Control c in parent.Controls)
            {
                if (c is Panel)
                {
                    RedondearBordes(c, radius);
                }
                if (c.HasChildren)
                {
                    RedondearTodosLosPaneles(c, radius);
                }
            }
        }
    }
}