using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace POS_Restaurante_Buffet
{
    public partial class TarjetaForm : Form
    {
        private readonly string _connectionString;

        public TarjetaForm()
        {
            InitializeComponent();
            _connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING", EnvironmentVariableTarget.Machine);
            LoadComboBox();
            comboBoxProductos.SelectedIndexChanged += comboBoxProductos_SelectedIndexChanged;
        }

        // Propiedad para establecer el ID de la tarjeta
        public void SetIdTarjeta(string idTarjeta) => lblTarjeta.Text = idTarjeta;

        public string LabelText
        {
            get => lblTarjeta.Text;
            set => lblTarjeta.Text = value;
        }

        /// <summary>
        /// Carga los productos en el ComboBox desde la base de datos.
        /// </summary>
        private void LoadComboBox()
        {
            const string query = "SELECT id_producto, producto, precio_unitario FROM productos";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    comboBoxProductos.DataSource = dataTable;
                    comboBoxProductos.DisplayMember = "producto";
                    comboBoxProductos.ValueMember = "id_producto";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Agrega un producto seleccionado a la tarjeta.
        /// </summary>
        /// <summary>
        /// Actualiza el DataGridView con los productos asociados a una tarjeta.
        /// </summary>
        /// <summary>
        /// Actualiza los labels de producto y precio al cambiar el producto seleccionado.
        /// </summary>
        private void comboBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProductos.SelectedItem is DataRowView selectedRow)
            {
                lblCodigoProducto.Text = selectedRow["id_producto"].ToString();
                lblPrecioProducto.Text = selectedRow["precio_unitario"].ToString();
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(lblTarjeta.Text, out int idTarjeta) ||
                !int.TryParse(lblCodigoProducto.Text, out int idProducto) ||
                !int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Uno o más valores de entrada no son válidos.");
                return;
            }

            decimal precioUnitario;
            decimal total;

            const string priceQuery = "SELECT precio_unitario FROM productos WHERE id_producto = @id_producto";
            const string checkQuery = "SELECT en_uso FROM tarjetas WHERE id_tarjeta = @id_tarjeta";
            const string insertConsumoQuery = "INSERT INTO consumo (id_tarjeta, id_producto, cantidad, glosa) VALUES (@id_tarjeta, @id_producto, @cantidad, @glosa)";
            const string updateTarjetaQuery = "UPDATE tarjetas SET en_uso = 1 WHERE id_tarjeta = @id_tarjeta"; // Agregar actualización

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    // Obtener el precio unitario
                    using (SqlCommand priceCommand = new SqlCommand(priceQuery, connection))
                    {
                        priceCommand.Parameters.AddWithValue("@id_producto", idProducto);
                        object priceResult = priceCommand.ExecuteScalar();

                        if (priceResult == null)
                        {
                            MessageBox.Show("El producto seleccionado no existe.");
                            return;
                        }

                        precioUnitario = Convert.ToDecimal(priceResult);
                        total = precioUnitario * (decimal)cantidad;
                    }

                    // Verificar si la tarjeta existe y su estado
                    bool tarjetaExiste;
                    bool tarjetaEnUso;

                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@id_tarjeta", idTarjeta);
                        object result = checkCommand.ExecuteScalar();

                        tarjetaExiste = result != null;
                        tarjetaEnUso = tarjetaExiste && Convert.ToInt32(result) == 1;
                    }

                    // Insertar consumo
                    using (SqlCommand insertConsumoCommand = new SqlCommand(insertConsumoQuery, connection))
                    {
                        insertConsumoCommand.Parameters.AddWithValue("@id_tarjeta", idTarjeta);
                        insertConsumoCommand.Parameters.AddWithValue("@id_producto", idProducto);
                        insertConsumoCommand.Parameters.AddWithValue("@cantidad", cantidad);
                        insertConsumoCommand.Parameters.AddWithValue("@glosa", total);

                        int consumoResult = insertConsumoCommand.ExecuteNonQuery();

                        if (consumoResult > 0)
                        {
                            // Si se insertó el producto, actualizar el estado de la tarjeta
                            using (SqlCommand updateTarjetaCommand = new SqlCommand(updateTarjetaQuery, connection))
                            {
                                updateTarjetaCommand.Parameters.AddWithValue("@id_tarjeta", idTarjeta);
                                updateTarjetaCommand.ExecuteNonQuery();
                            }

                            MessageBox.Show("Producto agregado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el producto.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(lblTarjeta.Text, out int idTarjeta))
            {
                MessageBox.Show("El valor de id_tarjeta no es un número válido.");
                return;
            }

            const string query = @"
                SELECT 
                    c.id_tarjeta AS [ID Tarjeta], 
                    c.id_producto AS [ID Producto], 
                    p.producto AS Producto, 
                    p.precio_unitario AS [Precio Unitario], 
                    c.glosa AS Glosa 
                FROM consumo c
                INNER JOIN productos p ON c.id_producto = p.id_producto
                WHERE c.id_tarjeta = @id_tarjeta";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@id_tarjeta", idTarjeta);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
