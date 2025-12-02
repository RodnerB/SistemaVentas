using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaVentas.Utilidades
{
    internal class Resizer
    {
        private readonly List<ControlOriginalData> _controlsData = new();
        private Size _formOriginalSize;

        public void CaptureOriginalSizes(Form form)
        {
            if (form == null) return;
            _formOriginalSize = form.ClientSize;
            _controlsData.Clear();
            SaveControl(form);
        }

        private void SaveControl(Control control)
        {
            if (control == null) return;

            try
            {
                _controlsData.Add(new ControlOriginalData
                {
                    Control = control,
                    OriginalLocation = control.Location,
                    OriginalSize = control.Size,
                    OriginalFontSize = control.Font?.Size ?? SystemFonts.DefaultFont.Size,
                    OriginalFontStyle = control.Font?.Style ?? FontStyle.Regular,
                    OriginalFontFamily = control.Font?.FontFamily ?? SystemFonts.DefaultFont.FontFamily
                });
            }
            catch
            {
                // Ignorar controles que no permitan lectura de propiedades
            }

            foreach (Control child in control.Controls)
                SaveControl(child);
        }

        public void ResizeControls(Form form)
        {
            if (form == null) return;
            if (_formOriginalSize.Width == 0 || _formOriginalSize.Height == 0) return;

            float xRatio = (float)form.ClientSize.Width / _formOriginalSize.Width;
            float yRatio = (float)form.ClientSize.Height / _formOriginalSize.Height;
            float scale = Math.Min(xRatio, yRatio);

            foreach (var item in _controlsData)
            {
                var ctrl = item.Control;
                if (ctrl == null || ctrl.IsDisposed) continue;

                try
                {
                    ctrl.Location = new Point(
                        (int)Math.Round(item.OriginalLocation.X * xRatio),
                        (int)Math.Round(item.OriginalLocation.Y * yRatio));

                    ctrl.Size = new Size(
                        Math.Max(1, (int)Math.Round(item.OriginalSize.Width * xRatio)),
                        Math.Max(1, (int)Math.Round(item.OriginalSize.Height * yRatio)));

                    float newFontSize = Math.Max(6f, item.OriginalFontSize * scale);
                    ctrl.Font = new Font(item.OriginalFontFamily, newFontSize, item.OriginalFontStyle);
                }
                catch
                {
                    // Ignorar errores individuales
                }
            }
        }

        private class ControlOriginalData
        {
            public Control Control { get; set; } = null!;
            public Point OriginalLocation { get; set; }
            public Size OriginalSize { get; set; }
            public float OriginalFontSize { get; set; }
            public FontStyle OriginalFontStyle { get; set; }
            public FontFamily OriginalFontFamily { get; set; } = null!;
        }
    }
}
