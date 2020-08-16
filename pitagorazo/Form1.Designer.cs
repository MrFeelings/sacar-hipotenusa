namespace pitagorazo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.num1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.calcular = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.TextBox();
            this.hipotenusa = new System.Windows.Forms.Label();
            this.reiniciar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(92, 75);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 20);
            this.num1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(92, 187);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(100, 23);
            this.calcular.TabIndex = 2;
            this.calcular.Text = "calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.Boton_calcular);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(473, 141);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(13, 13);
            this.a.TabIndex = 3;
            this.a.Text = "a";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(567, 216);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(13, 13);
            this.b.TabIndex = 4;
            this.b.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ingrese a:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ingrese b:";
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(92, 141);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 20);
            this.num2.TabIndex = 7;
            // 
            // hipotenusa
            // 
            this.hipotenusa.AutoSize = true;
            this.hipotenusa.Location = new System.Drawing.Point(598, 129);
            this.hipotenusa.Name = "hipotenusa";
            this.hipotenusa.Size = new System.Drawing.Size(59, 13);
            this.hipotenusa.TabIndex = 9;
            this.hipotenusa.Text = "hipotenusa";
            // 
            // reiniciar
            // 
            this.reiniciar.Location = new System.Drawing.Point(92, 216);
            this.reiniciar.Name = "reiniciar";
            this.reiniciar.Size = new System.Drawing.Size(100, 23);
            this.reiniciar.TabIndex = 10;
            this.reiniciar.Text = "reiniciar";
            this.reiniciar.UseVisualStyleBackColor = true;
            this.reiniciar.Click += new System.EventHandler(this.reiniciar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pitagorazo.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(467, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 198);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 274);
            this.Controls.Add(this.reiniciar);
            this.Controls.Add(this.hipotenusa);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "pitagorazo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label hipotenusa;
        private System.Windows.Forms.Button reiniciar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

