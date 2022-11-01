namespace VistaCiber1
{
    partial class GrillaProveedor
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
            this.components = new System.ComponentModel.Container();
            this.grillaPro = new System.Windows.Forms.DataGridView();
            this.idProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAltaPro = new System.Windows.Forms.Button();
            this.btnModPro = new System.Windows.Forms.Button();
            this.btnBajaPro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaPro
            // 
            this.grillaPro.AutoGenerateColumns = false;
            this.grillaPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProveedorDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn});
            this.grillaPro.DataSource = this.proveedorBindingSource;
            this.grillaPro.Location = new System.Drawing.Point(91, 44);
            this.grillaPro.Name = "grillaPro";
            this.grillaPro.Size = new System.Drawing.Size(644, 150);
            this.grillaPro.TabIndex = 0;
            // 
            // idProveedorDataGridViewTextBoxColumn
            // 
            this.idProveedorDataGridViewTextBoxColumn.DataPropertyName = "idProveedor";
            this.idProveedorDataGridViewTextBoxColumn.HeaderText = "idProveedor";
            this.idProveedorDataGridViewTextBoxColumn.Name = "idProveedorDataGridViewTextBoxColumn";
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataSource = typeof(Logicaa1.proveedor);
            // 
            // btnAltaPro
            // 
            this.btnAltaPro.Location = new System.Drawing.Point(91, 285);
            this.btnAltaPro.Name = "btnAltaPro";
            this.btnAltaPro.Size = new System.Drawing.Size(75, 23);
            this.btnAltaPro.TabIndex = 1;
            this.btnAltaPro.Text = "Alta";
            this.btnAltaPro.UseVisualStyleBackColor = true;
            this.btnAltaPro.Click += new System.EventHandler(this.btnAltaPro_Click);
            // 
            // btnModPro
            // 
            this.btnModPro.Location = new System.Drawing.Point(388, 285);
            this.btnModPro.Name = "btnModPro";
            this.btnModPro.Size = new System.Drawing.Size(75, 23);
            this.btnModPro.TabIndex = 2;
            this.btnModPro.Text = "Modificacion";
            this.btnModPro.UseVisualStyleBackColor = true;
            this.btnModPro.Click += new System.EventHandler(this.btnModPro_Click);
            // 
            // btnBajaPro
            // 
            this.btnBajaPro.Location = new System.Drawing.Point(660, 285);
            this.btnBajaPro.Name = "btnBajaPro";
            this.btnBajaPro.Size = new System.Drawing.Size(75, 23);
            this.btnBajaPro.TabIndex = 3;
            this.btnBajaPro.Text = "Eliminar";
            this.btnBajaPro.UseVisualStyleBackColor = true;
            this.btnBajaPro.Click += new System.EventHandler(this.btnBajaPro_Click);
            // 
            // GrillaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBajaPro);
            this.Controls.Add(this.btnModPro);
            this.Controls.Add(this.btnAltaPro);
            this.Controls.Add(this.grillaPro);
            this.Name = "GrillaProveedor";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GrillaProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaPro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private System.Windows.Forms.Button btnAltaPro;
        private System.Windows.Forms.Button btnModPro;
        private System.Windows.Forms.Button btnBajaPro;
    }
}