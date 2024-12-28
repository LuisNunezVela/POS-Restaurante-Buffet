using System;
using System.Windows.Forms;

namespace POS_Restaurante_Buffet
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGestionPrecios_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si el childPanel no es null antes de acceder a Tag
                if (childPanel != null)
                {
                    // Verificar si ya existe una instancia de GestionPrecios en el Tag
                    if (childPanel.Tag is GestionPrecios gestionPreciosForm)
                    {
                        // Si la instancia ya existe y no está visible, la mostramos
                        if (!gestionPreciosForm.Visible)
                        {
                            gestionPreciosForm.Show();
                        }
                    }
                    else
                    {
                        // Si no existe la instancia, la creamos
                        gestionPreciosForm = new GestionPrecios();
                        ConfigureChildForm(gestionPreciosForm);
                        childPanel.Controls.Add(gestionPreciosForm);
                        childPanel.Tag = gestionPreciosForm;
                        gestionPreciosForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("El panel no está disponible.");
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MessageBox.Show($"Error al manejar el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para configurar el formulario como hijo del MainForm
        private void ConfigureChildForm(GestionPrecios form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
        }
    }
}
