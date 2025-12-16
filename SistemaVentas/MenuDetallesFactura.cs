using SistemaVentas.Utilidades;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class MenuDetallesFactura : Form
    {
        private Form formMenuPrincipal;
        private readonly UtilidadesUI resizer = new UtilidadesUI();
        private TextBox inpNumeroFactura;

        public MenuDetallesFactura(int numFactura)
        {
            InitializeComponent();


            UtilidadesUI.ApplyRoundedExceptTextBoxes(this, 12);
            AttachKeyDownToTextBoxes(this);
        }

        private void AttachKeyDownToTextBoxes(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.KeyDown += TextBox_KeyDown;
                }
                if (control.HasChildren)
                {
                    AttachKeyDownToTextBoxes(control);
                }
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
