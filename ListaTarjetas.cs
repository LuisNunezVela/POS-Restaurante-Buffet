using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Restaurante_Buffet
{
    public partial class ListaTarjetas : UserControl
    {
        public ListaTarjetas()
        {
            InitializeComponent();
            this.Click += new EventHandler(ListaTarjetas_Click);

            // Suscribir el evento de clic para todos los controles hijos
            foreach (Control control in this.Controls)
            {
                control.Click += new EventHandler(ListaTarjetas_Click);
            }
        }
        public string IdTarjeta
        {
            get { return lblNumTarjeta.Text; }
            set { lblNumTarjeta.Text = value; }
        }

        private void ListaTarjetas_Click(object sender, EventArgs e)
        {
            OnListaTarjetasClick?.Invoke(this, IdTarjeta);
        }

        public event EventHandler<string> OnListaTarjetasClick;
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
