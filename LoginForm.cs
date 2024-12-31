using Microsoft.Data.SqlClient;

namespace POS_Restaurante_Buffet
{
    public partial class LoginForm : Form
    {
        private readonly string _connectionString;

        public LoginForm()
        {
            InitializeComponent();

            // Obtener la cadena de conexión desde la variable de entorno
            _connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING", EnvironmentVariableTarget.Machine);

            if (string.IsNullOrEmpty(_connectionString))
            {
                MessageBox.Show("Error: La cadena de conexión no está configurada correctamente en las variables de entorno.");
                Application.Exit();
            }

            CargarUsuarios();
            txtContrasena.KeyDown += new KeyEventHandler(txtContrasena_KeyDown);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Esto previene el sonido 'beep'
                IniciarSesion();
            }
        }

        private void IniciarSesion()
        {
            string usuario = comboBoxUsuario.Text;
            string contrasena = txtContrasena.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Ingrese usuario y contraseña.");
                return;
            }

            try
            {
                if (ValidarUsuario(usuario, contrasena))
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void CargarUsuarios()
        {
            const string query = "SELECT usuario FROM usuarios";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        comboBoxUsuario.Items.Clear();
                        while (reader.Read())
                        {
                            comboBoxUsuario.Items.Add(reader["usuario"].ToString());
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error SQL al cargar usuarios: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general al cargar usuarios: {ex.Message}");
            }
        }

        private bool ValidarUsuario(string usuario, string contrasena)
        {
            const string query = "SELECT COUNT(1) FROM usuarios WHERE usuario = @usuario AND contrasena = @contrasena";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@usuario", usuario);
                        command.Parameters.AddWithValue("@contrasena", contrasena);

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count == 1;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error SQL al validar usuario: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general al validar usuario: {ex.Message}");
            }

            return false;
        }
    }
}
