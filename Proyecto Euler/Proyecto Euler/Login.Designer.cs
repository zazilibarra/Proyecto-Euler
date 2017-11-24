namespace Proyecto_Euler
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btIniciarSesion = new System.Windows.Forms.Button();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btIniciarSesion
            // 
            this.btIniciarSesion.Location = new System.Drawing.Point(402, 474);
            this.btIniciarSesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btIniciarSesion.Name = "btIniciarSesion";
            this.btIniciarSesion.Size = new System.Drawing.Size(134, 46);
            this.btIniciarSesion.TabIndex = 0;
            this.btIniciarSesion.Text = "Iniciar Sesion ";
            this.btIniciarSesion.UseVisualStyleBackColor = true;
            this.btIniciarSesion.Click += new System.EventHandler(this.btIniciarSesion_Click);
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(382, 219);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(234, 20);
            this.tbUsuario.TabIndex = 2;
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(382, 266);
            this.tbContraseña.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(234, 20);
            this.tbContraseña.TabIndex = 3;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(304, 226);
            this.Usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(43, 13);
            this.Usuario.TabIndex = 4;
            this.Usuario.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 273);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 531);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.btIniciarSesion);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btIniciarSesion;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label label2;
    }
}