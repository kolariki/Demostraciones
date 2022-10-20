namespace WindowsPracticas_IVANKOLARIK
{
    partial class Form6
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
            this.btnObtenerDatos = new System.Windows.Forms.Button();
            this.txtNombre6 = new System.Windows.Forms.TextBox();
            this.txtApellido6 = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.dateTime1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnObtenerDatos
            // 
            this.btnObtenerDatos.Location = new System.Drawing.Point(334, 253);
            this.btnObtenerDatos.Name = "btnObtenerDatos";
            this.btnObtenerDatos.Size = new System.Drawing.Size(100, 23);
            this.btnObtenerDatos.TabIndex = 0;
            this.btnObtenerDatos.Text = "Obtener Datos";
            this.btnObtenerDatos.UseCompatibleTextRendering = true;
            this.btnObtenerDatos.UseVisualStyleBackColor = true;
            this.btnObtenerDatos.Click += new System.EventHandler(this.btnObtenerDatos_Click);
            // 
            // txtNombre6
            // 
            this.txtNombre6.Location = new System.Drawing.Point(334, 107);
            this.txtNombre6.Name = "txtNombre6";
            this.txtNombre6.Size = new System.Drawing.Size(100, 23);
            this.txtNombre6.TabIndex = 1;
            // 
            // txtApellido6
            // 
            this.txtApellido6.Location = new System.Drawing.Point(334, 158);
            this.txtApellido6.Name = "txtApellido6";
            this.txtApellido6.Size = new System.Drawing.Size(100, 23);
            this.txtApellido6.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(254, 110);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(254, 206);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(62, 15);
            this.lblFechaNac.TabIndex = 5;
            this.lblFechaNac.Text = "Fecha Nac";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(254, 161);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // dateTime1
            // 
            this.dateTime1.Location = new System.Drawing.Point(322, 206);
            this.dateTime1.Name = "dateTime1";
            this.dateTime1.Size = new System.Drawing.Size(200, 23);
            this.dateTime1.TabIndex = 7;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTime1);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtApellido6);
            this.Controls.Add(this.txtNombre6);
            this.Controls.Add(this.btnObtenerDatos);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnObtenerDatos;
        private TextBox txtNombre6;
        private TextBox txtApellido6;
        private Label lblNombre;
        private Label lblFechaNac;
        private Label lblApellido;
        private DateTimePicker dateTime1;
    }
}