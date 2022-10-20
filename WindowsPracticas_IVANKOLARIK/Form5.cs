using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPracticas_IVANKOLARIK
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            Imprimir();
        }


        #region mis métodos

            private void Imprimir()
            {
            string nombre = txtNombre1.Text;
            string rol = txtRol1.Text;
            string sexo = txtSexo1.Text;
                MessageBox.Show("Bienvenido :" + nombre + "" + rol + "" + sexo);
            }

        }

        #endregion
    }

