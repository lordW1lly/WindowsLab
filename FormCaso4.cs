using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLab
{
    public partial class FormCaso4 : Form
    {
        public FormCaso4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bttnCalcularArea_Click(object sender, EventArgs e)
        {

            Boolean circulo = chkCirculo.Checked;
            Boolean cuadrado = chkCuadrado.Checked;
            Boolean trapecio = chkTrapecio.Checked;


            if (circulo == true)
            {
            double baseORadio = Convert.ToDouble(txtBaseMenor.Text);
            double areaCirculo = 3.14 * (Math.Pow(baseORadio, 2) / 4);
                MessageBox.Show(Convert.ToString(areaCirculo));
            }
            else if (cuadrado == true)
            {
                double altura = Convert.ToDouble(txtAltura.Text);
                double baseORadio = Convert.ToDouble(txtBaseMenor.Text);
                MessageBox.Show(Convert.ToString(baseORadio * altura));
            }
            else if (trapecio == true)
            {
            double baseMayor = Convert.ToDouble(txtBaseMayor.Text);
                double baseORadio = Convert.ToDouble(txtBaseMenor.Text);
                double altura = Convert.ToDouble(txtAltura.Text);
            double areaTrapecio = ((baseORadio + baseMayor) / 2) * altura;
                MessageBox.Show(Convert.ToString(areaTrapecio));
            }


        }
    }
}
