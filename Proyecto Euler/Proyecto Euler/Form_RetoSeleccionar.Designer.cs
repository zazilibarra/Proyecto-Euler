﻿namespace Proyecto_Euler
{
    partial class Form_RetoSeleccionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RetoSeleccionar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.btRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbTimeMedio = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(759, 624);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.White;
            this.bt1.Location = new System.Drawing.Point(928, 149);
            this.bt1.Margin = new System.Windows.Forms.Padding(4);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(100, 28);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "-";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.Color.White;
            this.bt3.Location = new System.Drawing.Point(928, 220);
            this.bt3.Margin = new System.Windows.Forms.Padding(4);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(100, 28);
            this.bt3.TabIndex = 2;
            this.bt3.Text = "-";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.Color.White;
            this.bt2.Location = new System.Drawing.Point(928, 185);
            this.bt2.Margin = new System.Windows.Forms.Padding(4);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(100, 28);
            this.bt2.TabIndex = 3;
            this.bt2.Text = "-";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // btSiguiente
            // 
            this.btSiguiente.Location = new System.Drawing.Point(783, 444);
            this.btSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(383, 89);
            this.btSiguiente.TabIndex = 4;
            this.btSiguiente.Text = "Siguiente";
            this.btSiguiente.UseVisualStyleBackColor = true;
            this.btSiguiente.Click += new System.EventHandler(this.btSiguiente_Click);
            // 
            // btRegresar
            // 
            this.btRegresar.Location = new System.Drawing.Point(783, 554);
            this.btRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(383, 85);
            this.btRegresar.TabIndex = 5;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(783, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Elige la respuesta correcta";
            // 
            // pbTimeMedio
            // 
            this.pbTimeMedio.Location = new System.Drawing.Point(787, 55);
            this.pbTimeMedio.Margin = new System.Windows.Forms.Padding(4);
            this.pbTimeMedio.Name = "pbTimeMedio";
            this.pbTimeMedio.Size = new System.Drawing.Size(387, 28);
            this.pbTimeMedio.TabIndex = 7;
            this.pbTimeMedio.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(783, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Timer";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(1060, 15);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 25);
            this.lblUsuario.TabIndex = 14;
            // 
            // Form_RetoSeleccionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1181, 654);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbTimeMedio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.btSiguiente);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form_RetoSeleccionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto Euler";
            this.Activated += new System.EventHandler(this.Form_RetoSeleccionar_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_RetoSeleccionar_FormClosing);
            this.Load += new System.EventHandler(this.Form_RetoSeleccionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button btSiguiente;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbTimeMedio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsuario;
    }
}