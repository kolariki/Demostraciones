using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsPracticas_IVANKOLARIK
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            ImprimirNombreCompleto(txtNombre6.Text, txtApellido6.Text, (DateTime.Today.Year - dateTime1.Value.Year ));
        }

        #region mis metodos
        private void Imprimir()
        {
            
            string nombre = txtNombre6.Text;
            string apellido= txtApellido6.Text;

            MessageBox.Show(nombre + "" + apellido);
        }

        private void ImprimirNombreCompleto(string nombre, string apellido, int fecha)
        {
            int hoy = DateTime.Today.Year;
            int anio = dateTime1.Value.Year;            

            MessageBox.Show(nombre + " " + apellido + " " + "tiene" + " " +  fecha + " " + "años");
        }
        #endregion
    }
}
