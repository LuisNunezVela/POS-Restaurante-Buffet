namespace POS_Restaurante_Buffet
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel2 = new Panel();
            Logo = new PictureBox();
            lblUsuario = new Label();
            comboBoxUsuario = new ComboBox();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            btnLogin = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.ForestGreen;
            panel2.Controls.Add(Logo);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 450);
            panel2.TabIndex = 1;
            // 
            // Logo
            // 
            Logo.Dock = DockStyle.Top;
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(0, 0);
            Logo.Name = "Logo";
            Logo.Size = new Size(250, 96);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 7;
            Logo.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Tahoma", 12F);
            lblUsuario.Location = new Point(314, 103);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(77, 24);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            // 
            // comboBoxUsuario
            // 
            comboBoxUsuario.Font = new Font("Tahoma", 12F);
            comboBoxUsuario.FormattingEnabled = true;
            comboBoxUsuario.Location = new Point(314, 147);
            comboBoxUsuario.Name = "comboBoxUsuario";
            comboBoxUsuario.Size = new Size(151, 32);
            comboBoxUsuario.TabIndex = 3;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Tahoma", 12F);
            lblContrasena.Location = new Point(314, 198);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(111, 24);
            lblContrasena.TabIndex = 4;
            lblContrasena.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Tahoma", 12F);
            txtContrasena.Location = new Point(314, 237);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(151, 32);
            txtContrasena.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Tahoma", 12F);
            btnLogin.Location = new Point(441, 312);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 40);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtContrasena);
            Controls.Add(lblContrasena);
            Controls.Add(comboBoxUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(panel2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "POS Restaurante - Login";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label lblUsuario;
        private ComboBox comboBoxUsuario;
        private Label lblContrasena;
        private TextBox txtContrasena;
        private Button btnLogin;
        private PictureBox Logo;
    }
}
