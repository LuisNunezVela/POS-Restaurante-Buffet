using Microsoft.Data.SqlClient;
using System.Data;

namespace POS_Restaurante_Buffet
{
    public partial class GestionPrecios : Form
    {
        private readonly string _connectionString;
        private readonly SqlConnection _connection;

        public GestionPrecios()
        {
            InitializeComponent();

            // Obtener la cadena de conexión desde la variable de entorno
            _connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING", EnvironmentVariableTarget.Machine)
                                ?? throw new InvalidOperationException("La variable de entorno 'DB_CONNECTION_STRING' no está definida.");

            _connection = new SqlConnection(_connectionString);

            CargarProductos();
        }

        // Método para abrir la conexión si está cerrada
        private void AbrirConexion()
        {
            if (_connection.State == ConnectionState.Closed)
                _connection.Open();
        }

        // Método para cerrar la conexión si está abierta
        private void CerrarConexion()
        {
            if (_connection.State == ConnectionState.Open)
                _connection.Close();
        }

        private void CargarProductos()
        {
            const string query = "SELECT id_producto, producto, precio_unitario FROM productos";

            try
            {
                AbrirConexion();

                using (SqlDataAdapter da = new SqlDataAdapter(query, _connection))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewProductos.DataSource = dt;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error SQL al cargar productos: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general al cargar productos: {ex.Message}");
            }
            finally
            {
                CerrarConexion();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            const string query = "INSERT INTO productos VALUES (@id_producto, @producto, @precio_unitario)";

            try
            {
                AbrirConexion();

                using (SqlCommand cmd = new SqlCommand(query, _connection))
                {
                    cmd.Parameters.AddWithValue("@id_producto", int.Parse(txtCodigo.Text));
                    cmd.Parameters.AddWithValue("@producto", txtProducto.Text);
                    cmd.Parameters.AddWithValue("@precio_unitario", decimal.Parse(txtPrecio.Text));

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Producto guardado exitosamente");
                LimpiarCampos();
                CargarProductos();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error SQL al agregar producto: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general al agregar producto: {ex.Message}");
            }
            finally
            {
                CerrarConexion();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            const string query = "UPDATE productos SET producto=@producto, precio_unitario=@precio_unitario WHERE id_producto=@id_producto";

            try
            {
                AbrirConexion();

                using (SqlCommand cmd = new SqlCommand(query, _connection))
                {
                    cmd.Parameters.AddWithValue("@id_producto", int.Parse(txtCodigo.Text));
                    cmd.Parameters.AddWithValue("@producto", txtProducto.Text);
                    cmd.Parameters.AddWithValue("@precio_unitario", decimal.Parse(txtPrecio.Text));

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Producto actualizado exitosamente");
                LimpiarCampos();
                CargarProductos();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error SQL al modificar producto: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general al modificar producto: {ex.Message}");
            }
            finally
            {
                CerrarConexion();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            const string query = "DELETE FROM productos WHERE id_producto=@id_producto";

            try
            {
                AbrirConexion();

                using (SqlCommand cmd = new SqlCommand(query, _connection))
                {
                    cmd.Parameters.AddWithValue("@id_producto", int.Parse(txtCodigo.Text));
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Producto eliminado exitosamente");
                LimpiarCampos();
                CargarProductos();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error SQL al eliminar producto: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general al eliminar producto: {ex.Message}");
            }
            finally
            {
                CerrarConexion();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            const string query = "SELECT producto, precio_unitario FROM productos WHERE id_producto=@id_producto";

            try
            {
                AbrirConexion();

                using (SqlCommand cmd = new SqlCommand(query, _connection))
                {
                    cmd.Parameters.AddWithValue("@id_producto", int.Parse(txtCodigo.Text));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtProducto.Text = reader["producto"].ToString();
                            txtPrecio.Text = reader["precio_unitario"].ToString();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error SQL al buscar producto: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general al buscar producto: {ex.Message}");
            }
            finally
            {
                CerrarConexion();
            }
        }

        private void LimpiarCampos()
        {
            txtCodigo.Text = string.Empty;
            txtProducto.Text = string.Empty;
            txtPrecio.Text = string.Empty;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _connection.Dispose(); // Liberar recursos de la conexión
            base.OnFormClosing(e);
        }
    }
}
