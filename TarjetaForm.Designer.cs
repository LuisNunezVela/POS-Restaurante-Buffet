namespace POS_Restaurante_Buffet
{
    partial class TarjetaForm
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblCodigoProducto = new Label();
            lblPrecioProducto = new Label();
            btnAgregarProducto = new Button();
            comboBoxProductos = new ComboBox();
            txtCantidad = new TextBox();
            btnActualizar = new Button();
            lblTarjeta = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(766, 223);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 275);
            label1.Name = "label1";
            label1.Size = new Size(191, 20);
            label1.TabIndex = 1;
            label1.Text = "agregar productos a tarjeta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 330);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(195, 330);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 3;
            label3.Text = "cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(335, 330);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 4;
            label4.Text = "id producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(508, 330);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 5;
            label5.Text = "precio unitario";
            // 
            // lblCodigoProducto
            // 
            lblCodigoProducto.AutoSize = true;
            lblCodigoProducto.Location = new Point(463, 330);
            lblCodigoProducto.Name = "lblCodigoProducto";
            lblCodigoProducto.Size = new Size(17, 20);
            lblCodigoProducto.TabIndex = 6;
            lblCodigoProducto.Text = "0";
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.AutoSize = true;
            lblPrecioProducto.Location = new Point(646, 330);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new Size(17, 20);
            lblPrecioProducto.TabIndex = 7;
            lblPrecioProducto.Text = "0";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(295, 397);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(94, 29);
            btnAgregarProducto.TabIndex = 8;
            btnAgregarProducto.Text = "agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // comboBoxProductos
            // 
            comboBoxProductos.FormattingEnabled = true;
            comboBoxProductos.Location = new Point(82, 330);
            comboBoxProductos.Name = "comboBoxProductos";
            comboBoxProductos.Size = new Size(107, 28);
            comboBoxProductos.TabIndex = 9;
            comboBoxProductos.SelectedIndexChanged += comboBoxProductos_SelectedIndexChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(266, 323);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(63, 27);
            txtCantidad.TabIndex = 10;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(667, 14);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // lblTarjeta
            // 
            lblTarjeta.AutoSize = true;
            lblTarjeta.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTarjeta.Location = new Point(25, 12);
            lblTarjeta.Name = "lblTarjeta";
            lblTarjeta.Size = new Size(75, 34);
            lblTarjeta.TabIndex = 12;
            lblTarjeta.Text = "0000";
            // 
            // TarjetaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTarjeta);
            Controls.Add(btnActualizar);
            Controls.Add(txtCantidad);
            Controls.Add(comboBoxProductos);
            Controls.Add(btnAgregarProducto);
            Controls.Add(lblPrecioProducto);
            Controls.Add(lblCodigoProducto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "TarjetaForm";
            Text = "TarjetaForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblCodigoProducto;
        private Label lblPrecioProducto;
        private Button btnAgregarProducto;
        private ComboBox comboBoxProductos;
        private TextBox txtCantidad;
        private Button btnActualizar;
        private Label lblTarjeta;
    }
}