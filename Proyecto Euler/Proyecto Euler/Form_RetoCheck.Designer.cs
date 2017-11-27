namespace Proyecto_Euler
{
    partial class Form_RetoCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RetoCheck));
            this.cBVerdadero = new System.Windows.Forms.CheckBox();
            this.cBFalso = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.btRegresar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cBVerdadero
            // 
            this.cBVerdadero.AutoSize = true;
            this.cBVerdadero.BackColor = System.Drawing.Color.Transparent;
            this.cBVerdadero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBVerdadero.Location = new System.Drawing.Point(655, 128);
            this.cBVerdadero.Name = "cBVerdadero";
            this.cBVerdadero.Size = new System.Drawing.Size(119, 28);
            this.cBVerdadero.TabIndex = 0;
            this.cBVerdadero.Text = "Verdadero";
            this.cBVerdadero.UseVisualStyleBackColor = false;
            this.cBVerdadero.CheckedChanged += new System.EventHandler(this.cBVerdadero_CheckedChanged);
            // 
            // cBFalso
            // 
            this.cBFalso.AutoSize = true;
            this.cBFalso.BackColor = System.Drawing.Color.Transparent;
            this.cBFalso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBFalso.Location = new System.Drawing.Point(655, 182);
            this.cBFalso.Name = "cBFalso";
            this.cBFalso.Size = new System.Drawing.Size(75, 28);
            this.cBFalso.TabIndex = 1;
            this.cBFalso.Text = "Falso";
            this.cBFalso.UseVisualStyleBackColor = false;
            this.cBFalso.CheckedChanged += new System.EventHandler(this.cBFalso_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(569, 507);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(590, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "De acuerdo a lo que menciona el problema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(590, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "determina si el codigo es correcto ";
            // 
            // btSiguiente
            // 
            this.btSiguiente.Enabled = false;
            this.btSiguiente.Location = new System.Drawing.Point(594, 384);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(266, 58);
            this.btSiguiente.TabIndex = 5;
            this.btSiguiente.Text = "Siguiente";
            this.btSiguiente.UseVisualStyleBackColor = true;
            this.btSiguiente.Click += new System.EventHandler(this.btSiguiente_Click);
            // 
            // btRegresar
            // 
            this.btRegresar.Location = new System.Drawing.Point(594, 461);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(266, 58);
            this.btRegresar.TabIndex = 6;
            this.btRegresar.Text = "Regresar a Menu";
            this.btRegresar.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(594, 28);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(287, 23);
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(591, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Timer";
            // 
            // Form_RetoCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 531);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.btSiguiente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cBFalso);
            this.Controls.Add(this.cBVerdadero);
            this.Name = "Form_RetoCheck";
            this.Text = "Form_RetoCheck";
            this.Load += new System.EventHandler(this.Form_RetoCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cBVerdadero;
        private System.Windows.Forms.CheckBox cBFalso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSiguiente;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
    }
}