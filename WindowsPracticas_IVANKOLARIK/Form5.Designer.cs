namespace WindowsPracticas_IVANKOLARIK
{
    partial class Form5
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
            this.txtSexo1 = new System.Windows.Forms.TextBox();
            this.txtRol1 = new System.Windows.Forms.TextBox();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtRol = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSexo1
            // 
            this.txtSexo1.Location = new System.Drawing.Point(307, 222);
            this.txtSexo1.Name = "txtSexo1";
            this.txtSexo1.Size = new System.Drawing.Size(100, 23);
            this.txtSexo1.TabIndex = 0;
            // 
            // txtRol1
            // 
            this.txtRol1.Location = new System.Drawing.Point(307, 165);
            this.txtRol1.Name = "txtRol1";
            this.txtRol1.Size = new System.Drawing.Size(100, 23);
            this.txtRol1.TabIndex = 1;
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(307, 113);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(100, 23);
            this.txtNombre1.TabIndex = 2;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(307, 273);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(100, 23);
            this.btnValidar.TabIndex = 3;
            this.btnValidar.Text = "Validar Usuario";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(246, 113);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(51, 15);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.Text = "Nombre";
            // 
            // txtRol
            // 
            this.txtRol.AutoSize = true;
            this.txtRol.Location = new System.Drawing.Point(246, 168);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(24, 15);
            this.txtRol.TabIndex = 5;
            this.txtRol.Text = "Rol";
            // 
            // txtSexo
            // 
            this.txtSexo.AutoSize = true;
            this.txtSexo.Location = new System.Drawing.Point(246, 230);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(32, 15);
            this.txtSexo.TabIndex = 6;
            this.txtSexo.Text = "Sexo";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtNombre1);
            this.Controls.Add(this.txtRol1);
            this.Controls.Add(this.txtSexo1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSexo1;
        private TextBox txtRol1;
        private TextBox txtNombre1;
        private Button btnValidar;
        private Label txtNombre;
        private Label txtRol;
        private Label txtSexo;
    }
}