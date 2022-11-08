namespace VistaCiber1
{
    partial class ModEmpleado
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
            this.btnMod1 = new System.Windows.Forms.Button();
            this.boxDireccionEmpleadoM = new System.Windows.Forms.TextBox();
            this.boxTelefonoEmpleadoM = new System.Windows.Forms.TextBox();
            this.boxApellidoEmpleadoM = new System.Windows.Forms.TextBox();
            this.boxNombreEmpleadoM = new System.Windows.Forms.TextBox();
            this.boxDniEmpleadoM = new System.Windows.Forms.TextBox();
            this.boxIdEmpleadoM = new System.Windows.Forms.TextBox();
            this.txtDireccionEmpleado = new System.Windows.Forms.Label();
            this.txtTelefonoEmpleado = new System.Windows.Forms.Label();
            this.txtApellidoEmpleado = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.Label();
            this.txtDniEmpleado = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMod1
            // 
            this.btnMod1.Location = new System.Drawing.Point(54, 270);
            this.btnMod1.Name = "btnMod1";
            this.btnMod1.Size = new System.Drawing.Size(75, 23);
            this.btnMod1.TabIndex = 25;
            this.btnMod1.Text = "Modificar";
            this.btnMod1.UseVisualStyleBackColor = true;
            this.btnMod1.Click += new System.EventHandler(this.btnMod1_Click);
            // 
            // boxDireccionEmpleadoM
            // 
            this.boxDireccionEmpleadoM.Location = new System.Drawing.Point(126, 194);
            this.boxDireccionEmpleadoM.Name = "boxDireccionEmpleadoM";
            this.boxDireccionEmpleadoM.Size = new System.Drawing.Size(100, 20);
            this.boxDireccionEmpleadoM.TabIndex = 24;
            // 
            // boxTelefonoEmpleadoM
            // 
            this.boxTelefonoEmpleadoM.Location = new System.Drawing.Point(126, 167);
            this.boxTelefonoEmpleadoM.Name = "boxTelefonoEmpleadoM";
            this.boxTelefonoEmpleadoM.Size = new System.Drawing.Size(100, 20);
            this.boxTelefonoEmpleadoM.TabIndex = 23;
            this.boxTelefonoEmpleadoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxTelefonoEmpleadoM_KeyPress);
            // 
            // boxApellidoEmpleadoM
            // 
            this.boxApellidoEmpleadoM.Location = new System.Drawing.Point(126, 136);
            this.boxApellidoEmpleadoM.Name = "boxApellidoEmpleadoM";
            this.boxApellidoEmpleadoM.Size = new System.Drawing.Size(100, 20);
            this.boxApellidoEmpleadoM.TabIndex = 22;
            this.boxApellidoEmpleadoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxApellidoEmpleadoM_KeyPress);
            // 
            // boxNombreEmpleadoM
            // 
            this.boxNombreEmpleadoM.Location = new System.Drawing.Point(126, 109);
            this.boxNombreEmpleadoM.Name = "boxNombreEmpleadoM";
            this.boxNombreEmpleadoM.Size = new System.Drawing.Size(100, 20);
            this.boxNombreEmpleadoM.TabIndex = 21;
            this.boxNombreEmpleadoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxNombreEmpleadoM_KeyPress);
            // 
            // boxDniEmpleadoM
            // 
            this.boxDniEmpleadoM.Location = new System.Drawing.Point(126, 78);
            this.boxDniEmpleadoM.Name = "boxDniEmpleadoM";
            this.boxDniEmpleadoM.Size = new System.Drawing.Size(100, 20);
            this.boxDniEmpleadoM.TabIndex = 20;
            this.boxDniEmpleadoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxDniEmpleadoM_KeyPress);
            // 
            // boxIdEmpleadoM
            // 
            this.boxIdEmpleadoM.Location = new System.Drawing.Point(126, 49);
            this.boxIdEmpleadoM.Name = "boxIdEmpleadoM";
            this.boxIdEmpleadoM.Size = new System.Drawing.Size(100, 20);
            this.boxIdEmpleadoM.TabIndex = 19;
            this.boxIdEmpleadoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxIdEmpleadoM_KeyPress);
            // 
            // txtDireccionEmpleado
            // 
            this.txtDireccionEmpleado.AutoSize = true;
            this.txtDireccionEmpleado.Location = new System.Drawing.Point(51, 194);
            this.txtDireccionEmpleado.Name = "txtDireccionEmpleado";
            this.txtDireccionEmpleado.Size = new System.Drawing.Size(52, 13);
            this.txtDireccionEmpleado.TabIndex = 18;
            this.txtDireccionEmpleado.Text = "Direccion";
            // 
            // txtTelefonoEmpleado
            // 
            this.txtTelefonoEmpleado.AutoSize = true;
            this.txtTelefonoEmpleado.Location = new System.Drawing.Point(51, 167);
            this.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            this.txtTelefonoEmpleado.Size = new System.Drawing.Size(49, 13);
            this.txtTelefonoEmpleado.TabIndex = 17;
            this.txtTelefonoEmpleado.Text = "Telefono";
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.AutoSize = true;
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(51, 136);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(44, 13);
            this.txtApellidoEmpleado.TabIndex = 16;
            this.txtApellidoEmpleado.Text = "Apellido";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.AutoSize = true;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(51, 109);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(44, 13);
            this.txtNombreEmpleado.TabIndex = 15;
            this.txtNombreEmpleado.Text = "Nombre";
            // 
            // txtDniEmpleado
            // 
            this.txtDniEmpleado.AutoSize = true;
            this.txtDniEmpleado.Location = new System.Drawing.Point(51, 85);
            this.txtDniEmpleado.Name = "txtDniEmpleado";
            this.txtDniEmpleado.Size = new System.Drawing.Size(26, 13);
            this.txtDniEmpleado.TabIndex = 14;
            this.txtDniEmpleado.Text = "DNI";
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.AutoSize = true;
            this.txtIdEmpleado.Location = new System.Drawing.Point(51, 49);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(68, 13);
            this.txtIdEmpleado.TabIndex = 13;
            this.txtIdEmpleado.Text = "ID Empelado";
            // 
            // ModEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMod1);
            this.Controls.Add(this.boxDireccionEmpleadoM);
            this.Controls.Add(this.boxTelefonoEmpleadoM);
            this.Controls.Add(this.boxApellidoEmpleadoM);
            this.Controls.Add(this.boxNombreEmpleadoM);
            this.Controls.Add(this.boxDniEmpleadoM);
            this.Controls.Add(this.boxIdEmpleadoM);
            this.Controls.Add(this.txtDireccionEmpleado);
            this.Controls.Add(this.txtTelefonoEmpleado);
            this.Controls.Add(this.txtApellidoEmpleado);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.txtDniEmpleado);
            this.Controls.Add(this.txtIdEmpleado);
            this.Name = "ModEmpleado";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ModEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMod1;
        private System.Windows.Forms.TextBox boxDireccionEmpleadoM;
        private System.Windows.Forms.TextBox boxTelefonoEmpleadoM;
        private System.Windows.Forms.TextBox boxApellidoEmpleadoM;
        private System.Windows.Forms.TextBox boxNombreEmpleadoM;
        private System.Windows.Forms.TextBox boxDniEmpleadoM;
        private System.Windows.Forms.TextBox boxIdEmpleadoM;
        private System.Windows.Forms.Label txtDireccionEmpleado;
        private System.Windows.Forms.Label txtTelefonoEmpleado;
        private System.Windows.Forms.Label txtApellidoEmpleado;
        private System.Windows.Forms.Label txtNombreEmpleado;
        private System.Windows.Forms.Label txtDniEmpleado;
        private System.Windows.Forms.Label txtIdEmpleado;
    }
}