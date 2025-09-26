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
                MessageBox.Show("Por favor, ingresa un número válido en el campo de Distancia.");
                return;
            }

            if (!int.TryParse(txtDias.Text.Trim(), out Dias))
            {
                MessageBox.Show("Por favor, ingresa un número válido en el campo de Días.");
                return;
            }

            if (Distancia <= 0 || Dias <= 0)
            {
                MessageBox.Show("Por favor, asegúrate de que ambos valores sean mayores a cero.");
                return;
            }

            int precio = Distancia * 5;
            lblPrecio.Text = precio.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
