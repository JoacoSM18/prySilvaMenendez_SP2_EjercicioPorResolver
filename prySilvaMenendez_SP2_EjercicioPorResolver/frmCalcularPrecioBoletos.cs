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
                MessageBox.Show("Por favor, Ingrese un Número Válido");
                return;
            }

            if (!int.TryParse(txtDias.Text.Trim(), out Dias))
            {
                MessageBox.Show("Por favor, Ingrese un Número Válido");
                return;
            }

            if (Distancia <= 0 || Dias <= 0)
            {
                MessageBox.Show("Por Favor, Ingrese Valores Mayores a 0");
                return;
            }

            int precio = Distancia * 5;
            lblPrecio.Text = precio.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDistancia.Text = "";
            txtDias.Text = "";
            lblPrecio.Text = "";
            txtDistancia.Text = "0";
            txtDias.Text = "0";
            lblPrecio.Text = "0";
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
    }
}
