namespace Proyecto_Euler
{
    partial class Continuar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Continuar));
            this.label2 = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.btIniciarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(409, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contraseña";
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.BackColor = System.Drawing.Color.Transparent;
            this.Usuario.Location = new System.Drawing.Point(409, 260);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(57, 17);
            this.Usuario.TabIndex = 9;
            this.Usuario.Text = "Usuario";
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(409, 336);
            this.tbContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.PasswordChar = '■';
            this.tbContraseña.Size = new System.Drawing.Size(311, 22);
            this.tbContraseña.TabIndex = 8;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(409, 279);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(311, 22);
            this.tbUsuario.TabIndex = 7;
            // 
            // btIniciarSesion
            // 
            this.btIniciarSesion.Location = new System.Drawing.Point(500, 585);
            this.btIniciarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btIniciarSesion.Name = "btIniciarSesion";
            this.btIniciarSesion.Size = new System.Drawing.Size(179, 57);
            this.btIniciarSesion.TabIndex = 6;
            this.btIniciarSesion.Text = "Iniciar Sesion ";
            this.btIniciarSesion.UseVisualStyleBackColor = true;
            this.btIniciarSesion.Click += new System.EventHandler(this.btIniciarSesion_Click);
            // 
            // Continuar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.btIniciarSesion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Continuar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto Euler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Continuar_FormClosing);
            this.Load += new System.EventHandler(this.Continuar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Button btIniciarSesion;
    }
}