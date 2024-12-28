namespace POS_Restaurante_Buffet
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Crear una instancia de Form2
            MainForm MainForm = new MainForm();

            // Mostrar Form2
            MainForm.Show();
            this.Hide();
        }
    }
}
