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
    public partial class FormCaso3 : Form
    {
        public FormCaso3()
        {
            InitializeComponent();
        }

        private void bttnCalcular_Click(object sender, EventArgs e)
        {
            int numeroIngresado = Convert.ToInt16(txtNumero.Text);
            for(int i = 1; i <= 12; i++)
            {
               
                MessageBox.Show(Convert.ToString(numeroIngresado * i));
            }
        }
    }
}
