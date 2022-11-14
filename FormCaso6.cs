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
    public partial class FormCaso6 : Form
    {
        string Nombre;
        string Apellido;
        int FechNac;






        public FormCaso6()
        {
            InitializeComponent();
        }

        private void FormCaso6_Load(object sender, EventArgs e)
        {
            var CurrentDate = DateTime.Now;
            
        }

        private void bttnMostrarNombre_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            string Apellido = txtApellido.Text;
            string NombreCompleto = Concat(Nombre, Apellido);
            MessageBox.Show(NombreCompleto);
        }

        private void bttnTodosDatos_Click(object sender, EventArgs e)
        {
            int FechNac = dateTimePicker1.Value.Year;
            string Nombre = txtNombre.Text;
            string Apellido = txtApellido.Text;
            string NombreCompleto = Concat(Nombre, Apellido, FechNac);
            MessageBox.Show(NombreCompleto);
        }


        #region Metodos
        public string Concat(string Nombre, string Apellido)
        {
            return Nombre + ", " + Apellido;
        }

        public string Concat(string Nombre, string Apellido, int FechNac)
        {
            int FechaActual = DateTime.Today.Year;
            int Edad = FechaActual - FechNac;
            return Nombre+", "+Apellido+"."+"Tiene :"+Edad+" años";


        }


        #endregion

       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
