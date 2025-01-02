using Microsoft.Data.SqlClient;

namespace POS_Restaurante_Buffet
{
    public partial class CajaForm : Form
    {
        private readonly string _connectionString;
        private TarjetaForm _form5; // Referencia para mantener la instancia actual de Form5

        public CajaForm()
        {
            InitializeComponent();
            _connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING", EnvironmentVariableTarget.Machine);
            PopulateItems();
        }

        /// <summary>
        /// Carga las tarjetas disponibles de la base de datos y las muestra en el FlowLayoutPanel.
        /// </summary>
        private void PopulateItems()
        {
            List<ListaTarjetas> listItems = new List<ListaTarjetas>();

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "SELECT id_tarjeta FROM tarjetas WHERE en_uso = 1";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListaTarjetas tarjeta = new ListaTarjetas
                            {
                                IdTarjeta = reader["id_tarjeta"].ToString()
                            };
                            tarjeta.OnListaTarjetasClick += ListaTarjetas_Click; // Suscribirse al evento de clic
                            listItems.Add(tarjeta);
                        }
                    }
                }

                flowLayoutPanelTarjetas.Controls.Clear();

                foreach (var item in listItems)
                {
                    flowLayoutPanelTarjetas.Controls.Add(item);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error SQL al cargar tarjetas: {ex.Message}", "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general al cargar tarjetas: {ex.Message}", "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Maneja el evento de clic en una tarjeta y abre o actualiza el formulario TarjetaForm.
        /// </summary>
        private void ListaTarjetas_Click(object sender, string idTarjeta)
        {
            try
            {
                if (_form5 == null || _form5.IsDisposed)
                {
                    _form5 = new TarjetaForm();
                    _form5.SetIdTarjeta(idTarjeta);
                    _form5.FormClosed += (s, e) => _form5 = null; // Limpiar referencia al cerrar
                    _form5.Show();
                }
                else
                {
                    _form5.SetIdTarjeta(idTarjeta);
                    _form5.BringToFront(); // Llevar al frente si ya está abierto
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el formulario TarjetaForm: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Abre o actualiza el formulario TarjetaForm con el valor ingresado en el textbox.
        /// </summary>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            string value = txtNumTarjeta.Text;

            try
            {
                if (_form5 == null || _form5.IsDisposed)
                {
                    _form5 = new TarjetaForm();
                    _form5.LabelText = value;
                    _form5.FormClosed += (s, e) => _form5 = null; // Limpiar referencia al cerrar
                    _form5.Show();
                }
                else
                {
                    _form5.LabelText = value;
                    _form5.BringToFront(); // Llevar al frente si ya está abierto
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar la tarjeta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
