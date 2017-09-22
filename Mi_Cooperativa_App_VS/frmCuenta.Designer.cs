namespace Mi_Cooperativa_App_VS
{
    partial class frmCuenta
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
            this.numberAhorro = new System.Windows.Forms.NumericUpDown();
            this.numberSaldo = new System.Windows.Forms.NumericUpDown();
            this.bt_verEmps = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_crearCuenta = new System.Windows.Forms.Button();
            this.combo_tipoCta = new System.Windows.Forms.ComboBox();
            this.date_apertura = new System.Windows.Forms.DateTimePicker();
            this.lbl_segundo_apellido = new System.Windows.Forms.Label();
            this.lbl_primer_apellido = new System.Windows.Forms.Label();
            this.lbl_segundo_nombre = new System.Windows.Forms.Label();
            this.lbl_primer_nombre = new System.Windows.Forms.Label();
            this.txtbx_id_empleado = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.tabPage_eliminar = new System.Windows.Forms.TabPage();
            this.lbl_cuenta_borrar = new System.Windows.Forms.Label();
            this.lbl_usuario_selected = new System.Windows.Forms.Label();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_mostrar_eliminar = new System.Windows.Forms.Button();
            this.grid_todos_eliminar = new System.Windows.Forms.DataGridView();
            this.tabPage_modificar = new System.Windows.Forms.TabPage();
            this.tabPage_cuentas = new System.Windows.Forms.TabPage();
            this.bt_mostrarCuentas = new System.Windows.Forms.Button();
            this.grid_Todos = new System.Windows.Forms.DataGridView();
            this.bt_atras = new System.Windows.Forms.Button();
            this.lbl_usuarioConectado = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage_crear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberAhorro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberSaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage_eliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_todos_eliminar)).BeginInit();
            this.tabPage_cuentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Todos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_crear);
            this.tabControl1.Controls.Add(this.tabPage_eliminar);
            this.tabControl1.Controls.Add(this.tabPage_modificar);
            this.tabControl1.Controls.Add(this.tabPage_cuentas);
            this.tabControl1.Location = new System.Drawing.Point(-1, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(651, 480);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_crear
            // 
            this.tabPage_crear.Controls.Add(this.numberAhorro);
            this.tabPage_crear.Controls.Add(this.numberSaldo);
            this.tabPage_crear.Controls.Add(this.bt_verEmps);
            this.tabPage_crear.Controls.Add(this.dataGridView1);
            this.tabPage_crear.Controls.Add(this.bt_crearCuenta);
            this.tabPage_crear.Controls.Add(this.combo_tipoCta);
            this.tabPage_crear.Controls.Add(this.date_apertura);
            this.tabPage_crear.Controls.Add(this.lbl_segundo_apellido);
            this.tabPage_crear.Controls.Add(this.lbl_primer_apellido);
            this.tabPage_crear.Controls.Add(this.lbl_segundo_nombre);
            this.tabPage_crear.Controls.Add(this.lbl_primer_nombre);
            this.tabPage_crear.Controls.Add(this.txtbx_id_empleado);
            this.tabPage_crear.Controls.Add(this.lbl_id);
            this.tabPage_crear.Location = new System.Drawing.Point(4, 22);
            this.tabPage_crear.Name = "tabPage_crear";
            this.tabPage_crear.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_crear.Size = new System.Drawing.Size(643, 454);
            this.tabPage_crear.TabIndex = 0;
            this.tabPage_crear.Text = "Crear";
            this.tabPage_crear.UseVisualStyleBackColor = true;
            // 
            // numberAhorro
            // 
            this.numberAhorro.DecimalPlaces = 4;
            this.numberAhorro.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberAhorro.Location = new System.Drawing.Point(485, 111);
            this.numberAhorro.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numberAhorro.Name = "numberAhorro";
            this.numberAhorro.Size = new System.Drawing.Size(120, 27);
            this.numberAhorro.TabIndex = 42;
            // 
            // numberSaldo
            // 
            this.numberSaldo.DecimalPlaces = 4;
            this.numberSaldo.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberSaldo.Location = new System.Drawing.Point(147, 152);
            this.numberSaldo.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numberSaldo.Name = "numberSaldo";
            this.numberSaldo.Size = new System.Drawing.Size(120, 27);
            this.numberSaldo.TabIndex = 41;
            // 
            // bt_verEmps
            // 
            this.bt_verEmps.Location = new System.Drawing.Point(24, 286);
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(611, 130);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bt_crearCuenta
            // 
            this.bt_crearCuenta.Location = new System.Drawing.Point(263, 217);
            this.bt_crearCuenta.Name = "bt_crearCuenta";
            this.bt_crearCuenta.Size = new System.Drawing.Size(136, 36);
            this.bt_crearCuenta.TabIndex = 38;
            this.bt_crearCuenta.Text = "Crear Cuenta";
            this.bt_crearCuenta.UseVisualStyleBackColor = true;
            this.bt_crearCuenta.Click += new System.EventHandler(this.bt_crearCuenta_Click);
            // 
            // combo_tipoCta
            // 
            this.combo_tipoCta.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_tipoCta.FormattingEnabled = true;
            this.combo_tipoCta.Items.AddRange(new object[] {
            "Aportaciones",
            "Ahorro Retirable"});
            this.combo_tipoCta.Location = new System.Drawing.Point(148, 110);
            this.combo_tipoCta.Name = "combo_tipoCta";
            this.combo_tipoCta.Size = new System.Drawing.Size(121, 27);
            this.combo_tipoCta.TabIndex = 36;
            // 
            // date_apertura
            // 
            this.date_apertura.Location = new System.Drawing.Point(438, 160);
            this.date_apertura.Name = "date_apertura";
            this.date_apertura.Size = new System.Drawing.Size(206, 20);
            this.date_apertura.TabIndex = 34;
            this.date_apertura.UseWaitCursor = true;
            // 
            // lbl_segundo_apellido
            // 
            this.lbl_segundo_apellido.AutoSize = true;
            this.lbl_segundo_apellido.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_segundo_apellido.Location = new System.Drawing.Point(299, 160);
            this.lbl_segundo_apellido.Name = "lbl_segundo_apellido";
            this.lbl_segundo_apellido.Size = new System.Drawing.Size(138, 19);
            this.lbl_segundo_apellido.TabIndex = 32;
            this.lbl_segundo_apellido.Text = "FECHA_APERTURA";
            // 
            // lbl_primer_apellido
            // 
            this.lbl_primer_apellido.AutoSize = true;
            this.lbl_primer_apellido.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_primer_apellido.Location = new System.Drawing.Point(20, 160);
            this.lbl_primer_apellido.Name = "lbl_primer_apellido";
            this.lbl_primer_apellido.Size = new System.Drawing.Size(56, 19);
            this.lbl_primer_apellido.TabIndex = 30;
            this.lbl_primer_apellido.Text = "SALDO";
            // 
            // lbl_segundo_nombre
            // 
            this.lbl_segundo_nombre.AutoSize = true;
            this.lbl_segundo_nombre.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_segundo_nombre.Location = new System.Drawing.Point(335, 113);
            this.lbl_segundo_nombre.Name = "lbl_segundo_nombre";
            this.lbl_segundo_nombre.Size = new System.Drawing.Size(144, 19);
            this.lbl_segundo_nombre.TabIndex = 28;
            this.lbl_segundo_nombre.Text = "AHORRO MENSUAL";
            // 
            // lbl_primer_nombre
            // 
            this.lbl_primer_nombre.AutoSize = true;
            this.lbl_primer_nombre.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_primer_nombre.Location = new System.Drawing.Point(20, 113);
            this.lbl_primer_nombre.Name = "lbl_primer_nombre";
            this.lbl_primer_nombre.Size = new System.Drawing.Size(122, 19);
            this.lbl_primer_nombre.TabIndex = 26;
            this.lbl_primer_nombre.Text = "TIPO DE CUENTA";
            // 
            // txtbx_id_empleado
            // 
            this.txtbx_id_empleado.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_id_empleado.Location = new System.Drawing.Point(173, 41);
            this.txtbx_id_empleado.MaxLength = 12;
            this.txtbx_id_empleado.Name = "txtbx_id_empleado";
            this.txtbx_id_empleado.Size = new System.Drawing.Size(135, 27);
            this.txtbx_id_empleado.TabIndex = 25;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(20, 44);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(109, 19);
            this.lbl_id.TabIndex = 24;
            this.lbl_id.Text = "ID_EMPLEADO";
            // 
            // tabPage_eliminar
            // 
            this.tabPage_eliminar.Controls.Add(this.lbl_cuenta_borrar);
            this.tabPage_eliminar.Controls.Add(this.lbl_usuario_selected);
            this.tabPage_eliminar.Controls.Add(this.bt_eliminar);
            this.tabPage_eliminar.Controls.Add(this.bt_mostrar_eliminar);
            this.tabPage_eliminar.Controls.Add(this.grid_todos_eliminar);
            this.tabPage_eliminar.Location = new System.Drawing.Point(4, 22);
            this.tabPage_eliminar.Name = "tabPage_eliminar";
            this.tabPage_eliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_eliminar.Size = new System.Drawing.Size(643, 454);
            this.tabPage_eliminar.TabIndex = 1;
            this.tabPage_eliminar.Text = "Eliminar";
            this.tabPage_eliminar.UseVisualStyleBackColor = true;
            // 
            // lbl_cuenta_borrar
            // 
            this.lbl_cuenta_borrar.AutoSize = true;
            this.lbl_cuenta_borrar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cuenta_borrar.Location = new System.Drawing.Point(352, 33);
            this.lbl_cuenta_borrar.Name = "lbl_cuenta_borrar";
            this.lbl_cuenta_borrar.Size = new System.Drawing.Size(0, 19);
            this.lbl_cuenta_borrar.TabIndex = 11;
            // 
            // lbl_usuario_selected
            // 
            this.lbl_usuario_selected.AutoSize = true;
            this.lbl_usuario_selected.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario_selected.Location = new System.Drawing.Point(171, 29);
            this.lbl_usuario_selected.Name = "lbl_usuario_selected";
            this.lbl_usuario_selected.Size = new System.Drawing.Size(152, 19);
            this.lbl_usuario_selected.TabIndex = 10;
            this.lbl_usuario_selected.Text = "Cuenta seleccionada:";
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_eliminar.Location = new System.Drawing.Point(494, 24);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(143, 28);
            this.bt_eliminar.TabIndex = 9;
            this.bt_eliminar.Text = "Eliminar cuenta";
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
            this.bt_mostrar_eliminar.Text = "Mostrar Cuentas";
            this.bt_mostrar_eliminar.UseVisualStyleBackColor = true;
            this.bt_mostrar_eliminar.Click += new System.EventHandler(this.bt_mostrar_eliminar_Click);
            // 
            // grid_todos_eliminar
            // 
            this.grid_todos_eliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_todos_eliminar.Location = new System.Drawing.Point(8, 72);
            this.grid_todos_eliminar.Name = "grid_todos_eliminar";
            this.grid_todos_eliminar.Size = new System.Drawing.Size(626, 373);
            this.grid_todos_eliminar.TabIndex = 7;
            this.grid_todos_eliminar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_todos_eliminar_CellContentClick);
            // 
            // tabPage_modificar
            // 
            this.tabPage_modificar.Location = new System.Drawing.Point(4, 22);
            this.tabPage_modificar.Name = "tabPage_modificar";
            this.tabPage_modificar.Size = new System.Drawing.Size(643, 454);
            this.tabPage_modificar.TabIndex = 2;
            this.tabPage_modificar.Text = "Modificar";
            this.tabPage_modificar.UseVisualStyleBackColor = true;
            // 
            // tabPage_cuentas
            // 
            this.tabPage_cuentas.Controls.Add(this.bt_mostrarCuentas);
            this.tabPage_cuentas.Controls.Add(this.grid_Todos);
            this.tabPage_cuentas.Location = new System.Drawing.Point(4, 22);
            this.tabPage_cuentas.Name = "tabPage_cuentas";
            this.tabPage_cuentas.Size = new System.Drawing.Size(643, 454);
            this.tabPage_cuentas.TabIndex = 3;
            this.tabPage_cuentas.Text = "Cuentas";
            this.tabPage_cuentas.UseVisualStyleBackColor = true;
            // 
            // bt_mostrarCuentas
            // 
            this.bt_mostrarCuentas.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mostrarCuentas.Location = new System.Drawing.Point(20, 29);
            this.bt_mostrarCuentas.Name = "bt_mostrarCuentas";
            this.bt_mostrarCuentas.Size = new System.Drawing.Size(167, 28);
            this.bt_mostrarCuentas.TabIndex = 3;
            this.bt_mostrarCuentas.Text = "Mostrar Cuentas";
            this.bt_mostrarCuentas.UseVisualStyleBackColor = true;
            this.bt_mostrarCuentas.Click += new System.EventHandler(this.bt_mostrarCuentas_Click);
            // 
            // grid_Todos
            // 
            this.grid_Todos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Todos.Location = new System.Drawing.Point(9, 76);
            this.grid_Todos.Name = "grid_Todos";
            this.grid_Todos.Size = new System.Drawing.Size(608, 369);
            this.grid_Todos.TabIndex = 2;
            // 
            // bt_atras
            // 
            this.bt_atras.Location = new System.Drawing.Point(568, 8);
            this.bt_atras.Name = "bt_atras";
            this.bt_atras.Size = new System.Drawing.Size(78, 24);
            this.bt_atras.TabIndex = 9;
            this.bt_atras.Text = "Atras";
            this.bt_atras.UseVisualStyleBackColor = true;
            this.bt_atras.Click += new System.EventHandler(this.bt_atras_Click);
            // 
            // lbl_usuarioConectado
            // 
            this.lbl_usuarioConectado.AutoSize = true;
            this.lbl_usuarioConectado.Location = new System.Drawing.Point(97, 8);
            this.lbl_usuarioConectado.Name = "lbl_usuarioConectado";
            this.lbl_usuarioConectado.Size = new System.Drawing.Size(0, 13);
            this.lbl_usuarioConectado.TabIndex = 8;
            // 
            // frmCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 506);
            this.Controls.Add(this.bt_atras);
            this.Controls.Add(this.lbl_usuarioConectado);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmCuenta";
            this.Text = "frmCuenta";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_crear.ResumeLayout(false);
            this.tabPage_crear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberAhorro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberSaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage_eliminar.ResumeLayout(false);
            this.tabPage_eliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_todos_eliminar)).EndInit();
            this.tabPage_cuentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Todos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_crear;
        private System.Windows.Forms.TabPage tabPage_eliminar;
        private System.Windows.Forms.Button bt_atras;
        private System.Windows.Forms.Label lbl_usuarioConectado;
        private System.Windows.Forms.TabPage tabPage_modificar;
        private System.Windows.Forms.TabPage tabPage_cuentas;
        private System.Windows.Forms.DateTimePicker date_apertura;
        private System.Windows.Forms.Label lbl_segundo_apellido;
        private System.Windows.Forms.Label lbl_primer_apellido;
        private System.Windows.Forms.Label lbl_segundo_nombre;
        private System.Windows.Forms.Label lbl_primer_nombre;
        private System.Windows.Forms.TextBox txtbx_id_empleado;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button bt_crearCuenta;
        private System.Windows.Forms.ComboBox combo_tipoCta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_verEmps;
        private System.Windows.Forms.NumericUpDown numberAhorro;
        private System.Windows.Forms.NumericUpDown numberSaldo;
        private System.Windows.Forms.Label lbl_cuenta_borrar;
        private System.Windows.Forms.Label lbl_usuario_selected;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_mostrar_eliminar;
        private System.Windows.Forms.DataGridView grid_todos_eliminar;
        private System.Windows.Forms.Button bt_mostrarCuentas;
        private System.Windows.Forms.DataGridView grid_Todos;
    }
}