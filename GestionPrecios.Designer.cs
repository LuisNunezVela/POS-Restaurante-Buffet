namespace POS_Restaurante_Buffet
{
    partial class GestionPrecios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            dataGridViewProductos = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(281, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(174, 24);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Precios";
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.AllowUserToAddRows = false;
            dataGridViewProductos.AllowUserToDeleteRows = false;
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(12, 128);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.ReadOnly = true;
            dataGridViewProductos.RowHeadersWidth = 51;
            dataGridViewProductos.Size = new Size(755, 188);
            dataGridViewProductos.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 335);
            panel1.Name = "panel1";
            panel1.Size = new Size(755, 197);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 16);
            label1.Name = "label1";
            label1.Size = new Size(215, 20);
            label1.TabIndex = 0;
            label1.Text = "Agregar o modificar productos";
            // 
            // GestionPrecios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 566);
            Controls.Add(panel1);
            Controls.Add(dataGridViewProductos);
            Controls.Add(lblTitulo);
            Name = "GestionPrecios";
            Text = "Gestion de Precios";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dataGridViewProductos;
        private Panel panel1;
        private Label label1;
    }
}