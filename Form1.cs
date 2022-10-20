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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnCalcular_Click(object sender, EventArgs e)
        {
            double Base = Convert.ToDouble(txtBase.Text);
            double altura = Convert.ToDouble(txtAltura.Text);
            double superficie = Base * altura;
            MessageBox.Show(Convert.ToString(superficie));

        }
    }
}
