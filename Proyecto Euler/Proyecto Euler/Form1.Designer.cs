﻿namespace Proyecto_Euler
{
    partial class Form1
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
            this.btIniciar = new System.Windows.Forms.Button();
            this.btContinuar = new System.Windows.Forms.Button();
            this.btAyuda = new System.Windows.Forms.Button();
            this.btRecords = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(23, 68);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(174, 40);
            this.btIniciar.TabIndex = 0;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.UseVisualStyleBackColor = true;
            // 
            // btContinuar
            // 
            this.btContinuar.Location = new System.Drawing.Point(23, 126);
            this.btContinuar.Name = "btContinuar";
            this.btContinuar.Size = new System.Drawing.Size(174, 40);
            this.btContinuar.TabIndex = 1;
            this.btContinuar.Text = "Continuar";
            this.btContinuar.UseVisualStyleBackColor = true;
            // 
            // btAyuda
            // 
            this.btAyuda.Location = new System.Drawing.Point(23, 184);
            this.btAyuda.Name = "btAyuda";
            this.btAyuda.Size = new System.Drawing.Size(174, 40);
            this.btAyuda.TabIndex = 2;
            this.btAyuda.Text = "Ayuda";
            this.btAyuda.UseVisualStyleBackColor = true;
            // 
            // btRecords
            // 
            this.btRecords.Location = new System.Drawing.Point(23, 246);
            this.btRecords.Name = "btRecords";
            this.btRecords.Size = new System.Drawing.Size(174, 40);
            this.btRecords.TabIndex = 3;
            this.btRecords.Text = "Records";
            this.btRecords.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(216, 334);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(82, 28);
            this.btSalir.TabIndex = 4;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(525, 385);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btRecords);
            this.Controls.Add(this.btAyuda);
            this.Controls.Add(this.btContinuar);
            this.Controls.Add(this.btIniciar);
            this.Name = "Form1";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Button btContinuar;
        private System.Windows.Forms.Button btAyuda;
        private System.Windows.Forms.Button btRecords;
        private System.Windows.Forms.Button btSalir;
    }
}
