using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            decimal password = Convert.ToDecimal(txtPassword.Text);

            if (password == 123456 && name.ToUpper() == "IVAN")
            {
                MessageBox.Show("Bienvenid@");
            }
            else
            {
                MessageBox.Show("No está registrad@");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
