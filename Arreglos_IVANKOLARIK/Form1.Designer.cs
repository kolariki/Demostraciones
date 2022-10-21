namespace Arreglos_IVANKOLARIK
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
            this.btnPedirNotas = new System.Windows.Forms.Button();
            this.txtAlumno1 = new System.Windows.Forms.TextBox();
            this.txtAlumno3 = new System.Windows.Forms.TextBox();
            this.txtAlumno2 = new System.Windows.Forms.TextBox();
            this.txtAlumno4 = new System.Windows.Forms.TextBox();
            this.btnPromedioNotas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPedirNotas
            // 
            this.btnPedirNotas.Location = new System.Drawing.Point(245, 281);
            this.btnPedirNotas.Name = "btnPedirNotas";
            this.btnPedirNotas.Size = new System.Drawing.Size(210, 23);
            this.btnPedirNotas.TabIndex = 0;
            this.btnPedirNotas.Text = "Promedio y Nota Mayor";
            this.btnPedirNotas.UseVisualStyleBackColor = true;
            this.btnPedirNotas.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // txtAlumno1
            // 
            this.txtAlumno1.Location = new System.Drawing.Point(36, 190);
            this.txtAlumno1.Name = "txtAlumno1";
            this.txtAlumno1.Size = new System.Drawing.Size(100, 20);
            this.txtAlumno1.TabIndex = 1;
            // 
            // txtAlumno3
            // 
            this.txtAlumno3.Location = new System.Drawing.Point(323, 190);
            this.txtAlumno3.Name = "txtAlumno3";
            this.txtAlumno3.Size = new System.Drawing.Size(100, 20);
            this.txtAlumno3.TabIndex = 2;
            // 
            // txtAlumno2
            // 
            this.txtAlumno2.Location = new System.Drawing.Point(172, 190);
            this.txtAlumno2.Name = "txtAlumno2";
            this.txtAlumno2.Size = new System.Drawing.Size(100, 20);
            this.txtAlumno2.TabIndex = 3;
            // 
            // txtAlumno4
            // 
            this.txtAlumno4.Location = new System.Drawing.Point(482, 190);
            this.txtAlumno4.Name = "txtAlumno4";
            this.txtAlumno4.Size = new System.Drawing.Size(100, 20);
            this.txtAlumno4.TabIndex = 4;
            // 
            // btnPromedioNotas
            // 
            this.btnPromedioNotas.Location = new System.Drawing.Point(245, 339);
            this.btnPromedioNotas.Name = "btnPromedioNotas";
            this.btnPromedioNotas.Size = new System.Drawing.Size(210, 23);
            this.btnPromedioNotas.TabIndex = 5;
            this.btnPromedioNotas.Text = "Promedio";
            this.btnPromedioNotas.UseVisualStyleBackColor = true;
        
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPromedioNotas);
            this.Controls.Add(this.txtAlumno4);
            this.Controls.Add(this.txtAlumno2);
            this.Controls.Add(this.txtAlumno3);
            this.Controls.Add(this.txtAlumno1);
            this.Controls.Add(this.btnPedirNotas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPedirNotas;
        private System.Windows.Forms.TextBox txtAlumno1;
        private System.Windows.Forms.TextBox txtAlumno3;
        private System.Windows.Forms.TextBox txtAlumno2;
        private System.Windows.Forms.TextBox txtAlumno4;
        private System.Windows.Forms.Button btnPromedioNotas;
    }
}

