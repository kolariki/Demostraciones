namespace WindowsPracticas_IVANKOLARIK
{
    partial class Form4
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
            this.btnAreaRectangulo = new System.Windows.Forms.Button();
            this.btnTrapecio = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.txtBase1 = new System.Windows.Forms.TextBox();
            this.txtAlturaTrapecio = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.txtBase2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAreaRectangulo
            // 
            this.btnAreaRectangulo.Location = new System.Drawing.Point(43, 306);
            this.btnAreaRectangulo.Name = "btnAreaRectangulo";
            this.btnAreaRectangulo.Size = new System.Drawing.Size(135, 23);
            this.btnAreaRectangulo.TabIndex = 0;
            this.btnAreaRectangulo.Text = "Area Rectangulo";
            this.btnAreaRectangulo.UseVisualStyleBackColor = true;
            this.btnAreaRectangulo.Click += new System.EventHandler(this.btnAreaRectangulo_Click);
            // 
            // btnTrapecio
            // 
            this.btnTrapecio.Location = new System.Drawing.Point(615, 306);
            this.btnTrapecio.Name = "btnTrapecio";
            this.btnTrapecio.Size = new System.Drawing.Size(103, 23);
            this.btnTrapecio.TabIndex = 1;
            this.btnTrapecio.Text = "Area Trapecio";
            this.btnTrapecio.UseVisualStyleBackColor = true;
            this.btnTrapecio.Click += new System.EventHandler(this.btnTrapecio_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.Location = new System.Drawing.Point(348, 306);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(102, 23);
            this.btnCirculo.TabIndex = 2;
            this.btnCirculo.Text = "Area Circulo";
            this.btnCirculo.UseVisualStyleBackColor = true;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // txtBase1
            // 
            this.txtBase1.Location = new System.Drawing.Point(615, 135);
            this.txtBase1.Name = "txtBase1";
            this.txtBase1.Size = new System.Drawing.Size(100, 23);
            this.txtBase1.TabIndex = 3;
            // 
            // txtAlturaTrapecio
            // 
            this.txtAlturaTrapecio.Location = new System.Drawing.Point(615, 262);
            this.txtAlturaTrapecio.Name = "txtAlturaTrapecio";
            this.txtAlturaTrapecio.Size = new System.Drawing.Size(100, 23);
            this.txtAlturaTrapecio.TabIndex = 4;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(43, 245);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 23);
            this.txtAltura.TabIndex = 5;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(43, 135);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 23);
            this.txtBase.TabIndex = 6;
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(350, 184);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 23);
            this.txtRadio.TabIndex = 8;
            // 
            // txtBase2
            // 
            this.txtBase2.Location = new System.Drawing.Point(615, 205);
            this.txtBase2.Name = "txtBase2";
            this.txtBase2.Size = new System.Drawing.Size(100, 23);
            this.txtBase2.TabIndex = 9;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBase2);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtAlturaTrapecio);
            this.Controls.Add(this.txtBase1);
            this.Controls.Add(this.btnCirculo);
            this.Controls.Add(this.btnTrapecio);
            this.Controls.Add(this.btnAreaRectangulo);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAreaRectangulo;
        private Button btnTrapecio;
        private Button btnCirculo;
        private TextBox txtBase1;
        private TextBox txtAlturaTrapecio;
        private TextBox txtAltura;
        private TextBox txtBase;
        private TextBox txtRadio;
        private TextBox txtBase2;
    }
}