namespace POS_Restaurante_Buffet
{
    partial class CajaForm
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
            label1 = new Label();
            flowLayoutPanelTarjetas = new FlowLayoutPanel();
            label2 = new Label();
            txtNumTarjeta = new TextBox();
            btnEditar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(308, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 24);
            label1.TabIndex = 0;
            label1.Text = "Caja";
            // 
            // flowLayoutPanelTarjetas
            // 
            flowLayoutPanelTarjetas.BackColor = SystemColors.ButtonShadow;
            flowLayoutPanelTarjetas.Dock = DockStyle.Bottom;
            flowLayoutPanelTarjetas.Location = new Point(0, 193);
            flowLayoutPanelTarjetas.Name = "flowLayoutPanelTarjetas";
            flowLayoutPanelTarjetas.Size = new Size(800, 257);
            flowLayoutPanelTarjetas.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 113);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 2;
            label2.Text = "Buscar Tarjeta";
            // 
            // txtNumTarjeta
            // 
            txtNumTarjeta.Location = new Point(221, 102);
            txtNumTarjeta.Name = "txtNumTarjeta";
            txtNumTarjeta.Size = new Size(125, 27);
            txtNumTarjeta.TabIndex = 3;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(395, 102);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // CajaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditar);
            Controls.Add(txtNumTarjeta);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanelTarjetas);
            Controls.Add(label1);
            Name = "CajaForm";
            Text = "CajaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanelTarjetas;
        private Label label2;
        private TextBox txtNumTarjeta;
        private Button btnEditar;
    }
}