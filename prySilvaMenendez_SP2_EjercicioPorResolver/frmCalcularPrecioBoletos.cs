using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySilvaMenendez_SP2_EjercicioPorResolver
{
    public partial class frmCalcularPrecioBoletos : Form
    {
        public frmCalcularPrecioBoletos()
        {
            InitializeComponent();
        }
        
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Distancia, Dias;
            if (!int.TryParse(txtDistancia.Text.Trim(), out Distancia))
            {
                MessageBox.Show("Por Favor, Ingrese un Número Válido");
                return;
            }

            if (!int.TryParse(txtDias.Text.Trim(), out Dias))
            {
                MessageBox.Show("Por Favor, Ingrese un Número Válido");
                return;
            }

            if (Distancia <= 0 || Dias <= 0)
            {
                MessageBox.Show("Por Favor, Ingrese Valores Mayores a 0");
                return;
            }
            int precio = Distancia * 5;
            if (Dias > 7 && Distancia > 100)
            {
                lblPrecio.Visible = true;
                precio = (int)(precio * 0.5);
                lblPrecio.Text = "El Precio Final Es De: $" + precio.ToString();
            }
            else
            {
                lblPrecio.Visible = true;
                lblPrecio.Text = "El Precio Final Es De: $" + precio.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDistancia.Text = "";
            txtDias.Text = "";
            lblPrecio.Text = "";
            txtDistancia.Text = "0";
            txtDias.Text = "0";
            lblPrecio.Text = "0";
            lblPrecio.Visible = false;
            txtDistancia.Focus();
        }

        private void txtDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }
    }
}
