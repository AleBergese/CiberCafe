namespace VistaCiber1
{
    partial class Login
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
            this.txtusuario = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.Label();
            this.boxUsuario = new System.Windows.Forms.TextBox();
            this.boxContraseña = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            this.txtusuario.AutoSize = true;
            this.txtusuario.Location = new System.Drawing.Point(26, 23);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(43, 13);
            this.txtusuario.TabIndex = 0;
            this.txtusuario.Text = "Usuario";
            this.txtusuario.Click += new System.EventHandler(this.txtusuario_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.AutoSize = true;
            this.txtContraseña.Location = new System.Drawing.Point(29, 73);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(61, 13);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.Click += new System.EventHandler(this.txtContraseña_Click);
            // 
            // boxUsuario
            // 
            this.boxUsuario.Location = new System.Drawing.Point(29, 40);
            this.boxUsuario.Name = "boxUsuario";
            this.boxUsuario.Size = new System.Drawing.Size(100, 20);
            this.boxUsuario.TabIndex = 2;
            this.boxUsuario.TextChanged += new System.EventHandler(this.boxUsuario_TextChanged);
            // 
            // boxContraseña
            // 
            this.boxContraseña.Location = new System.Drawing.Point(29, 106);
            this.boxContraseña.Name = "boxContraseña";
            this.boxContraseña.PasswordChar = '*';
            this.boxContraseña.Size = new System.Drawing.Size(100, 20);
            this.boxContraseña.TabIndex = 3;
            this.boxContraseña.TextChanged += new System.EventHandler(this.boxContraseña_TextChanged);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(213, 180);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 450);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.boxContraseña);
            this.Controls.Add(this.boxUsuario);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtusuario);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtusuario;
        private System.Windows.Forms.Label txtContraseña;
        private System.Windows.Forms.TextBox boxUsuario;
        private System.Windows.Forms.TextBox boxContraseña;
        private System.Windows.Forms.Button btnEntrar;
    }
}

