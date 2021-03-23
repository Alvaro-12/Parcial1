
namespace Parcial1
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtEmpleado = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtDirreccion = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtCargo = new System.Windows.Forms.TextBox();
            this.TxtDUI = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eMPLEADODataSet = new Parcial1.EMPLEADODataSet();
            this.tblempleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_empleadoTableAdapter = new Parcial1.EMPLEADODataSetTableAdapters.Tbl_empleadoTableAdapter();
            this.idempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emplnombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emplapellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emplDUIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empldirreccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empltelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emplemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emplcargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblempleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id_empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empl_nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Empl_apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Empl_dirreccion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(251, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Empl_DUI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(251, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Empl_tel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(491, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Empl_email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(491, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Empl_cargo";
            // 
            // TxtEmpleado
            // 
            this.TxtEmpleado.Location = new System.Drawing.Point(36, 60);
            this.TxtEmpleado.Name = "TxtEmpleado";
            this.TxtEmpleado.Size = new System.Drawing.Size(149, 20);
            this.TxtEmpleado.TabIndex = 11;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(36, 242);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(149, 20);
            this.TxtApellido.TabIndex = 12;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(36, 154);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(149, 20);
            this.TxtNombre.TabIndex = 13;
            // 
            // TxtDirreccion
            // 
            this.TxtDirreccion.Location = new System.Drawing.Point(254, 154);
            this.TxtDirreccion.Name = "TxtDirreccion";
            this.TxtDirreccion.Size = new System.Drawing.Size(149, 20);
            this.TxtDirreccion.TabIndex = 14;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(254, 242);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(149, 20);
            this.TxtTelefono.TabIndex = 15;
            // 
            // TxtCargo
            // 
            this.TxtCargo.Location = new System.Drawing.Point(494, 154);
            this.TxtCargo.Name = "TxtCargo";
            this.TxtCargo.Size = new System.Drawing.Size(149, 20);
            this.TxtCargo.TabIndex = 16;
            // 
            // TxtDUI
            // 
            this.TxtDUI.Location = new System.Drawing.Point(254, 60);
            this.TxtDUI.Name = "TxtDUI";
            this.TxtDUI.Size = new System.Drawing.Size(149, 20);
            this.TxtDUI.TabIndex = 17;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(494, 60);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(149, 20);
            this.TxtEmail.TabIndex = 18;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(36, 307);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 19;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idempleadoDataGridViewTextBoxColumn,
            this.emplnombreDataGridViewTextBoxColumn,
            this.emplapellidoDataGridViewTextBoxColumn,
            this.emplDUIDataGridViewTextBoxColumn,
            this.empldirreccionDataGridViewTextBoxColumn,
            this.empltelDataGridViewTextBoxColumn,
            this.emplemailDataGridViewTextBoxColumn,
            this.emplcargoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblempleadoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 350);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(607, 266);
            this.dataGridView1.TabIndex = 20;
            // 
            // eMPLEADODataSet
            // 
            this.eMPLEADODataSet.DataSetName = "EMPLEADODataSet";
            this.eMPLEADODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblempleadoBindingSource
            // 
            this.tblempleadoBindingSource.DataMember = "Tbl_empleado";
            this.tblempleadoBindingSource.DataSource = this.eMPLEADODataSet;
            // 
            // tbl_empleadoTableAdapter
            // 
            this.tbl_empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // idempleadoDataGridViewTextBoxColumn
            // 
            this.idempleadoDataGridViewTextBoxColumn.DataPropertyName = "Id_empleado";
            this.idempleadoDataGridViewTextBoxColumn.HeaderText = "Id_empleado";
            this.idempleadoDataGridViewTextBoxColumn.Name = "idempleadoDataGridViewTextBoxColumn";
            this.idempleadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emplnombreDataGridViewTextBoxColumn
            // 
            this.emplnombreDataGridViewTextBoxColumn.DataPropertyName = "Empl_nombre";
            this.emplnombreDataGridViewTextBoxColumn.HeaderText = "Empl_nombre";
            this.emplnombreDataGridViewTextBoxColumn.Name = "emplnombreDataGridViewTextBoxColumn";
            // 
            // emplapellidoDataGridViewTextBoxColumn
            // 
            this.emplapellidoDataGridViewTextBoxColumn.DataPropertyName = "Empl_apellido";
            this.emplapellidoDataGridViewTextBoxColumn.HeaderText = "Empl_apellido";
            this.emplapellidoDataGridViewTextBoxColumn.Name = "emplapellidoDataGridViewTextBoxColumn";
            // 
            // emplDUIDataGridViewTextBoxColumn
            // 
            this.emplDUIDataGridViewTextBoxColumn.DataPropertyName = "Empl_DUI";
            this.emplDUIDataGridViewTextBoxColumn.HeaderText = "Empl_DUI";
            this.emplDUIDataGridViewTextBoxColumn.Name = "emplDUIDataGridViewTextBoxColumn";
            // 
            // empldirreccionDataGridViewTextBoxColumn
            // 
            this.empldirreccionDataGridViewTextBoxColumn.DataPropertyName = "Empl_dirreccion";
            this.empldirreccionDataGridViewTextBoxColumn.HeaderText = "Empl_dirreccion";
            this.empldirreccionDataGridViewTextBoxColumn.Name = "empldirreccionDataGridViewTextBoxColumn";
            // 
            // empltelDataGridViewTextBoxColumn
            // 
            this.empltelDataGridViewTextBoxColumn.DataPropertyName = "Empl_tel";
            this.empltelDataGridViewTextBoxColumn.HeaderText = "Empl_tel";
            this.empltelDataGridViewTextBoxColumn.Name = "empltelDataGridViewTextBoxColumn";
            // 
            // emplemailDataGridViewTextBoxColumn
            // 
            this.emplemailDataGridViewTextBoxColumn.DataPropertyName = "Empl_email";
            this.emplemailDataGridViewTextBoxColumn.HeaderText = "Empl_email";
            this.emplemailDataGridViewTextBoxColumn.Name = "emplemailDataGridViewTextBoxColumn";
            // 
            // emplcargoDataGridViewTextBoxColumn
            // 
            this.emplcargoDataGridViewTextBoxColumn.DataPropertyName = "Empl_cargo";
            this.emplcargoDataGridViewTextBoxColumn.HeaderText = "Empl_cargo";
            this.emplcargoDataGridViewTextBoxColumn.Name = "emplcargoDataGridViewTextBoxColumn";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 628);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtDUI);
            this.Controls.Add(this.TxtCargo);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtDirreccion);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtEmpleado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblempleadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtEmpleado;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtDirreccion;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtCargo;
        private System.Windows.Forms.TextBox TxtDUI;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EMPLEADODataSet eMPLEADODataSet;
        private System.Windows.Forms.BindingSource tblempleadoBindingSource;
        private EMPLEADODataSetTableAdapters.Tbl_empleadoTableAdapter tbl_empleadoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emplnombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emplapellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emplDUIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empldirreccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empltelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emplemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emplcargoDataGridViewTextBoxColumn;
    }
}

