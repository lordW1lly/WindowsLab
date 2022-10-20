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
    public partial class FormCaso2 : Form
    {
        public FormCaso2()
        {
            InitializeComponent();
        }

        private void bttnInfo_Click(object sender, EventArgs e)
        {
            double edad = Convert.ToDouble(txtEdad.Text);
            if( edad == 0)
            {
                MessageBox.Show("la edad ingresada no es valida");
            } else if( edad < 18)
            {
                MessageBox.Show("la edad ingresada corresponde a un menor de edad");
            } else if( edad >= 18 && edad < 60)
            {
                MessageBox.Show("la edad ingresada corresponde a un mayor de edad");
            } else if(edad >= 60)
            {
                MessageBox.Show("la edad ingresada corresponde a un adulto mayor");
            }
        }
    }
}
