namespace POS_Restaurante_Buffet
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            sideBarPanel = new Panel();
            btnGestionPrecios = new Button();
            Logo = new PictureBox();
            childPanel = new Panel();
            btnCaja = new Button();
            sideBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // sideBarPanel
            // 
            sideBarPanel.BackColor = Color.ForestGreen;
            sideBarPanel.Controls.Add(btnCaja);
            sideBarPanel.Controls.Add(btnGestionPrecios);
            sideBarPanel.Controls.Add(Logo);
            sideBarPanel.Dock = DockStyle.Left;
            sideBarPanel.Location = new Point(0, 0);
            sideBarPanel.Name = "sideBarPanel";
            sideBarPanel.Size = new Size(250, 450);
            sideBarPanel.TabIndex = 0;
            // 
            // btnGestionPrecios
            // 
            btnGestionPrecios.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGestionPrecios.Location = new Point(22, 165);
            btnGestionPrecios.Name = "btnGestionPrecios";
            btnGestionPrecios.Size = new Size(205, 35);
            btnGestionPrecios.TabIndex = 1;
            btnGestionPrecios.Text = "Gestión de Precios";
            btnGestionPrecios.UseVisualStyleBackColor = true;
            btnGestionPrecios.Click += btnGestionPrecios_Click;
            // 
            // Logo
            // 
            Logo.Dock = DockStyle.Top;
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(0, 0);
            Logo.Name = "Logo";
            Logo.Size = new Size(250, 96);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 1;
            Logo.TabStop = false;
            // 
            // childPanel
            // 
            childPanel.BackColor = SystemColors.ActiveBorder;
            childPanel.Dock = DockStyle.Fill;
            childPanel.Location = new Point(250, 0);
            childPanel.Name = "childPanel";
            childPanel.Size = new Size(550, 450);
            childPanel.TabIndex = 1;
            // 
            // btnCaja
            // 
            btnCaja.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCaja.Location = new Point(22, 112);
            btnCaja.Name = "btnCaja";
            btnCaja.Size = new Size(205, 35);
            btnCaja.TabIndex = 2;
            btnCaja.Text = "Caja";
            btnCaja.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(childPanel);
            Controls.Add(sideBarPanel);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "POS Restaurante";
            WindowState = FormWindowState.Maximized;
            sideBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sideBarPanel;
        private PictureBox Logo;
        private Button btnGestionPrecios;
        private Panel childPanel;
        private Button btnCaja;
    }
}