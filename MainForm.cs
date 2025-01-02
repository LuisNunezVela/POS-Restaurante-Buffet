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

        private void OpenChildForm(Form childForm)
        {
            try
            {
                if (childPanel != null)
                {
                    // Limpiar controles anteriores
                    childPanel.Controls.Clear();

                    // Configurar el nuevo formulario hijo
                    childForm.TopLevel = false;
                    childForm.FormBorderStyle = FormBorderStyle.None;
                    childForm.Dock = DockStyle.Fill;

                    // Agregar al panel
                    childPanel.Controls.Add(childForm);
                    childPanel.Tag = childForm;

                    // Mostrar formulario
                    childForm.Show();
                }
                else
                {
                    MessageBox.Show("El panel no está disponible.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el formulario hijo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGestionPrecios_Click(object sender, EventArgs e)
        {
            GestionPrecios gestionPreciosForm = new GestionPrecios();
            OpenChildForm(gestionPreciosForm);
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            CajaForm cajaForm = new CajaForm();
            OpenChildForm(cajaForm);
        }
    }
}
