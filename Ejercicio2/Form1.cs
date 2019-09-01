using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            double horasTrabajadas = double.Parse(txthoras.Text);
            double valorHora = double.Parse(txtvalor.Text);
            double total = horasTrabajadas * valorHora;

            if (total > 750000 )
            {
                MessageBox.Show("El empleado gana más del mínimo.");
            }
            else
            {
                total = (total * 0.20) + total;
            }
            lbltotalsalario.Text = "$" + Convert.ToDecimal(total).ToString("N0");
            lbltotalsalario.Visible = true;
        }
    }
}
