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
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            txtPrecio = new TextBox();
            txtProducto = new TextBox();
            txtCodigo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
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
            lblTitulo.Size = new Size(173, 24);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Lista de productos";
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.AllowUserToAddRows = false;
            dataGridViewProductos.AllowUserToDeleteRows = false;
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(12, 58);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.ReadOnly = true;
            dataGridViewProductos.RowHeadersWidth = 51;
            dataGridViewProductos.Size = new Size(755, 188);
            dataGridViewProductos.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(txtProducto);
            panel1.Controls.Add(txtCodigo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 274);
            panel1.Name = "panel1";
            panel1.Size = new Size(755, 197);
            panel1.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Tahoma", 12F);
            btnEliminar.Location = new Point(510, 144);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 41);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Tahoma", 12F);
            btnModificar.Location = new Point(510, 90);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(110, 41);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Tahoma", 12F);
            btnAgregar.Location = new Point(510, 34);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(110, 41);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Tahoma", 12F);
            txtPrecio.Location = new Point(210, 141);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 32);
            txtPrecio.TabIndex = 6;
            // 
            // txtProducto
            // 
            txtProducto.Font = new Font("Tahoma", 12F);
            txtProducto.Location = new Point(210, 99);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(125, 32);
            txtProducto.TabIndex = 5;
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Tahoma", 12F);
            txtCodigo.Location = new Point(210, 58);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 32);
            txtCodigo.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F);
            label4.Location = new Point(81, 144);
            label4.Name = "label4";
            label4.Size = new Size(64, 24);
            label4.TabIndex = 3;
            label4.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.Location = new Point(73, 99);
            label3.Name = "label3";
            label3.Size = new Size(88, 24);
            label3.TabIndex = 2;
            label3.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.Location = new Point(73, 63);
            label2.Name = "label2";
            label2.Size = new Size(71, 24);
            label2.TabIndex = 1;
            label2.Text = "Código";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(269, 14);
            label1.Name = "label1";
            label1.Size = new Size(155, 24);
            label1.TabIndex = 0;
            label1.Text = "Editar productos";
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
        private TextBox txtPrecio;
        private TextBox txtProducto;
        private TextBox txtCodigo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnEliminar;
        private Button btnAgregar;
        private Button btnModificar;
    }
}