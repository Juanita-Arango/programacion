namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            var form = new FormularioPaciente();
            form.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Este código permite mostrar el caracter ingresado por el usuario
            if (txtContraseña.PasswordChar == (char)0)
                txtContraseña.PasswordChar = '*';
            else
                txtContraseña.PasswordChar = (Char)0;
        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}