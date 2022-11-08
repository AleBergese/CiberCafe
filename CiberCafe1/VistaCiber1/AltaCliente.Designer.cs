namespace VistaCiber1
{
    partial class AltaCliente
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
            this.btnAltaCLi1 = new System.Windows.Forms.Button();
            this.boxDireccionCliente = new System.Windows.Forms.TextBox();
            this.boxTelefonoCliente = new System.Windows.Forms.TextBox();
            this.boxApellidoCliente = new System.Windows.Forms.TextBox();
            this.boxNombreCliente = new System.Windows.Forms.TextBox();
            this.boxDniCliente = new System.Windows.Forms.TextBox();
            this.boxIdCliente = new System.Windows.Forms.TextBox();
            this.txtDireccionCliente = new System.Windows.Forms.Label();
            this.txtTelefonoCliente = new System.Windows.Forms.Label();
            this.txtApellidoCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.Label();
            this.txtDniCliente = new System.Windows.Forms.Label();
            this.txtIdCLiente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAltaCLi1
            // 
            this.btnAltaCLi1.Location = new System.Drawing.Point(57, 267);
            this.btnAltaCLi1.Name = "btnAltaCLi1";
            this.btnAltaCLi1.Size = new System.Drawing.Size(75, 23);
            this.btnAltaCLi1.TabIndex = 25;
            this.btnAltaCLi1.Text = "Alta";
            this.btnAltaCLi1.UseVisualStyleBackColor = true;
            this.btnAltaCLi1.Click += new System.EventHandler(this.btnAltaCLi1_Click);
            // 
            // boxDireccionCliente
            // 
            this.boxDireccionCliente.Location = new System.Drawing.Point(129, 191);
            this.boxDireccionCliente.Name = "boxDireccionCliente";
            this.boxDireccionCliente.Size = new System.Drawing.Size(100, 20);
            this.boxDireccionCliente.TabIndex = 24;
            // 
            // boxTelefonoCliente
            // 
            this.boxTelefonoCliente.Location = new System.Drawing.Point(129, 164);
            this.boxTelefonoCliente.Name = "boxTelefonoCliente";
            this.boxTelefonoCliente.Size = new System.Drawing.Size(100, 20);
            this.boxTelefonoCliente.TabIndex = 23;
            this.boxTelefonoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxTelefonoCliente_KeyPress);
            // 
            // boxApellidoCliente
            // 
            this.boxApellidoCliente.Location = new System.Drawing.Point(129, 133);
            this.boxApellidoCliente.Name = "boxApellidoCliente";
            this.boxApellidoCliente.Size = new System.Drawing.Size(100, 20);
            this.boxApellidoCliente.TabIndex = 22;
            this.boxApellidoCliente.TextChanged += new System.EventHandler(this.boxApellidoCliente_TextChanged);
            this.boxApellidoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxApellidoCliente_KeyPress);
            // 
            // boxNombreCliente
            // 
            this.boxNombreCliente.Location = new System.Drawing.Point(129, 106);
            this.boxNombreCliente.Name = "boxNombreCliente";
            this.boxNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.boxNombreCliente.TabIndex = 21;
            this.boxNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxNombreCliente_KeyPress);
            // 
            // boxDniCliente
            // 
            this.boxDniCliente.Location = new System.Drawing.Point(129, 75);
            this.boxDniCliente.Name = "boxDniCliente";
            this.boxDniCliente.Size = new System.Drawing.Size(100, 20);
            this.boxDniCliente.TabIndex = 20;
            this.boxDniCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxDniCliente_KeyPress);
            // 
            // boxIdCliente
            // 
            this.boxIdCliente.Location = new System.Drawing.Point(129, 46);
            this.boxIdCliente.Name = "boxIdCliente";
            this.boxIdCliente.Size = new System.Drawing.Size(100, 20);
            this.boxIdCliente.TabIndex = 19;
            this.boxIdCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxIdCliente_KeyPress);
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.AutoSize = true;
            this.txtDireccionCliente.Location = new System.Drawing.Point(54, 191);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(52, 13);
            this.txtDireccionCliente.TabIndex = 18;
            this.txtDireccionCliente.Text = "Direccion";
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.AutoSize = true;
            this.txtTelefonoCliente.Location = new System.Drawing.Point(54, 164);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(49, 13);
            this.txtTelefonoCliente.TabIndex = 17;
            this.txtTelefonoCliente.Text = "Telefono";
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.AutoSize = true;
            this.txtApellidoCliente.Location = new System.Drawing.Point(54, 133);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(44, 13);
            this.txtApellidoCliente.TabIndex = 16;
            this.txtApellidoCliente.Text = "Apellido";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.AutoSize = true;
            this.txtNombreCliente.Location = new System.Drawing.Point(54, 106);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(44, 13);
            this.txtNombreCliente.TabIndex = 15;
            this.txtNombreCliente.Text = "Nombre";
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.AutoSize = true;
            this.txtDniCliente.Location = new System.Drawing.Point(54, 82);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(26, 13);
            this.txtDniCliente.TabIndex = 14;
            this.txtDniCliente.Text = "DNI";
            // 
            // txtIdCLiente
            // 
            this.txtIdCLiente.AutoSize = true;
            this.txtIdCLiente.Location = new System.Drawing.Point(54, 46);
            this.txtIdCLiente.Name = "txtIdCLiente";
            this.txtIdCLiente.Size = new System.Drawing.Size(53, 13);
            this.txtIdCLiente.TabIndex = 13;
            this.txtIdCLiente.Text = "ID Cliente";
            // 
            // AltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAltaCLi1);
            this.Controls.Add(this.boxDireccionCliente);
            this.Controls.Add(this.boxTelefonoCliente);
            this.Controls.Add(this.boxApellidoCliente);
            this.Controls.Add(this.boxNombreCliente);
            this.Controls.Add(this.boxDniCliente);
            this.Controls.Add(this.boxIdCliente);
            this.Controls.Add(this.txtDireccionCliente);
            this.Controls.Add(this.txtTelefonoCliente);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtDniCliente);
            this.Controls.Add(this.txtIdCLiente);
            this.Name = "AltaCliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AltaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAltaCLi1;
        private System.Windows.Forms.TextBox boxDireccionCliente;
        private System.Windows.Forms.TextBox boxTelefonoCliente;
        private System.Windows.Forms.TextBox boxApellidoCliente;
        private System.Windows.Forms.TextBox boxNombreCliente;
        private System.Windows.Forms.TextBox boxDniCliente;
        private System.Windows.Forms.TextBox boxIdCliente;
        private System.Windows.Forms.Label txtDireccionCliente;
        private System.Windows.Forms.Label txtTelefonoCliente;
        private System.Windows.Forms.Label txtApellidoCliente;
        private System.Windows.Forms.Label txtNombreCliente;
        private System.Windows.Forms.Label txtDniCliente;
        private System.Windows.Forms.Label txtIdCLiente;
    }
}