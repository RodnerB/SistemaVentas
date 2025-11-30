using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public class Resizer
{
    private List<ControlOriginalData> _controlsData = new List<ControlOriginalData>();
    private Size _formOriginalSize;

    public void CaptureOriginalSizes(Form form)
    {
        _formOriginalSize = form.Size;
        _controlsData.Clear();

        foreach (Control control in form.Controls)
        {
            SaveControl(control);
        }
    }

    private void SaveControl(Control control)
    {
        _controlsData.Add(new ControlOriginalData
        {
            Control = control,
            OriginalLocation = control.Location,
            OriginalSize = control.Size,
            OriginalFontSize = control.Font.Size,
            OriginalFontStyle = control.Font.Style,
            OriginalFontFamily = control.Font.FontFamily
        });

        foreach (Control child in control.Controls)
            SaveControl(child);
    }

    public void ResizeControls(Form form)
    {
        float xRatio = (float)form.Width / _formOriginalSize.Width;
        float yRatio = (float)form.Height / _formOriginalSize.Height;

        foreach (var item in _controlsData)
        {
            item.Control.Location = new Point(
                (int)(item.OriginalLocation.X * xRatio),
                (int)(item.OriginalLocation.Y * yRatio));

            item.Control.Size = new Size(
                (int)(item.OriginalSize.Width * xRatio),
                (int)(item.OriginalSize.Height * yRatio));

            // Crear la nueva fuente conservando la familia y el estilo original
            item.Control.Font = new Font(
                item.OriginalFontFamily,
                item.OriginalFontSize * Math.Min(xRatio, yRatio),
                item.OriginalFontStyle
            );
        }
    }

    private class ControlOriginalData
    {
        public required Control Control;
        public required Point OriginalLocation;
        public required Size OriginalSize;
        public required float OriginalFontSize;
        public required FontStyle OriginalFontStyle;
        public required FontFamily OriginalFontFamily;
    }
}
