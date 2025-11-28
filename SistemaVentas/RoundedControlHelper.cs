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
                if (c.Width <= 0 || c.Height <= 0) return;

                int diameter = radius * 2;
                int w = Math.Max(0, c.Width);
                int h = Math.Max(0, c.Height);

                // If control is smaller than diameter, reduce radius accordingly
                int actualDiameter = Math.Min(Math.Min(diameter, w), h);
                int actualRadius = actualDiameter / 2;

                var path = new GraphicsPath();

                // Top-left arc
                path.AddArc(0, 0, actualDiameter, actualDiameter, 180, 90);
                // Top-right arc
                path.AddArc(w - actualDiameter, 0, actualDiameter, actualDiameter, 270, 90);
                // Bottom-right arc
                path.AddArc(w - actualDiameter, h - actualDiameter, actualDiameter, actualDiameter, 0, 90);
                // Bottom-left arc
                path.AddArc(0, h - actualDiameter, actualDiameter, actualDiameter, 90, 90);

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