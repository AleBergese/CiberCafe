namespace VistaCiber1
{
    partial class AltaEmpleado
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
            this.txtIdEmpleado = new System.Windows.Forms.Label();
            this.txtDniEmpleado = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.Label();
            this.txtApellidoEmpleado = new System.Windows.Forms.Label();
            this.txtTelefonoEmpleado = new System.Windows.Forms.Label();
            this.txtDireccionEmpleado = new System.Windows.Forms.Label();
            this.boxIdEmpleado = new System.Windows.Forms.TextBox();
            this.boxDniEmpleado = new System.Windows.Forms.TextBox();
            this.boxNombreEmpleado = new System.Windows.Forms.TextBox();
            this.boxApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.boxTelefonoEmpleado = new System.Windows.Forms.TextBox();
            this.boxDireccionEmpleado = new System.Windows.Forms.TextBox();
            this.btnAlta1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.AutoSize = true;
            this.txtIdEmpleado.Location = new System.Drawing.Point(68, 60);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(68, 13);
            this.txtIdEmpleado.TabIndex = 0;
            this.txtIdEmpleado.Text = "ID Empelado";
            this.txtIdEmpleado.Click += new System.EventHandler(this.txtIdEmpleado_Click);
            // 
            // txtDniEmpleado
            // 
            this.txtDniEmpleado.AutoSize = true;
            this.txtDniEmpleado.Location = new System.Drawing.Point(68, 96);
            this.txtDniEmpleado.Name = "txtDniEmpleado";
            this.txtDniEmpleado.Size = new System.Drawing.Size(26, 13);
            this.txtDniEmpleado.TabIndex = 1;
            this.txtDniEmpleado.Text = "DNI";
            this.txtDniEmpleado.Click += new System.EventHandler(this.txtDniEmpleado_Click);
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.AutoSize = true;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(68, 120);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(44, 13);
            this.txtNombreEmpleado.TabIndex = 2;
            this.txtNombreEmpleado.Text = "Nombre";
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.AutoSize = true;
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(68, 147);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(44, 13);
            this.txtApellidoEmpleado.TabIndex = 3;
            this.txtApellidoEmpleado.Text = "Apellido";
            // 
            // txtTelefonoEmpleado
            // 
            this.txtTelefonoEmpleado.AutoSize = true;
            this.txtTelefonoEmpleado.Location = new System.Drawing.Point(68, 178);
            this.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            this.txtTelefonoEmpleado.Size = new System.Drawing.Size(49, 13);
            this.txtTelefonoEmpleado.TabIndex = 4;
            this.txtTelefonoEmpleado.Text = "Telefono";
            // 
            // txtDireccionEmpleado
            // 
            this.txtDireccionEmpleado.AutoSize = true;
            this.txtDireccionEmpleado.Location = new System.Drawing.Point(68, 205);
            this.txtDireccionEmpleado.Name = "txtDireccionEmpleado";
            this.txtDireccionEmpleado.Size = new System.Drawing.Size(52, 13);
            this.txtDireccionEmpleado.TabIndex = 5;
            this.txtDireccionEmpleado.Text = "Direccion";
            // 
            // boxIdEmpleado
            // 
            this.boxIdEmpleado.Location = new System.Drawing.Point(143, 60);
            this.boxIdEmpleado.Name = "boxIdEmpleado";
            this.boxIdEmpleado.Size = new System.Drawing.Size(100, 20);
            this.boxIdEmpleado.TabIndex = 6;
            this.boxIdEmpleado.TextChanged += new System.EventHandler(this.boxIdEmpleado_TextChanged);
            // 
            // boxDniEmpleado
            // 
            this.boxDniEmpleado.Location = new System.Drawing.Point(143, 89);
            this.boxDniEmpleado.Name = "boxDniEmpleado";
            this.boxDniEmpleado.Size = new System.Drawing.Size(100, 20);
            this.boxDniEmpleado.TabIndex = 7;
            this.boxDniEmpleado.TextChanged += new System.EventHandler(this.boxDniEmpleado_TextChanged);
            // 
            // boxNombreEmpleado
            // 
            this.boxNombreEmpleado.Location = new System.Drawing.Point(143, 120);
            this.boxNombreEmpleado.Name = "boxNombreEmpleado";
            this.boxNombreEmpleado.Size = new System.Drawing.Size(100, 20);
            this.boxNombreEmpleado.TabIndex = 8;
            this.boxNombreEmpleado.TextChanged += new System.EventHandler(this.boxNombreEmpleado_TextChanged);
            // 
            // boxApellidoEmpleado
            // 
            this.boxApellidoEmpleado.Location = new System.Drawing.Point(143, 147);
            this.boxApellidoEmpleado.Name = "boxApellidoEmpleado";
            this.boxApellidoEmpleado.Size = new System.Drawing.Size(100, 20);
            this.boxApellidoEmpleado.TabIndex = 9;
            this.boxApellidoEmpleado.TextChanged += new System.EventHandler(this.boxApellidoEmpleado_TextChanged);
            // 
            // boxTelefonoEmpleado
            // 
            this.boxTelefonoEmpleado.Location = new System.Drawing.Point(143, 178);
            this.boxTelefonoEmpleado.Name = "boxTelefonoEmpleado";
            this.boxTelefonoEmpleado.Size = new System.Drawing.Size(100, 20);
            this.boxTelefonoEmpleado.TabIndex = 10;
            this.boxTelefonoEmpleado.TextChanged += new System.EventHandler(this.boxTelefonoEmpleado_TextChanged);
            // 
            // boxDireccionEmpleado
            // 
            this.boxDireccionEmpleado.Location = new System.Drawing.Point(143, 205);
            this.boxDireccionEmpleado.Name = "boxDireccionEmpleado";
            this.boxDireccionEmpleado.Size = new System.Drawing.Size(100, 20);
            this.boxDireccionEmpleado.TabIndex = 11;
            this.boxDireccionEmpleado.TextChanged += new System.EventHandler(this.boxDireccionEmpleado_TextChanged);
            // 
            // btnAlta1
            // 
            this.btnAlta1.Location = new System.Drawing.Point(71, 281);
            this.btnAlta1.Name = "btnAlta1";
            this.btnAlta1.Size = new System.Drawing.Size(75, 23);
            this.btnAlta1.TabIndex = 12;
            this.btnAlta1.Text = "Alta";
            this.btnAlta1.UseVisualStyleBackColor = true;
            this.btnAlta1.Click += new System.EventHandler(this.btnAlta1_Click);
            // 
            // AltaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlta1);
            this.Controls.Add(this.boxDireccionEmpleado);
            this.Controls.Add(this.boxTelefonoEmpleado);
            this.Controls.Add(this.boxApellidoEmpleado);
            this.Controls.Add(this.boxNombreEmpleado);
            this.Controls.Add(this.boxDniEmpleado);
            this.Controls.Add(this.boxIdEmpleado);
            this.Controls.Add(this.txtDireccionEmpleado);
            this.Controls.Add(this.txtTelefonoEmpleado);
            this.Controls.Add(this.txtApellidoEmpleado);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.txtDniEmpleado);
            this.Controls.Add(this.txtIdEmpleado);
            this.Name = "AltaEmpleado";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AltaEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtIdEmpleado;
        private System.Windows.Forms.Label txtDniEmpleado;
        private System.Windows.Forms.Label txtNombreEmpleado;
        private System.Windows.Forms.Label txtApellidoEmpleado;
        private System.Windows.Forms.Label txtTelefonoEmpleado;
        private System.Windows.Forms.Label txtDireccionEmpleado;
        private System.Windows.Forms.TextBox boxIdEmpleado;
        private System.Windows.Forms.TextBox boxDniEmpleado;
        private System.Windows.Forms.TextBox boxNombreEmpleado;
        private System.Windows.Forms.TextBox boxApellidoEmpleado;
        private System.Windows.Forms.TextBox boxTelefonoEmpleado;
        private System.Windows.Forms.TextBox boxDireccionEmpleado;
        private System.Windows.Forms.Button btnAlta1;
    }
}