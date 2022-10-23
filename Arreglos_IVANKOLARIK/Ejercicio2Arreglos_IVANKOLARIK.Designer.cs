namespace Arreglos_IVANKOLARIK
{
    partial class Ejercicio2Arreglos_IVANKOLARIK
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
            this.bntPrecios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntPrecios
            // 
            this.bntPrecios.Location = new System.Drawing.Point(367, 244);
            this.bntPrecios.Name = "bntPrecios";
            this.bntPrecios.Size = new System.Drawing.Size(75, 23);
            this.bntPrecios.TabIndex = 0;
            this.bntPrecios.Text = "Precios";
            this.bntPrecios.UseVisualStyleBackColor = true;
            this.bntPrecios.Click += new System.EventHandler(this.bntPrecios_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntPrecios);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntPrecios;
    }
}