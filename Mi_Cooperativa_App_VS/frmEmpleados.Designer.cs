namespace Mi_Cooperativa_App_VS
{
    partial class frmEmpleados
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
            this.bt_agregar = new System.Windows.Forms.Button();
            this.lbl_datos = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txtbx_referencia = new System.Windows.Forms.TextBox();
            this.lbl_referencia = new System.Windows.Forms.Label();
            this.txtbx_departamento = new System.Windows.Forms.TextBox();
            this.lbl_departamento = new System.Windows.Forms.Label();
            this.txtbx_ciudad = new System.Windows.Forms.TextBox();
            this.lbl_ciudad = new System.Windows.Forms.Label();
            this.txtbx_no_casa = new System.Windows.Forms.MaskedTextBox();
            this.lbl_no_casa = new System.Windows.Forms.Label();
            this.txtbx_avenida = new System.Windows.Forms.TextBox();
            this.lbl_avenida = new System.Windows.Forms.Label();
            this.txtbx_calle = new System.Windows.Forms.TextBox();
            this.lbl_calle = new System.Windows.Forms.Label();
            this.date_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha_inicio = new System.Windows.Forms.Label();
            this.date_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha_nacimiento = new System.Windows.Forms.Label();
            this.txtbx_segundo_apellido = new System.Windows.Forms.TextBox();
            this.lbl_segundo_apellido = new System.Windows.Forms.Label();
            this.txtbx_primer_apellido = new System.Windows.Forms.TextBox();
            this.lbl_primer_apellido = new System.Windows.Forms.Label();
            this.txtbx_segundo_nombre = new System.Windows.Forms.TextBox();
            this.lbl_segundo_nombre = new System.Windows.Forms.Label();
            this.txtbx_primer_nombre = new System.Windows.Forms.TextBox();
            this.lbl_primer_nombre = new System.Windows.Forms.Label();
            this.txtbx_id_usuario = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.tabPage_modificar = new System.Windows.Forms.TabPage();
            this.tabPage_eliminar = new System.Windows.Forms.TabPage();
            this.lbl_usuario_borrar = new System.Windows.Forms.Label();
            this.lbl_usuario_selected = new System.Windows.Forms.Label();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_mostrar_eliminar = new System.Windows.Forms.Button();
            this.grid_todos_eliminar = new System.Windows.Forms.DataGridView();
            this.tabPage_empleados = new System.Windows.Forms.TabPage();
            this.bt_mostrarEmps = new System.Windows.Forms.Button();
            this.grid_Todos = new System.Windows.Forms.DataGridView();
            this.bt_atras = new System.Windows.Forms.Button();
            this.lbl_usuarioConectado = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage_crear.SuspendLayout();
            this.tabPage_eliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_todos_eliminar)).BeginInit();
            this.tabPage_empleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Todos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_crear);
            this.tabControl1.Controls.Add(this.tabPage_modificar);
            this.tabControl1.Controls.Add(this.tabPage_eliminar);
            this.tabControl1.Controls.Add(this.tabPage_empleados);
            this.tabControl1.Location = new System.Drawing.Point(0, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(753, 514);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_crear
            // 
            this.tabPage_crear.Controls.Add(this.bt_agregar);
            this.tabPage_crear.Controls.Add(this.lbl_datos);
            this.tabPage_crear.Controls.Add(this.lbl_direccion);
            this.tabPage_crear.Controls.Add(this.txtbx_referencia);
            this.tabPage_crear.Controls.Add(this.lbl_referencia);
            this.tabPage_crear.Controls.Add(this.txtbx_departamento);
            this.tabPage_crear.Controls.Add(this.lbl_departamento);
            this.tabPage_crear.Controls.Add(this.txtbx_ciudad);
            this.tabPage_crear.Controls.Add(this.lbl_ciudad);
            this.tabPage_crear.Controls.Add(this.txtbx_no_casa);
            this.tabPage_crear.Controls.Add(this.lbl_no_casa);
            this.tabPage_crear.Controls.Add(this.txtbx_avenida);
            this.tabPage_crear.Controls.Add(this.lbl_avenida);
            this.tabPage_crear.Controls.Add(this.txtbx_calle);
            this.tabPage_crear.Controls.Add(this.lbl_calle);
            this.tabPage_crear.Controls.Add(this.date_fecha_inicio);
            this.tabPage_crear.Controls.Add(this.lbl_fecha_inicio);
            this.tabPage_crear.Controls.Add(this.date_fecha_nacimiento);
            this.tabPage_crear.Controls.Add(this.lbl_fecha_nacimiento);
            this.tabPage_crear.Controls.Add(this.txtbx_segundo_apellido);
            this.tabPage_crear.Controls.Add(this.lbl_segundo_apellido);
            this.tabPage_crear.Controls.Add(this.txtbx_primer_apellido);
            this.tabPage_crear.Controls.Add(this.lbl_primer_apellido);
            this.tabPage_crear.Controls.Add(this.txtbx_segundo_nombre);
            this.tabPage_crear.Controls.Add(this.lbl_segundo_nombre);
            this.tabPage_crear.Controls.Add(this.txtbx_primer_nombre);
            this.tabPage_crear.Controls.Add(this.lbl_primer_nombre);
            this.tabPage_crear.Controls.Add(this.txtbx_id_usuario);
            this.tabPage_crear.Controls.Add(this.lbl_id);
            this.tabPage_crear.Location = new System.Drawing.Point(4, 22);
            this.tabPage_crear.Name = "tabPage_crear";
            this.tabPage_crear.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_crear.Size = new System.Drawing.Size(745, 488);
            this.tabPage_crear.TabIndex = 0;
            this.tabPage_crear.Text = "Crear";
            this.tabPage_crear.UseVisualStyleBackColor = true;
            // 
            // bt_agregar
            // 
            this.bt_agregar.Location = new System.Drawing.Point(557, 442);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(75, 23);
            this.bt_agregar.TabIndex = 33;
            this.bt_agregar.Text = "Agregar Empleado";
            this.bt_agregar.UseVisualStyleBackColor = true;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            // 
            // lbl_datos
            // 
            this.lbl_datos.AutoSize = true;
            this.lbl_datos.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datos.Location = new System.Drawing.Point(85, 71);
            this.lbl_datos.Name = "lbl_datos";
            this.lbl_datos.Size = new System.Drawing.Size(150, 19);
            this.lbl_datos.TabIndex = 23;
            this.lbl_datos.Text = "DATOS PERSONALES";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.Location = new System.Drawing.Point(85, 267);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(85, 19);
            this.lbl_direccion.TabIndex = 22;
            this.lbl_direccion.Text = "DIRECCION";
            // 
            // txtbx_referencia
            // 
            this.txtbx_referencia.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_referencia.Location = new System.Drawing.Point(522, 397);
            this.txtbx_referencia.MaxLength = 100;
            this.txtbx_referencia.Name = "txtbx_referencia";
            this.txtbx_referencia.Size = new System.Drawing.Size(135, 27);
            this.txtbx_referencia.TabIndex = 27;
            // 
            // lbl_referencia
            // 
            this.lbl_referencia.AutoSize = true;
            this.lbl_referencia.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_referencia.Location = new System.Drawing.Point(372, 400);
            this.lbl_referencia.Name = "lbl_referencia";
            this.lbl_referencia.Size = new System.Drawing.Size(95, 19);
            this.lbl_referencia.TabIndex = 26;
            this.lbl_referencia.Text = "REFERENCIA";
            // 
            // txtbx_departamento
            // 
            this.txtbx_departamento.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_departamento.Location = new System.Drawing.Point(176, 397);
            this.txtbx_departamento.MaxLength = 40;
            this.txtbx_departamento.Name = "txtbx_departamento";
            this.txtbx_departamento.Size = new System.Drawing.Size(135, 27);
            this.txtbx_departamento.TabIndex = 25;
            // 
            // lbl_departamento
            // 
            this.lbl_departamento.AutoSize = true;
            this.lbl_departamento.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_departamento.Location = new System.Drawing.Point(23, 397);
            this.lbl_departamento.Name = "lbl_departamento";
            this.lbl_departamento.Size = new System.Drawing.Size(126, 19);
            this.lbl_departamento.TabIndex = 24;
            this.lbl_departamento.Text = "DEPARTAMENTO";
            // 
            // txtbx_ciudad
            // 
            this.txtbx_ciudad.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_ciudad.Location = new System.Drawing.Point(522, 345);
            this.txtbx_ciudad.MaxLength = 40;
            this.txtbx_ciudad.Name = "txtbx_ciudad";
            this.txtbx_ciudad.Size = new System.Drawing.Size(135, 27);
            this.txtbx_ciudad.TabIndex = 21;
            // 
            // lbl_ciudad
            // 
            this.lbl_ciudad.AutoSize = true;
            this.lbl_ciudad.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ciudad.Location = new System.Drawing.Point(372, 348);
            this.lbl_ciudad.Name = "lbl_ciudad";
            this.lbl_ciudad.Size = new System.Drawing.Size(63, 19);
            this.lbl_ciudad.TabIndex = 20;
            this.lbl_ciudad.Text = "CIUDAD";
            // 
            // txtbx_no_casa
            // 
            this.txtbx_no_casa.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_no_casa.Location = new System.Drawing.Point(176, 348);
            this.txtbx_no_casa.Mask = "00000000";
            this.txtbx_no_casa.Name = "txtbx_no_casa";
            this.txtbx_no_casa.Size = new System.Drawing.Size(135, 27);
            this.txtbx_no_casa.TabIndex = 28;
            // 
            // lbl_no_casa
            // 
            this.lbl_no_casa.AutoSize = true;
            this.lbl_no_casa.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_no_casa.Location = new System.Drawing.Point(23, 345);
            this.lbl_no_casa.Name = "lbl_no_casa";
            this.lbl_no_casa.Size = new System.Drawing.Size(114, 19);
            this.lbl_no_casa.TabIndex = 18;
            this.lbl_no_casa.Text = "NUMERO CASA";
            // 
            // txtbx_avenida
            // 
            this.txtbx_avenida.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_avenida.Location = new System.Drawing.Point(522, 298);
            this.txtbx_avenida.MaxLength = 40;
            this.txtbx_avenida.Name = "txtbx_avenida";
            this.txtbx_avenida.Size = new System.Drawing.Size(135, 27);
            this.txtbx_avenida.TabIndex = 17;
            // 
            // lbl_avenida
            // 
            this.lbl_avenida.AutoSize = true;
            this.lbl_avenida.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_avenida.Location = new System.Drawing.Point(372, 301);
            this.lbl_avenida.Name = "lbl_avenida";
            this.lbl_avenida.Size = new System.Drawing.Size(71, 19);
            this.lbl_avenida.TabIndex = 16;
            this.lbl_avenida.Text = "AVENIDA";
            // 
            // txtbx_calle
            // 
            this.txtbx_calle.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_calle.Location = new System.Drawing.Point(176, 298);
            this.txtbx_calle.MaxLength = 40;
            this.txtbx_calle.Name = "txtbx_calle";
            this.txtbx_calle.Size = new System.Drawing.Size(135, 27);
            this.txtbx_calle.TabIndex = 15;
            // 
            // lbl_calle
            // 
            this.lbl_calle.AutoSize = true;
            this.lbl_calle.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calle.Location = new System.Drawing.Point(23, 298);
            this.lbl_calle.Name = "lbl_calle";
            this.lbl_calle.Size = new System.Drawing.Size(52, 19);
            this.lbl_calle.TabIndex = 14;
            this.lbl_calle.Text = "CALLE";
            // 
            // date_fecha_inicio
            // 
            this.date_fecha_inicio.CustomFormat = "yyyy-mm-dd";
            this.date_fecha_inicio.Location = new System.Drawing.Point(495, 203);
            this.date_fecha_inicio.Name = "date_fecha_inicio";
            this.date_fecha_inicio.Size = new System.Drawing.Size(200, 20);
            this.date_fecha_inicio.TabIndex = 35;
            this.date_fecha_inicio.Value = new System.DateTime(2017, 9, 22, 1, 9, 4, 0);
            // 
            // lbl_fecha_inicio
            // 
            this.lbl_fecha_inicio.AutoSize = true;
            this.lbl_fecha_inicio.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_inicio.Location = new System.Drawing.Point(372, 203);
            this.lbl_fecha_inicio.Name = "lbl_fecha_inicio";
            this.lbl_fecha_inicio.Size = new System.Drawing.Size(100, 19);
            this.lbl_fecha_inicio.TabIndex = 12;
            this.lbl_fecha_inicio.Text = "FECHA INICIO";
            // 
            // date_fecha_nacimiento
            // 
            this.date_fecha_nacimiento.CustomFormat = "yyyy-mm-dd";
            this.date_fecha_nacimiento.Location = new System.Drawing.Point(166, 201);
            this.date_fecha_nacimiento.Name = "date_fecha_nacimiento";
            this.date_fecha_nacimiento.Size = new System.Drawing.Size(200, 20);
            this.date_fecha_nacimiento.TabIndex = 34;
            this.date_fecha_nacimiento.Value = new System.DateTime(2017, 9, 22, 1, 9, 4, 0);
            // 
            // lbl_fecha_nacimiento
            // 
            this.lbl_fecha_nacimiento.AutoSize = true;
            this.lbl_fecha_nacimiento.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_nacimiento.Location = new System.Drawing.Point(23, 200);
            this.lbl_fecha_nacimiento.Name = "lbl_fecha_nacimiento";
            this.lbl_fecha_nacimiento.Size = new System.Drawing.Size(147, 19);
            this.lbl_fecha_nacimiento.TabIndex = 10;
            this.lbl_fecha_nacimiento.Text = "FECHA NACIMIENTO";
            // 
            // txtbx_segundo_apellido
            // 
            this.txtbx_segundo_apellido.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_segundo_apellido.Location = new System.Drawing.Point(522, 149);
            this.txtbx_segundo_apellido.MaxLength = 100;
            this.txtbx_segundo_apellido.Name = "txtbx_segundo_apellido";
            this.txtbx_segundo_apellido.Size = new System.Drawing.Size(135, 27);
            this.txtbx_segundo_apellido.TabIndex = 9;
            // 
            // lbl_segundo_apellido
            // 
            this.lbl_segundo_apellido.AutoSize = true;
            this.lbl_segundo_apellido.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_segundo_apellido.Location = new System.Drawing.Point(372, 152);
            this.lbl_segundo_apellido.Name = "lbl_segundo_apellido";
            this.lbl_segundo_apellido.Size = new System.Drawing.Size(149, 19);
            this.lbl_segundo_apellido.TabIndex = 8;
            this.lbl_segundo_apellido.Text = "SEGUNDO APELLIDO";
            // 
            // txtbx_primer_apellido
            // 
            this.txtbx_primer_apellido.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_primer_apellido.Location = new System.Drawing.Point(176, 149);
            this.txtbx_primer_apellido.MaxLength = 100;
            this.txtbx_primer_apellido.Name = "txtbx_primer_apellido";
            this.txtbx_primer_apellido.Size = new System.Drawing.Size(135, 27);
            this.txtbx_primer_apellido.TabIndex = 7;
            // 
            // lbl_primer_apellido
            // 
            this.lbl_primer_apellido.AutoSize = true;
            this.lbl_primer_apellido.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_primer_apellido.Location = new System.Drawing.Point(23, 149);
            this.lbl_primer_apellido.Name = "lbl_primer_apellido";
            this.lbl_primer_apellido.Size = new System.Drawing.Size(140, 19);
            this.lbl_primer_apellido.TabIndex = 6;
            this.lbl_primer_apellido.Text = "PRIMER_APELLIDO";
            // 
            // txtbx_segundo_nombre
            // 
            this.txtbx_segundo_nombre.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_segundo_nombre.Location = new System.Drawing.Point(522, 102);
            this.txtbx_segundo_nombre.MaxLength = 100;
            this.txtbx_segundo_nombre.Name = "txtbx_segundo_nombre";
            this.txtbx_segundo_nombre.Size = new System.Drawing.Size(135, 27);
            this.txtbx_segundo_nombre.TabIndex = 5;
            // 
            // lbl_segundo_nombre
            // 
            this.lbl_segundo_nombre.AutoSize = true;
            this.lbl_segundo_nombre.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_segundo_nombre.Location = new System.Drawing.Point(372, 105);
            this.lbl_segundo_nombre.Name = "lbl_segundo_nombre";
            this.lbl_segundo_nombre.Size = new System.Drawing.Size(144, 19);
            this.lbl_segundo_nombre.TabIndex = 4;
            this.lbl_segundo_nombre.Text = "SEGUNDO NOMBRE";
            // 
            // txtbx_primer_nombre
            // 
            this.txtbx_primer_nombre.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_primer_nombre.Location = new System.Drawing.Point(176, 102);
            this.txtbx_primer_nombre.MaxLength = 100;
            this.txtbx_primer_nombre.Name = "txtbx_primer_nombre";
            this.txtbx_primer_nombre.Size = new System.Drawing.Size(135, 27);
            this.txtbx_primer_nombre.TabIndex = 3;
            // 
            // lbl_primer_nombre
            // 
            this.lbl_primer_nombre.AutoSize = true;
            this.lbl_primer_nombre.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_primer_nombre.Location = new System.Drawing.Point(23, 102);
            this.lbl_primer_nombre.Name = "lbl_primer_nombre";
            this.lbl_primer_nombre.Size = new System.Drawing.Size(135, 19);
            this.lbl_primer_nombre.TabIndex = 2;
            this.lbl_primer_nombre.Text = "PRIMER_NOMBRE";
            // 
            // txtbx_id_usuario
            // 
            this.txtbx_id_usuario.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_id_usuario.Location = new System.Drawing.Point(176, 30);
            this.txtbx_id_usuario.MaxLength = 12;
            this.txtbx_id_usuario.Name = "txtbx_id_usuario";
            this.txtbx_id_usuario.Size = new System.Drawing.Size(135, 27);
            this.txtbx_id_usuario.TabIndex = 1;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(23, 30);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(96, 19);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID_USUARIO";
            // 
            // tabPage_modificar
            // 
            this.tabPage_modificar.Location = new System.Drawing.Point(4, 22);
            this.tabPage_modificar.Name = "tabPage_modificar";
            this.tabPage_modificar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_modificar.Size = new System.Drawing.Size(745, 488);
            this.tabPage_modificar.TabIndex = 1;
            this.tabPage_modificar.Text = "Modificar";
            this.tabPage_modificar.UseVisualStyleBackColor = true;
            // 
            // tabPage_eliminar
            // 
            this.tabPage_eliminar.Controls.Add(this.lbl_usuario_borrar);
            this.tabPage_eliminar.Controls.Add(this.lbl_usuario_selected);
            this.tabPage_eliminar.Controls.Add(this.bt_eliminar);
            this.tabPage_eliminar.Controls.Add(this.bt_mostrar_eliminar);
            this.tabPage_eliminar.Controls.Add(this.grid_todos_eliminar);
            this.tabPage_eliminar.Location = new System.Drawing.Point(4, 22);
            this.tabPage_eliminar.Name = "tabPage_eliminar";
            this.tabPage_eliminar.Size = new System.Drawing.Size(745, 488);
            this.tabPage_eliminar.TabIndex = 2;
            this.tabPage_eliminar.Text = "Eliminar";
            this.tabPage_eliminar.UseVisualStyleBackColor = true;
            // 
            // lbl_usuario_borrar
            // 
            this.lbl_usuario_borrar.AutoSize = true;
            this.lbl_usuario_borrar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario_borrar.Location = new System.Drawing.Point(372, 41);
            this.lbl_usuario_borrar.Name = "lbl_usuario_borrar";
            this.lbl_usuario_borrar.Size = new System.Drawing.Size(0, 19);
            this.lbl_usuario_borrar.TabIndex = 6;
            // 
            // lbl_usuario_selected
            // 
            this.lbl_usuario_selected.AutoSize = true;
            this.lbl_usuario_selected.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario_selected.Location = new System.Drawing.Point(197, 41);
            this.lbl_usuario_selected.Name = "lbl_usuario_selected";
            this.lbl_usuario_selected.Size = new System.Drawing.Size(157, 19);
            this.lbl_usuario_selected.TabIndex = 5;
            this.lbl_usuario_selected.Text = "Usuario seleccionado:";
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_eliminar.Location = new System.Drawing.Point(568, 36);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(143, 28);
            this.bt_eliminar.TabIndex = 4;
            this.bt_eliminar.Text = "Eliminar empleado";
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // bt_mostrar_eliminar
            // 
            this.bt_mostrar_eliminar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mostrar_eliminar.Location = new System.Drawing.Point(32, 36);
            this.bt_mostrar_eliminar.Name = "bt_mostrar_eliminar";
            this.bt_mostrar_eliminar.Size = new System.Drawing.Size(159, 28);
            this.bt_mostrar_eliminar.TabIndex = 3;
            this.bt_mostrar_eliminar.Text = "Mostrar Empleados";
            this.bt_mostrar_eliminar.UseVisualStyleBackColor = true;
            this.bt_mostrar_eliminar.Click += new System.EventHandler(this.bt_mostrar_eliminar_Click);
            // 
            // grid_todos_eliminar
            // 
            this.grid_todos_eliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_todos_eliminar.Location = new System.Drawing.Point(21, 83);
            this.grid_todos_eliminar.Name = "grid_todos_eliminar";
            this.grid_todos_eliminar.Size = new System.Drawing.Size(702, 369);
            this.grid_todos_eliminar.TabIndex = 2;
            this.grid_todos_eliminar.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridTodosEliminar);
            // 
            // tabPage_empleados
            // 
            this.tabPage_empleados.Controls.Add(this.bt_mostrarEmps);
            this.tabPage_empleados.Controls.Add(this.grid_Todos);
            this.tabPage_empleados.Location = new System.Drawing.Point(4, 22);
            this.tabPage_empleados.Name = "tabPage_empleados";
            this.tabPage_empleados.Size = new System.Drawing.Size(745, 488);
            this.tabPage_empleados.TabIndex = 3;
            this.tabPage_empleados.Text = "Todos";
            this.tabPage_empleados.UseVisualStyleBackColor = true;
            // 
            // bt_mostrarEmps
            // 
            this.bt_mostrarEmps.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mostrarEmps.Location = new System.Drawing.Point(34, 34);
            this.bt_mostrarEmps.Name = "bt_mostrarEmps";
            this.bt_mostrarEmps.Size = new System.Drawing.Size(167, 28);
            this.bt_mostrarEmps.TabIndex = 1;
            this.bt_mostrarEmps.Text = "Mostrar Empleados";
            this.bt_mostrarEmps.UseVisualStyleBackColor = true;
            this.bt_mostrarEmps.Click += new System.EventHandler(this.bt_mostrarEmps_Click);
            // 
            // grid_Todos
            // 
            this.grid_Todos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Todos.Location = new System.Drawing.Point(23, 81);
            this.grid_Todos.Name = "grid_Todos";
            this.grid_Todos.Size = new System.Drawing.Size(702, 369);
            this.grid_Todos.TabIndex = 0;
            // 
            // bt_atras
            // 
            this.bt_atras.Location = new System.Drawing.Point(666, 2);
            this.bt_atras.Name = "bt_atras";
            this.bt_atras.Size = new System.Drawing.Size(78, 24);
            this.bt_atras.TabIndex = 7;
            this.bt_atras.Text = "Atras";
            this.bt_atras.UseVisualStyleBackColor = true;
            this.bt_atras.Click += new System.EventHandler(this.bt_atras_Click);
            // 
            // lbl_usuarioConectado
            // 
            this.lbl_usuarioConectado.AutoSize = true;
            this.lbl_usuarioConectado.Location = new System.Drawing.Point(195, 2);
            this.lbl_usuarioConectado.Name = "lbl_usuarioConectado";
            this.lbl_usuarioConectado.Size = new System.Drawing.Size(0, 13);
            this.lbl_usuarioConectado.TabIndex = 6;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 547);
            this.Controls.Add(this.bt_atras);
            this.Controls.Add(this.lbl_usuarioConectado);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmEmpleados";
            this.Text = "frmEmpleados";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_crear.ResumeLayout(false);
            this.tabPage_crear.PerformLayout();
            this.tabPage_eliminar.ResumeLayout(false);
            this.tabPage_eliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_todos_eliminar)).EndInit();
            this.tabPage_empleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Todos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_crear;
        private System.Windows.Forms.TabPage tabPage_modificar;
        private System.Windows.Forms.Button bt_atras;
        private System.Windows.Forms.Label lbl_usuarioConectado;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txtbx_ciudad;
        private System.Windows.Forms.Label lbl_ciudad;
        private System.Windows.Forms.Label lbl_no_casa;
        private System.Windows.Forms.TextBox txtbx_avenida;
        private System.Windows.Forms.Label lbl_avenida;
        private System.Windows.Forms.TextBox txtbx_calle;
        private System.Windows.Forms.Label lbl_calle;
        private System.Windows.Forms.Label lbl_fecha_inicio;
        private System.Windows.Forms.Label lbl_fecha_nacimiento;
        private System.Windows.Forms.TextBox txtbx_segundo_apellido;
        private System.Windows.Forms.Label lbl_segundo_apellido;
        private System.Windows.Forms.TextBox txtbx_primer_apellido;
        private System.Windows.Forms.Label lbl_primer_apellido;
        private System.Windows.Forms.TextBox txtbx_segundo_nombre;
        private System.Windows.Forms.Label lbl_segundo_nombre;
        private System.Windows.Forms.TextBox txtbx_primer_nombre;
        private System.Windows.Forms.Label lbl_primer_nombre;
        private System.Windows.Forms.TextBox txtbx_id_usuario;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TabPage tabPage_eliminar;
        private System.Windows.Forms.TabPage tabPage_empleados;
        private System.Windows.Forms.TextBox txtbx_referencia;
        private System.Windows.Forms.Label lbl_referencia;
        private System.Windows.Forms.TextBox txtbx_departamento;
        private System.Windows.Forms.Label lbl_departamento;
        private System.Windows.Forms.Label lbl_datos;
        private System.Windows.Forms.MaskedTextBox txtbx_no_casa;
        private System.Windows.Forms.DateTimePicker date_fecha_nacimiento;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.DateTimePicker date_fecha_inicio;
        private System.Windows.Forms.DataGridView grid_Todos;
        private System.Windows.Forms.Button bt_mostrarEmps;
        private System.Windows.Forms.Label lbl_usuario_borrar;
        private System.Windows.Forms.Label lbl_usuario_selected;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_mostrar_eliminar;
        private System.Windows.Forms.DataGridView grid_todos_eliminar;
    }
}