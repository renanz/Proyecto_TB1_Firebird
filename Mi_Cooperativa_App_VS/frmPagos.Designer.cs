namespace Mi_Cooperativa_App_VS
{
    partial class frmPagos
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
            this.bt_verPrestamos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_crearPago = new System.Windows.Forms.Button();
            this.date_pago = new System.Windows.Forms.DateTimePicker();
            this.lbl_PAGO = new System.Windows.Forms.Label();
            this.txtbx_no_prestamo = new System.Windows.Forms.TextBox();
            this.lbl_ptmo = new System.Windows.Forms.Label();
            this.tabPage_eliminar = new System.Windows.Forms.TabPage();
            this.lbl_pago_borrar = new System.Windows.Forms.Label();
            this.lbl_pago_selected = new System.Windows.Forms.Label();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_mostrar_eliminar = new System.Windows.Forms.Button();
            this.grid_todos_eliminar = new System.Windows.Forms.DataGridView();
            this.tabPage_modificar = new System.Windows.Forms.TabPage();
            this.tabPage_pagos = new System.Windows.Forms.TabPage();
            this.bt_mostrarPagos = new System.Windows.Forms.Button();
            this.grid_Todos = new System.Windows.Forms.DataGridView();
            this.lbl_prestamo = new System.Windows.Forms.Label();
            this.lbl_prestamo_selected = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage_crear.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(-1, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(651, 451);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage_crear
            // 
            this.tabPage_crear.Controls.Add(this.bt_verPrestamos);
            this.tabPage_crear.Controls.Add(this.dataGridView1);
            this.tabPage_crear.Controls.Add(this.bt_crearPago);
            this.tabPage_crear.Controls.Add(this.date_pago);
            this.tabPage_crear.Controls.Add(this.lbl_PAGO);
            this.tabPage_crear.Controls.Add(this.txtbx_no_prestamo);
            this.tabPage_crear.Controls.Add(this.lbl_ptmo);
            this.tabPage_crear.Location = new System.Drawing.Point(4, 22);
            this.tabPage_crear.Name = "tabPage_crear";
            this.tabPage_crear.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_crear.Size = new System.Drawing.Size(643, 425);
            this.tabPage_crear.TabIndex = 0;
            this.tabPage_crear.Text = "Crear";
            this.tabPage_crear.UseVisualStyleBackColor = true;
            // 
            // bt_verPrestamos
            // 
            this.bt_verPrestamos.Location = new System.Drawing.Point(13, 295);
            this.bt_verPrestamos.Name = "bt_verPrestamos";
            this.bt_verPrestamos.Size = new System.Drawing.Size(136, 23);
            this.bt_verPrestamos.TabIndex = 40;
            this.bt_verPrestamos.Text = "Ver Prestamos";
            this.bt_verPrestamos.UseVisualStyleBackColor = true;
            this.bt_verPrestamos.Click += new System.EventHandler(this.bt_verPrestamos_Click);
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
            // bt_crearPago
            // 
            this.bt_crearPago.Location = new System.Drawing.Point(74, 143);
            this.bt_crearPago.Name = "bt_crearPago";
            this.bt_crearPago.Size = new System.Drawing.Size(136, 36);
            this.bt_crearPago.TabIndex = 38;
            this.bt_crearPago.Text = "Crear Pago";
            this.bt_crearPago.UseVisualStyleBackColor = true;
            this.bt_crearPago.Click += new System.EventHandler(this.bt_crearPago_Click);
            // 
            // date_pago
            // 
            this.date_pago.Location = new System.Drawing.Point(152, 95);
            this.date_pago.Name = "date_pago";
            this.date_pago.Size = new System.Drawing.Size(206, 20);
            this.date_pago.TabIndex = 34;
            this.date_pago.UseWaitCursor = true;
            // 
            // lbl_PAGO
            // 
            this.lbl_PAGO.AutoSize = true;
            this.lbl_PAGO.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PAGO.Location = new System.Drawing.Point(13, 95);
            this.lbl_PAGO.Name = "lbl_PAGO";
            this.lbl_PAGO.Size = new System.Drawing.Size(97, 19);
            this.lbl_PAGO.TabIndex = 32;
            this.lbl_PAGO.Text = "FECHA PAGO";
            // 
            // txtbx_no_prestamo
            // 
            this.txtbx_no_prestamo.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_no_prestamo.Location = new System.Drawing.Point(162, 39);
            this.txtbx_no_prestamo.MaxLength = 12;
            this.txtbx_no_prestamo.Name = "txtbx_no_prestamo";
            this.txtbx_no_prestamo.Size = new System.Drawing.Size(135, 27);
            this.txtbx_no_prestamo.TabIndex = 25;
            // 
            // lbl_ptmo
            // 
            this.lbl_ptmo.AutoSize = true;
            this.lbl_ptmo.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ptmo.Location = new System.Drawing.Point(9, 42);
            this.lbl_ptmo.Name = "lbl_ptmo";
            this.lbl_ptmo.Size = new System.Drawing.Size(117, 19);
            this.lbl_ptmo.TabIndex = 24;
            this.lbl_ptmo.Text = "NO_PRESTAMO";
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
            this.lbl_pago_selected.Size = new System.Drawing.Size(139, 19);
            this.lbl_pago_selected.TabIndex = 10;
            this.lbl_pago_selected.Text = "Pago seleccionado:";
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_eliminar.Location = new System.Drawing.Point(494, 24);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(143, 28);
            this.bt_eliminar.TabIndex = 9;
            this.bt_eliminar.Text = "Eliminar Pago";
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
            this.bt_mostrar_eliminar.Text = "Mostrar Pagos";
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
            this.tabPage_pagos.Controls.Add(this.bt_mostrarPagos);
            this.tabPage_pagos.Controls.Add(this.grid_Todos);
            this.tabPage_pagos.Location = new System.Drawing.Point(4, 22);
            this.tabPage_pagos.Name = "tabPage_pagos";
            this.tabPage_pagos.Size = new System.Drawing.Size(643, 425);
            this.tabPage_pagos.TabIndex = 3;
            this.tabPage_pagos.Text = "Pagos";
            this.tabPage_pagos.UseVisualStyleBackColor = true;
            // 
            // bt_mostrarPagos
            // 
            this.bt_mostrarPagos.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mostrarPagos.Location = new System.Drawing.Point(20, 29);
            this.bt_mostrarPagos.Name = "bt_mostrarPagos";
            this.bt_mostrarPagos.Size = new System.Drawing.Size(167, 28);
            this.bt_mostrarPagos.TabIndex = 3;
            this.bt_mostrarPagos.Text = "Mostrar Pagos";
            this.bt_mostrarPagos.UseVisualStyleBackColor = true;
            this.bt_mostrarPagos.Click += new System.EventHandler(this.bt_mostrarPagos_Click);
            // 
            // grid_Todos
            // 
            this.grid_Todos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Todos.Location = new System.Drawing.Point(9, 76);
            this.grid_Todos.Name = "grid_Todos";
            this.grid_Todos.Size = new System.Drawing.Size(608, 369);
            this.grid_Todos.TabIndex = 2;
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
            this.lbl_prestamo_selected.Size = new System.Drawing.Size(169, 19);
            this.lbl_prestamo_selected.TabIndex = 12;
            this.lbl_prestamo_selected.Text = "Prestamo seleccionada:";
            // 
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 506);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bt_atras);
            this.Controls.Add(this.lbl_usuarioConectado);
            this.Name = "frmPagos";
            this.Text = "frmPagos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_crear.ResumeLayout(false);
            this.tabPage_crear.PerformLayout();
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
        private System.Windows.Forms.Button bt_verPrestamos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_crearPago;
        private System.Windows.Forms.DateTimePicker date_pago;
        private System.Windows.Forms.Label lbl_PAGO;
        private System.Windows.Forms.TextBox txtbx_no_prestamo;
        private System.Windows.Forms.Label lbl_ptmo;
        private System.Windows.Forms.TabPage tabPage_eliminar;
        private System.Windows.Forms.Label lbl_pago_borrar;
        private System.Windows.Forms.Label lbl_pago_selected;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_mostrar_eliminar;
        private System.Windows.Forms.DataGridView grid_todos_eliminar;
        private System.Windows.Forms.TabPage tabPage_modificar;
        private System.Windows.Forms.TabPage tabPage_pagos;
        private System.Windows.Forms.Button bt_mostrarPagos;
        private System.Windows.Forms.DataGridView grid_Todos;
        private System.Windows.Forms.Label lbl_prestamo;
        private System.Windows.Forms.Label lbl_prestamo_selected;
    }
}