namespace Ivan_Kolarik_Casting
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
            this.btnImplicito = new System.Windows.Forms.Button();
            this.btnConversion = new System.Windows.Forms.Button();
            this.btnExplicito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImplicito
            // 
            this.btnImplicito.Location = new System.Drawing.Point(353, 120);
            this.btnImplicito.Name = "btnImplicito";
            this.btnImplicito.Size = new System.Drawing.Size(75, 23);
            this.btnImplicito.TabIndex = 0;
            this.btnImplicito.Text = "Implicito";
            this.btnImplicito.UseVisualStyleBackColor = true;
            this.btnImplicito.Click += new System.EventHandler(this.btnImplicito_Click);
            // 
            // btnConversion
            // 
            this.btnConversion.Location = new System.Drawing.Point(353, 201);
            this.btnConversion.Name = "btnConversion";
            this.btnConversion.Size = new System.Drawing.Size(75, 23);
            this.btnConversion.TabIndex = 1;
            this.btnConversion.Text = "Conversion";
            this.btnConversion.UseVisualStyleBackColor = true;
            this.btnConversion.Click += new System.EventHandler(this.btnConversion_Click);
            // 
            // btnExplicito
            // 
            this.btnExplicito.Location = new System.Drawing.Point(353, 163);
            this.btnExplicito.Name = "btnExplicito";
            this.btnExplicito.Size = new System.Drawing.Size(75, 23);
            this.btnExplicito.TabIndex = 2;
            this.btnExplicito.Text = "Explicito";
            this.btnExplicito.UseVisualStyleBackColor = true;
            this.btnExplicito.Click += new System.EventHandler(this.btnExplicito_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExplicito);
            this.Controls.Add(this.btnConversion);
            this.Controls.Add(this.btnImplicito);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImplicito;
        private System.Windows.Forms.Button btnConversion;
        private System.Windows.Forms.Button btnExplicito;
    }
}

