namespace WindowsApp
{
    partial class Form3
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
            this.btnImplicito = new System.Windows.Forms.Button();
            this.btnExplicito = new System.Windows.Forms.Button();
            this.btnConversion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImplicito
            // 
            this.btnImplicito.ForeColor = System.Drawing.Color.Brown;
            this.btnImplicito.Location = new System.Drawing.Point(336, 169);
            this.btnImplicito.Name = "btnImplicito";
            this.btnImplicito.Size = new System.Drawing.Size(75, 23);
            this.btnImplicito.TabIndex = 0;
            this.btnImplicito.Text = "Implicito";
            this.btnImplicito.UseVisualStyleBackColor = true;
            this.btnImplicito.Click += new System.EventHandler(this.btnImplicito_Click);
            // 
            // btnExplicito
            // 
            this.btnExplicito.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnExplicito.Location = new System.Drawing.Point(336, 214);
            this.btnExplicito.Name = "btnExplicito";
            this.btnExplicito.Size = new System.Drawing.Size(75, 23);
            this.btnExplicito.TabIndex = 1;
            this.btnExplicito.Text = "Explicito";
            this.btnExplicito.UseVisualStyleBackColor = true;
            this.btnExplicito.Click += new System.EventHandler(this.btnExplicito_Click);
            // 
            // btnConversion
            // 
            this.btnConversion.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnConversion.Location = new System.Drawing.Point(336, 269);
            this.btnConversion.Name = "btnConversion";
            this.btnConversion.Size = new System.Drawing.Size(75, 23);
            this.btnConversion.TabIndex = 2;
            this.btnConversion.Text = "Conversion";
            this.btnConversion.UseVisualStyleBackColor = true;
            this.btnConversion.Click += new System.EventHandler(this.btnConversion_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConversion);
            this.Controls.Add(this.btnExplicito);
            this.Controls.Add(this.btnImplicito);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImplicito;
        private System.Windows.Forms.Button btnExplicito;
        private System.Windows.Forms.Button btnConversion;
    }
}