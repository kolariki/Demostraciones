namespace WindowsPracticas_IVANKOLARIK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            decimal base_r = Convert.ToDecimal(txtBase.Text);
            decimal altura_r = Convert.ToDecimal(txtAltura.Text);
            MessageBox.Show("El area del rectangulo es: " + (base_r * altura_r));
        }
    }
}