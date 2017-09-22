namespace Mi_Cooperativa_App_VS
{
    partial class frmAbonos
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
            this.bt_atras = new System.Windows.Forms.Button();
            this.lbl_usuarioConectado = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_crear = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.numberMonto = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblMonto = new System.Windows.Forms.Label();
            this.bt_verCuentas = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_crearAbono = new System.Windows.Forms.Button();
            this.date_abono = new System.Windows.Forms.DateTimePicker();
            this.lbl_abono = new System.Windows.Forms.Label();
            this.lbl_noCuenta = new System.Windows.Forms.Label();
            this.tabPage_eliminar = new System.Windows.Forms.TabPage();
            this.lbl_prestamo = new System.Windows.Forms.Label();
            this.lbl_prestamo_selected = new System.Windows.Forms.Label();
            this.lbl_pago_borrar = new System.Windows.Forms.Label();
            this.lbl_pago_selected = new System.Windows.Forms.Label();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_mostrar_eliminar = new System.Windows.Forms.Button();
            this.grid_todos_eliminar = new System.Windows.Forms.DataGridView();
            this.tabPage_modificar = new System.Windows.Forms.TabPage();
            this.tabPage_pagos = new System.Windows.Forms.TabPage();
            this.bt_mostrarAbonos = new System.Windows.Forms.Button();
            this.grid_Todos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage_crear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage_eliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_todos_eliminar)).BeginInit();
            this.tabPage_pagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Todos)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_atras
            // 
            this.bt_atras.Location = new System.Drawing.Point(559, 12);
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
            this.lbl_usuarioConectado.Location = new System.Drawing.Point(88, 12);
            this.lbl_usuarioConectado.Name = "lbl_usuarioConectado";
            this.lbl_usuarioConectado.Size = new System.Drawing.Size(0, 13);
            this.lbl_usuarioConectado.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_crear);
            this.tabControl1.Controls.Add(this.tabPage_eliminar);
            this.tabControl1.Controls.Add(this.tabPage_modificar);
            this.tabControl1.Controls.Add(this.tabPage_pagos);
            this.tabControl1.Location = new System.Drawing.Point(-1, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(651, 451);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage_crear
            // 
            this.tabPage_crear.Controls.Add(this.textBox1);
            this.tabPage_crear.Controls.Add(this.lblDescripcion);
            this.tabPage_crear.Controls.Add(this.numberMonto);
            this.tabPage_crear.Controls.Add(this.numericUpDown1);
            this.tabPage_crear.Controls.Add(this.lblMonto);
            this.tabPage_crear.Controls.Add(this.bt_verCuentas);
            this.tabPage_crear.Controls.Add(this.dataGridView1);
            this.tabPage_crear.Controls.Add(this.bt_crearAbono);
            this.tabPage_crear.Controls.Add(this.date_abono);
            this.tabPage_crear.Controls.Add(this.lbl_abono);
            this.tabPage_crear.Controls.Add(this.lbl_noCuenta);
            this.tabPage_crear.Location = new System.Drawing.Point(4, 22);
            this.tabPage_crear.Name = "tabPage_crear";
            this.tabPage_crear.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_crear.Size = new System.Drawing.Size(643, 425);
            this.tabPage_crear.TabIndex = 0;
            this.tabPage_crear.Text = "Crear";
            this.tabPage_crear.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(152, 190);
            this.textBox1.MaxLength = 100;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 60);
            this.textBox1.TabIndex = 46;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(21, 198);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(87, 19);
            this.lblDescripcion.TabIndex = 45;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // numberMonto
            // 
            this.numberMonto.DecimalPlaces = 4;
            this.numberMonto.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberMonto.Location = new System.Drawing.Point(162, 142);
            this.numberMonto.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numberMonto.Name = "numberMonto";
            this.numberMonto.Size = new System.Drawing.Size(120, 27);
            this.numberMonto.TabIndex = 44;
            this.numberMonto.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(162, 41);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown1.TabIndex = 43;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(21, 150);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(64, 19);
            this.lblMonto.TabIndex = 41;
            this.lblMonto.Text = "MONTO";
            // 
            // bt_verCuentas
            // 
            this.bt_verCuentas.Location = new System.Drawing.Point(13, 295);
            this.bt_verCuentas.Name = "bt_verCuentas";
            this.bt_verCuentas.Size = new System.Drawing.Size(136, 23);
            this.bt_verCuentas.TabIndex = 40;
            this.bt_verCuentas.Text = "Ver Cuentas";
            this.bt_verCuentas.UseVisualStyleBackColor = true;
            this.bt_verCuentas.Click += new System.EventHandler(this.bt_verCuentas_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 324);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(611, 98);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bt_crearAbono
            // 
            this.bt_crearAbono.Location = new System.Drawing.Point(469, 95);
            this.bt_crearAbono.Name = "bt_crearAbono";
            this.bt_crearAbono.Size = new System.Drawing.Size(136, 36);
            this.bt_crearAbono.TabIndex = 38;
            this.bt_crearAbono.Text = "Crear Abono";
            this.bt_crearAbono.UseVisualStyleBackColor = true;
            this.bt_crearAbono.Click += new System.EventHandler(this.bt_crearAbono_Click);
            // 
            // date_abono
            // 
            this.date_abono.Location = new System.Drawing.Point(152, 95);
            this.date_abono.Name = "date_abono";
            this.date_abono.Size = new System.Drawing.Size(206, 20);
            this.date_abono.TabIndex = 34;
            this.date_abono.UseWaitCursor = true;
            // 
            // lbl_abono
            // 
            this.lbl_abono.AutoSize = true;
            this.lbl_abono.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_abono.Location = new System.Drawing.Point(13, 95);
            this.lbl_abono.Name = "lbl_abono";
            this.lbl_abono.Size = new System.Drawing.Size(109, 19);
            this.lbl_abono.TabIndex = 32;
            this.lbl_abono.Text = "FECHA ABONO";
            // 
            // lbl_noCuenta
            // 
            this.lbl_noCuenta.AutoSize = true;
            this.lbl_noCuenta.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noCuenta.Location = new System.Drawing.Point(9, 42);
            this.lbl_noCuenta.Name = "lbl_noCuenta";
            this.lbl_noCuenta.Size = new System.Drawing.Size(96, 19);
            this.lbl_noCuenta.TabIndex = 24;
            this.lbl_noCuenta.Text = "NO_CUENTA";
            // 
            // tabPage_eliminar
            // 
            this.tabPage_eliminar.Controls.Add(this.lbl_prestamo);
            this.tabPage_eliminar.Controls.Add(this.lbl_prestamo_selected);
            this.tabPage_eliminar.Controls.Add(this.lbl_pago_borrar);
            this.tabPage_eliminar.Controls.Add(this.lbl_pago_selected);
            this.tabPage_eliminar.Controls.Add(this.bt_eliminar);
            this.tabPage_eliminar.Controls.Add(this.bt_mostrar_eliminar);
            this.tabPage_eliminar.Controls.Add(this.grid_todos_eliminar);
            this.tabPage_eliminar.Location = new System.Drawing.Point(4, 22);
            this.tabPage_eliminar.Name = "tabPage_eliminar";
            this.tabPage_eliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_eliminar.Size = new System.Drawing.Size(643, 425);
            this.tabPage_eliminar.TabIndex = 1;
            this.tabPage_eliminar.Text = "Eliminar";
            this.tabPage_eliminar.UseVisualStyleBackColor = true;
            // 
            // lbl_prestamo
            // 
            this.lbl_prestamo.AutoSize = true;
            this.lbl_prestamo.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prestamo.Location = new System.Drawing.Point(352, 37);
            this.lbl_prestamo.Name = "lbl_prestamo";
            this.lbl_prestamo.Size = new System.Drawing.Size(0, 19);
            this.lbl_prestamo.TabIndex = 13;
            // 
            // lbl_prestamo_selected
            // 
            this.lbl_prestamo_selected.AutoSize = true;
            this.lbl_prestamo_selected.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prestamo_selected.Location = new System.Drawing.Point(171, 33);
            this.lbl_prestamo_selected.Name = "lbl_prestamo_selected";
            this.lbl_prestamo_selected.Size = new System.Drawing.Size(152, 19);
            this.lbl_prestamo_selected.TabIndex = 12;
            this.lbl_prestamo_selected.Text = "Cuenta seleccionada:";
            // 
            // lbl_pago_borrar
            // 
            this.lbl_pago_borrar.AutoSize = true;
            this.lbl_pago_borrar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pago_borrar.Location = new System.Drawing.Point(352, 7);
            this.lbl_pago_borrar.Name = "lbl_pago_borrar";
            this.lbl_pago_borrar.Size = new System.Drawing.Size(0, 19);
            this.lbl_pago_borrar.TabIndex = 11;
            // 
            // lbl_pago_selected
            // 
            this.lbl_pago_selected.AutoSize = true;
            this.lbl_pago_selected.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pago_selected.Location = new System.Drawing.Point(171, 3);
            this.lbl_pago_selected.Name = "lbl_pago_selected";
            this.lbl_pago_selected.Size = new System.Drawing.Size(150, 19);
            this.lbl_pago_selected.TabIndex = 10;
            this.lbl_pago_selected.Text = "Abono seleccionado:";
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_eliminar.Location = new System.Drawing.Point(494, 24);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(143, 28);
            this.bt_eliminar.TabIndex = 9;
            this.bt_eliminar.Text = "Eliminar Abono";
            this.bt_eliminar.UseVisualStyleBackColor = true;
            // 
            // bt_mostrar_eliminar
            // 
            this.bt_mostrar_eliminar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mostrar_eliminar.Location = new System.Drawing.Point(6, 24);
            this.bt_mostrar_eliminar.Name = "bt_mostrar_eliminar";
            this.bt_mostrar_eliminar.Size = new System.Drawing.Size(159, 28);
            this.bt_mostrar_eliminar.TabIndex = 8;
            this.bt_mostrar_eliminar.Text = "Mostrar Abonos";
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
            this.tabPage_modificar.Size = new System.Drawing.Size(643, 425);
            this.tabPage_modificar.TabIndex = 2;
            this.tabPage_modificar.Text = "Modificar";
            this.tabPage_modificar.UseVisualStyleBackColor = true;
            // 
            // tabPage_pagos
            // 
            this.tabPage_pagos.Controls.Add(this.bt_mostrarAbonos);
            this.tabPage_pagos.Controls.Add(this.grid_Todos);
            this.tabPage_pagos.Location = new System.Drawing.Point(4, 22);
            this.tabPage_pagos.Name = "tabPage_pagos";
            this.tabPage_pagos.Size = new System.Drawing.Size(643, 425);
            this.tabPage_pagos.TabIndex = 3;
            this.tabPage_pagos.Text = "Pagos";
            this.tabPage_pagos.UseVisualStyleBackColor = true;
            // 
            // bt_mostrarAbonos
            // 
            this.bt_mostrarAbonos.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mostrarAbonos.Location = new System.Drawing.Point(20, 29);
            this.bt_mostrarAbonos.Name = "bt_mostrarAbonos";
            this.bt_mostrarAbonos.Size = new System.Drawing.Size(167, 28);
            this.bt_mostrarAbonos.TabIndex = 3;
            this.bt_mostrarAbonos.Text = "Mostrar Abonos";
            this.bt_mostrarAbonos.UseVisualStyleBackColor = true;
            this.bt_mostrarAbonos.Click += new System.EventHandler(this.bt_mostrarAbonos_Click);
            // 
            // grid_Todos
            // 
            this.grid_Todos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Todos.Location = new System.Drawing.Point(9, 76);
            this.grid_Todos.Name = "grid_Todos";
            this.grid_Todos.Size = new System.Drawing.Size(608, 369);
            this.grid_Todos.TabIndex = 2;
            // 
            // frmAbonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 506);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bt_atras);
            this.Controls.Add(this.lbl_usuarioConectado);
            this.Name = "frmAbonos";
            this.Text = "frmAbonos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_crear.ResumeLayout(false);
            this.tabPage_crear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage_eliminar.ResumeLayout(false);
            this.tabPage_eliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_todos_eliminar)).EndInit();
            this.tabPage_pagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Todos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_atras;
        private System.Windows.Forms.Label lbl_usuarioConectado;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_crear;
        private System.Windows.Forms.Button bt_verCuentas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_crearAbono;
        private System.Windows.Forms.DateTimePicker date_abono;
        private System.Windows.Forms.Label lbl_abono;
        private System.Windows.Forms.Label lbl_noCuenta;
        private System.Windows.Forms.TabPage tabPage_eliminar;
        private System.Windows.Forms.Label lbl_prestamo;
        private System.Windows.Forms.Label lbl_prestamo_selected;
        private System.Windows.Forms.Label lbl_pago_borrar;
        private System.Windows.Forms.Label lbl_pago_selected;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_mostrar_eliminar;
        private System.Windows.Forms.DataGridView grid_todos_eliminar;
        private System.Windows.Forms.TabPage tabPage_modificar;
        private System.Windows.Forms.TabPage tabPage_pagos;
        private System.Windows.Forms.Button bt_mostrarAbonos;
        private System.Windows.Forms.DataGridView grid_Todos;
        private System.Windows.Forms.NumericUpDown numberMonto;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDescripcion;
    }
}