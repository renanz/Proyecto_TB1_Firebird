namespace Mi_Cooperativa_App_VS
{
    partial class frmPrestamos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_crear = new System.Windows.Forms.TabPage();
            this.numberPeriodos = new System.Windows.Forms.NumericUpDown();
            this.lbl_periodos = new System.Windows.Forms.Label();
            this.numberMonto = new System.Windows.Forms.NumericUpDown();
            this.bt_verEmps = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_crearPrestamo = new System.Windows.Forms.Button();
            this.combo_tipoPtmo = new System.Windows.Forms.ComboBox();
            this.date_fecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_monto = new System.Windows.Forms.Label();
            this.lbl_tipoPrestamo = new System.Windows.Forms.Label();
            this.txtbx_id_empleado = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.tabPage_eliminar = new System.Windows.Forms.TabPage();
            this.lbl_prestamo_borrar = new System.Windows.Forms.Label();
            this.lbl_Prestamo_selected = new System.Windows.Forms.Label();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_mostrar_eliminar = new System.Windows.Forms.Button();
            this.grid_todos_eliminar = new System.Windows.Forms.DataGridView();
            this.tabPage_modificar = new System.Windows.Forms.TabPage();
            this.tabPage_prestamos = new System.Windows.Forms.TabPage();
            this.bt_mostrarPrestamos = new System.Windows.Forms.Button();
            this.grid_Todos = new System.Windows.Forms.DataGridView();
            this.bt_atras = new System.Windows.Forms.Button();
            this.lbl_usuarioConectado = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage_crear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberPeriodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage_eliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_todos_eliminar)).BeginInit();
            this.tabPage_prestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Todos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_crear);
            this.tabControl1.Controls.Add(this.tabPage_eliminar);
            this.tabControl1.Controls.Add(this.tabPage_modificar);
            this.tabControl1.Controls.Add(this.tabPage_prestamos);
            this.tabControl1.Location = new System.Drawing.Point(12, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(625, 462);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage_crear
            // 
            this.tabPage_crear.Controls.Add(this.numberPeriodos);
            this.tabPage_crear.Controls.Add(this.lbl_periodos);
            this.tabPage_crear.Controls.Add(this.numberMonto);
            this.tabPage_crear.Controls.Add(this.bt_verEmps);
            this.tabPage_crear.Controls.Add(this.dataGridView1);
            this.tabPage_crear.Controls.Add(this.bt_crearPrestamo);
            this.tabPage_crear.Controls.Add(this.combo_tipoPtmo);
            this.tabPage_crear.Controls.Add(this.date_fecha);
            this.tabPage_crear.Controls.Add(this.lbl_fecha);
            this.tabPage_crear.Controls.Add(this.lbl_monto);
            this.tabPage_crear.Controls.Add(this.lbl_tipoPrestamo);
            this.tabPage_crear.Controls.Add(this.txtbx_id_empleado);
            this.tabPage_crear.Controls.Add(this.lbl_id);
            this.tabPage_crear.Location = new System.Drawing.Point(4, 22);
            this.tabPage_crear.Name = "tabPage_crear";
            this.tabPage_crear.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_crear.Size = new System.Drawing.Size(617, 436);
            this.tabPage_crear.TabIndex = 0;
            this.tabPage_crear.Text = "Crear";
            this.tabPage_crear.UseVisualStyleBackColor = true;
            // 
            // numberPeriodos
            // 
            this.numberPeriodos.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberPeriodos.Location = new System.Drawing.Point(478, 92);
            this.numberPeriodos.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numberPeriodos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberPeriodos.Name = "numberPeriodos";
            this.numberPeriodos.Size = new System.Drawing.Size(120, 27);
            this.numberPeriodos.TabIndex = 43;
            this.numberPeriodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_periodos
            // 
            this.lbl_periodos.AutoSize = true;
            this.lbl_periodos.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_periodos.Location = new System.Drawing.Point(351, 100);
            this.lbl_periodos.Name = "lbl_periodos";
            this.lbl_periodos.Size = new System.Drawing.Size(80, 19);
            this.lbl_periodos.TabIndex = 42;
            this.lbl_periodos.Text = "PERIODOS";
            // 
            // numberMonto
            // 
            this.numberMonto.DecimalPlaces = 4;
            this.numberMonto.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberMonto.Location = new System.Drawing.Point(139, 139);
            this.numberMonto.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numberMonto.Name = "numberMonto";
            this.numberMonto.Size = new System.Drawing.Size(120, 27);
            this.numberMonto.TabIndex = 41;
            // 
            // bt_verEmps
            // 
            this.bt_verEmps.Location = new System.Drawing.Point(13, 260);
            this.bt_verEmps.Name = "bt_verEmps";
            this.bt_verEmps.Size = new System.Drawing.Size(136, 23);
            this.bt_verEmps.TabIndex = 40;
            this.bt_verEmps.Text = "Ver Empleados";
            this.bt_verEmps.UseVisualStyleBackColor = true;
            this.bt_verEmps.Click += new System.EventHandler(this.bt_verEmps_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(589, 141);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bt_crearPrestamo
            // 
            this.bt_crearPrestamo.Location = new System.Drawing.Point(255, 204);
            this.bt_crearPrestamo.Name = "bt_crearPrestamo";
            this.bt_crearPrestamo.Size = new System.Drawing.Size(136, 36);
            this.bt_crearPrestamo.TabIndex = 38;
            this.bt_crearPrestamo.Text = "Crear Prestamo";
            this.bt_crearPrestamo.UseVisualStyleBackColor = true;
            this.bt_crearPrestamo.Click += new System.EventHandler(this.bt_crearPrestamo_Click);
            // 
            // combo_tipoPtmo
            // 
            this.combo_tipoPtmo.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_tipoPtmo.FormattingEnabled = true;
            this.combo_tipoPtmo.Items.AddRange(new object[] {
            "Automatico",
            "Fiduciario"});
            this.combo_tipoPtmo.Location = new System.Drawing.Point(161, 97);
            this.combo_tipoPtmo.Name = "combo_tipoPtmo";
            this.combo_tipoPtmo.Size = new System.Drawing.Size(121, 27);
            this.combo_tipoPtmo.TabIndex = 36;
            // 
            // date_fecha
            // 
            this.date_fecha.Location = new System.Drawing.Point(392, 147);
            this.date_fecha.Name = "date_fecha";
            this.date_fecha.Size = new System.Drawing.Size(206, 20);
            this.date_fecha.TabIndex = 34;
            this.date_fecha.UseWaitCursor = true;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(313, 147);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(54, 19);
            this.lbl_fecha.TabIndex = 32;
            this.lbl_fecha.Text = "FECHA";
            // 
            // lbl_monto
            // 
            this.lbl_monto.AutoSize = true;
            this.lbl_monto.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monto.Location = new System.Drawing.Point(12, 147);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(64, 19);
            this.lbl_monto.TabIndex = 30;
            this.lbl_monto.Text = "MONTO";
            // 
            // lbl_tipoPrestamo
            // 
            this.lbl_tipoPrestamo.AutoSize = true;
            this.lbl_tipoPrestamo.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoPrestamo.Location = new System.Drawing.Point(12, 100);
            this.lbl_tipoPrestamo.Name = "lbl_tipoPrestamo";
            this.lbl_tipoPrestamo.Size = new System.Drawing.Size(143, 19);
            this.lbl_tipoPrestamo.TabIndex = 26;
            this.lbl_tipoPrestamo.Text = "TIPO DE PRESTAMO";
            // 
            // txtbx_id_empleado
            // 
            this.txtbx_id_empleado.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_id_empleado.Location = new System.Drawing.Point(165, 28);
            this.txtbx_id_empleado.MaxLength = 12;
            this.txtbx_id_empleado.Name = "txtbx_id_empleado";
            this.txtbx_id_empleado.Size = new System.Drawing.Size(135, 27);
            this.txtbx_id_empleado.TabIndex = 25;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(12, 31);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(109, 19);
            this.lbl_id.TabIndex = 24;
            this.lbl_id.Text = "ID_EMPLEADO";
            // 
            // tabPage_eliminar
            // 
            this.tabPage_eliminar.Controls.Add(this.lbl_prestamo_borrar);
            this.tabPage_eliminar.Controls.Add(this.lbl_Prestamo_selected);
            this.tabPage_eliminar.Controls.Add(this.bt_eliminar);
            this.tabPage_eliminar.Controls.Add(this.bt_mostrar_eliminar);
            this.tabPage_eliminar.Controls.Add(this.grid_todos_eliminar);
            this.tabPage_eliminar.Location = new System.Drawing.Point(4, 22);
            this.tabPage_eliminar.Name = "tabPage_eliminar";
            this.tabPage_eliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_eliminar.Size = new System.Drawing.Size(617, 436);
            this.tabPage_eliminar.TabIndex = 1;
            this.tabPage_eliminar.Text = "Eliminar";
            this.tabPage_eliminar.UseVisualStyleBackColor = true;
            // 
            // lbl_prestamo_borrar
            // 
            this.lbl_prestamo_borrar.AutoSize = true;
            this.lbl_prestamo_borrar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prestamo_borrar.Location = new System.Drawing.Point(352, 33);
            this.lbl_prestamo_borrar.Name = "lbl_prestamo_borrar";
            this.lbl_prestamo_borrar.Size = new System.Drawing.Size(0, 19);
            this.lbl_prestamo_borrar.TabIndex = 11;
            // 
            // lbl_Prestamo_selected
            // 
            this.lbl_Prestamo_selected.AutoSize = true;
            this.lbl_Prestamo_selected.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Prestamo_selected.Location = new System.Drawing.Point(171, 29);
            this.lbl_Prestamo_selected.Name = "lbl_Prestamo_selected";
            this.lbl_Prestamo_selected.Size = new System.Drawing.Size(170, 19);
            this.lbl_Prestamo_selected.TabIndex = 10;
            this.lbl_Prestamo_selected.Text = "Prestamo seleccionado:";
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_eliminar.Location = new System.Drawing.Point(468, 28);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(143, 28);
            this.bt_eliminar.TabIndex = 9;
            this.bt_eliminar.Text = "Eliminar prestamo";
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // bt_mostrar_eliminar
            // 
            this.bt_mostrar_eliminar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mostrar_eliminar.Location = new System.Drawing.Point(6, 24);
            this.bt_mostrar_eliminar.Name = "bt_mostrar_eliminar";
            this.bt_mostrar_eliminar.Size = new System.Drawing.Size(159, 28);
            this.bt_mostrar_eliminar.TabIndex = 8;
            this.bt_mostrar_eliminar.Text = "Mostrar Prestamos";
            this.bt_mostrar_eliminar.UseVisualStyleBackColor = true;
            this.bt_mostrar_eliminar.Click += new System.EventHandler(this.bt_mostrar_eliminar_Click);
            // 
            // grid_todos_eliminar
            // 
            this.grid_todos_eliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_todos_eliminar.Location = new System.Drawing.Point(8, 72);
            this.grid_todos_eliminar.Name = "grid_todos_eliminar";
            this.grid_todos_eliminar.Size = new System.Drawing.Size(603, 358);
            this.grid_todos_eliminar.TabIndex = 7;
            this.grid_todos_eliminar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_todos_eliminar_CellContentClick);
            // 
            // tabPage_modificar
            // 
            this.tabPage_modificar.Location = new System.Drawing.Point(4, 22);
            this.tabPage_modificar.Name = "tabPage_modificar";
            this.tabPage_modificar.Size = new System.Drawing.Size(617, 436);
            this.tabPage_modificar.TabIndex = 2;
            this.tabPage_modificar.Text = "Modificar";
            this.tabPage_modificar.UseVisualStyleBackColor = true;
            // 
            // tabPage_prestamos
            // 
            this.tabPage_prestamos.Controls.Add(this.bt_mostrarPrestamos);
            this.tabPage_prestamos.Controls.Add(this.grid_Todos);
            this.tabPage_prestamos.Location = new System.Drawing.Point(4, 22);
            this.tabPage_prestamos.Name = "tabPage_prestamos";
            this.tabPage_prestamos.Size = new System.Drawing.Size(617, 436);
            this.tabPage_prestamos.TabIndex = 3;
            this.tabPage_prestamos.Text = "Prestamos";
            this.tabPage_prestamos.UseVisualStyleBackColor = true;
            // 
            // bt_mostrarPrestamos
            // 
            this.bt_mostrarPrestamos.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mostrarPrestamos.Location = new System.Drawing.Point(20, 29);
            this.bt_mostrarPrestamos.Name = "bt_mostrarPrestamos";
            this.bt_mostrarPrestamos.Size = new System.Drawing.Size(167, 28);
            this.bt_mostrarPrestamos.TabIndex = 3;
            this.bt_mostrarPrestamos.Text = "Mostrar Prestamos";
            this.bt_mostrarPrestamos.UseVisualStyleBackColor = true;
            this.bt_mostrarPrestamos.Click += new System.EventHandler(this.bt_mostrarPrestamos_Click);
            // 
            // grid_Todos
            // 
            this.grid_Todos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Todos.Location = new System.Drawing.Point(9, 76);
            this.grid_Todos.Name = "grid_Todos";
            this.grid_Todos.Size = new System.Drawing.Size(605, 357);
            this.grid_Todos.TabIndex = 2;
            // 
            // bt_atras
            // 
            this.bt_atras.Location = new System.Drawing.Point(559, 2);
            this.bt_atras.Name = "bt_atras";
            this.bt_atras.Size = new System.Drawing.Size(78, 24);
            this.bt_atras.TabIndex = 11;
            this.bt_atras.Text = "Atras";
            this.bt_atras.UseVisualStyleBackColor = true;
            this.bt_atras.Click += new System.EventHandler(this.bt_atras_Click);
            // 
            // lbl_usuarioConectado
            // 
            this.lbl_usuarioConectado.AutoSize = true;
            this.lbl_usuarioConectado.Location = new System.Drawing.Point(122, 2);
            this.lbl_usuarioConectado.Name = "lbl_usuarioConectado";
            this.lbl_usuarioConectado.Size = new System.Drawing.Size(0, 13);
            this.lbl_usuarioConectado.TabIndex = 10;
            // 
            // frmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 506);
            this.Controls.Add(this.bt_atras);
            this.Controls.Add(this.lbl_usuarioConectado);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPrestamos";
            this.Text = "frmPrestamos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_crear.ResumeLayout(false);
            this.tabPage_crear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberPeriodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage_eliminar.ResumeLayout(false);
            this.tabPage_eliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_todos_eliminar)).EndInit();
            this.tabPage_prestamos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Todos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_crear;
        private System.Windows.Forms.NumericUpDown numberMonto;
        private System.Windows.Forms.Button bt_verEmps;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_crearPrestamo;
        private System.Windows.Forms.ComboBox combo_tipoPtmo;
        private System.Windows.Forms.DateTimePicker date_fecha;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_monto;
        private System.Windows.Forms.Label lbl_tipoPrestamo;
        private System.Windows.Forms.TextBox txtbx_id_empleado;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TabPage tabPage_eliminar;
        private System.Windows.Forms.Label lbl_prestamo_borrar;
        private System.Windows.Forms.Label lbl_Prestamo_selected;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_mostrar_eliminar;
        private System.Windows.Forms.DataGridView grid_todos_eliminar;
        private System.Windows.Forms.TabPage tabPage_modificar;
        private System.Windows.Forms.TabPage tabPage_prestamos;
        private System.Windows.Forms.Button bt_mostrarPrestamos;
        private System.Windows.Forms.DataGridView grid_Todos;
        private System.Windows.Forms.Button bt_atras;
        private System.Windows.Forms.Label lbl_usuarioConectado;
        private System.Windows.Forms.NumericUpDown numberPeriodos;
        private System.Windows.Forms.Label lbl_periodos;
    }
}