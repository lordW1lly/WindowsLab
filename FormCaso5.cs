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
    public partial class FormCaso5 : Form
    {
        public FormCaso5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttnValidar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            Boolean masculino = chkMasculino.Checked;
            Boolean fem = chkFemenino.Checked;
            Boolean adm = chkAdmin.Checked;
            Boolean estandar = chkEstandar.Checked;
            Boolean invitado = chkInvitado.Checked;

            if(nombre == "")
            {
                MessageBox.Show("Por favor, ingrese un nombre");
            } else if(nombre == "Seba" && masculino == true && adm == true)
            {
                MessageBox.Show("Bienvenido, " + nombre + ", tu genero es: " + masculino + ", tu rol es: " + adm);
            }
        }
    }
}
