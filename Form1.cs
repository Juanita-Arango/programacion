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
            //Este c�digo permite mostrar el caracter ingresado por el usuario
            if (txtContrase�a.PasswordChar == (char)0)
                txtContrase�a.PasswordChar = '*';
            else
                txtContrase�a.PasswordChar = (Char)0;
        }

        private void txtcontrase�a_TextChanged(object sender, EventArgs e)
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