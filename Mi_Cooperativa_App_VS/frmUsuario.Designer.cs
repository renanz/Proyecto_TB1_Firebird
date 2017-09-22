namespace Mi_Cooperativa_App_VS
{
    partial class frmUsuario
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
            this.bt_crearUsuario = new System.Windows.Forms.Button();
            this.txtbx_id_usuario = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.tabPage_eliminar = new System.Windows.Forms.TabPage();
            this.lbl_cuenta_borrar = new System.Windows.Forms.Label();
            this.lbl_usuario_selected = new System.Windows.Forms.Label();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_mostrar_eliminar = new System.Windows.Forms.Button();
            this.grid_todos_eliminar = new System.Windows.Forms.DataGridView();
            this.tabPage_modificar = new System.Windows.Forms.TabPage();
            this.tabPage_usuarios = new System.Windows.Forms.TabPage();
            this.bt_mostrarUsuarios = new System.Windows.Forms.Button();
            this.grid_Todos = new System.Windows.Forms.DataGridView();
            this.txtBx_contrasena = new System.Windows.Forms.TextBox();
            this.lbl_contrasena = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage_crear.SuspendLayout();
            this.tabPage_eliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_todos_eliminar)).BeginInit();
            this.tabPage_usuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Todos)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_atras
            // 
            this.bt_atras.Location = new System.Drawing.Point(250, 1);
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
            this.lbl_usuarioConectado.Location = new System.Drawing.Point(13, 12);
            this.lbl_usuarioConectado.Name = "lbl_usuarioConectado";
            this.lbl_usuarioConectado.Size = new System.Drawing.Size(0, 13);
            this.lbl_usuarioConectado.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_crear);
            this.tabControl1.Controls.Add(this.tabPage_eliminar);
            this.tabControl1.Controls.Add(this.tabPage_modificar);
            this.tabControl1.Controls.Add(this.tabPage_usuarios);
            this.tabControl1.Location = new System.Drawing.Point(-3, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(331, 380);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage_crear
            // 
            this.tabPage_crear.Controls.Add(this.txtBx_contrasena);
            this.tabPage_crear.Controls.Add(this.lbl_contrasena);
            this.tabPage_crear.Controls.Add(this.bt_crearUsuario);
            this.tabPage_crear.Controls.Add(this.txtbx_id_usuario);
            this.tabPage_crear.Controls.Add(this.lbl_id);
            this.tabPage_crear.Location = new System.Drawing.Point(4, 22);
            this.tabPage_crear.Name = "tabPage_crear";
            this.tabPage_crear.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_crear.Size = new System.Drawing.Size(323, 354);
            this.tabPage_crear.TabIndex = 0;
            this.tabPage_crear.Text = "Crear";
            this.tabPage_crear.UseVisualStyleBackColor = true;
            // 
            // bt_crearUsuario
            // 
            this.bt_crearUsuario.Location = new System.Drawing.Point(86, 286);
            this.bt_crearUsuario.Name = "bt_crearUsuario";
            this.bt_crearUsuario.Size = new System.Drawing.Size(136, 36);
            this.bt_crearUsuario.TabIndex = 38;
            this.bt_crearUsuario.Text = "Crear Usuario";
            this.bt_crearUsuario.UseVisualStyleBackColor = true;
            this.bt_crearUsuario.Click += new System.EventHandler(this.bt_crearUsuario_Click);
            // 
            // txtbx_id_usuario
            // 
            this.txtbx_id_usuario.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_id_usuario.Location = new System.Drawing.Point(169, 96);
            this.txtbx_id_usuario.MaxLength = 12;
            this.txtbx_id_usuario.Name = "txtbx_id_usuario";
            this.txtbx_id_usuario.Size = new System.Drawing.Size(135, 27);
            this.txtbx_id_usuario.TabIndex = 25;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(16, 99);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(96, 19);
            this.lbl_id.TabIndex = 24;
            this.lbl_id.Text = "ID_USUARIO";
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
            this.tabPage_eliminar.Size = new System.Drawing.Size(323, 354);
            this.tabPage_eliminar.TabIndex = 1;
            this.tabPage_eliminar.Text = "Eliminar";
            this.tabPage_eliminar.UseVisualStyleBackColor = true;
            // 
            // lbl_cuenta_borrar
            // 
            this.lbl_cuenta_borrar.AutoSize = true;
            this.lbl_cuenta_borrar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cuenta_borrar.Location = new System.Drawing.Point(194, 96);
            this.lbl_cuenta_borrar.Name = "lbl_cuenta_borrar";
            this.lbl_cuenta_borrar.Size = new System.Drawing.Size(0, 19);
            this.lbl_cuenta_borrar.TabIndex = 11;
            // 
            // lbl_usuario_selected
            // 
            this.lbl_usuario_selected.AutoSize = true;
            this.lbl_usuario_selected.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario_selected.Location = new System.Drawing.Point(13, 92);
            this.lbl_usuario_selected.Name = "lbl_usuario_selected";
            this.lbl_usuario_selected.Size = new System.Drawing.Size(157, 19);
            this.lbl_usuario_selected.TabIndex = 10;
            this.lbl_usuario_selected.Text = "Usuario seleccionado:";
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_eliminar.Location = new System.Drawing.Point(160, 24);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(133, 28);
            this.bt_eliminar.TabIndex = 9;
            this.bt_eliminar.Text = "Eliminar Usuario";
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // bt_mostrar_eliminar
            // 
            this.bt_mostrar_eliminar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mostrar_eliminar.Location = new System.Drawing.Point(6, 24);
            this.bt_mostrar_eliminar.Name = "bt_mostrar_eliminar";
            this.bt_mostrar_eliminar.Size = new System.Drawing.Size(143, 28);
            this.bt_mostrar_eliminar.TabIndex = 8;
            this.bt_mostrar_eliminar.Text = "Mostrar Usuarios";
            this.bt_mostrar_eliminar.UseVisualStyleBackColor = true;
            this.bt_mostrar_eliminar.Click += new System.EventHandler(this.bt_mostrar_eliminar_Click);
            // 
            // grid_todos_eliminar
            // 
            this.grid_todos_eliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_todos_eliminar.Location = new System.Drawing.Point(8, 123);
            this.grid_todos_eliminar.Name = "grid_todos_eliminar";
            this.grid_todos_eliminar.Size = new System.Drawing.Size(309, 225);
            this.grid_todos_eliminar.TabIndex = 7;
            this.grid_todos_eliminar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_todos_eliminar_CellContentClick);
            // 
            // tabPage_modificar
            // 
            this.tabPage_modificar.Location = new System.Drawing.Point(4, 22);
            this.tabPage_modificar.Name = "tabPage_modificar";
            this.tabPage_modificar.Size = new System.Drawing.Size(323, 354);
            this.tabPage_modificar.TabIndex = 2;
            this.tabPage_modificar.Text = "Modificar";
            this.tabPage_modificar.UseVisualStyleBackColor = true;
            // 
            // tabPage_usuarios
            // 
            this.tabPage_usuarios.Controls.Add(this.bt_mostrarUsuarios);
            this.tabPage_usuarios.Controls.Add(this.grid_Todos);
            this.tabPage_usuarios.Location = new System.Drawing.Point(4, 22);
            this.tabPage_usuarios.Name = "tabPage_usuarios";
            this.tabPage_usuarios.Size = new System.Drawing.Size(323, 354);
            this.tabPage_usuarios.TabIndex = 3;
            this.tabPage_usuarios.Text = "Usuarios";
            this.tabPage_usuarios.UseVisualStyleBackColor = true;
            // 
            // bt_mostrarUsuarios
            // 
            this.bt_mostrarUsuarios.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mostrarUsuarios.Location = new System.Drawing.Point(20, 29);
            this.bt_mostrarUsuarios.Name = "bt_mostrarUsuarios";
            this.bt_mostrarUsuarios.Size = new System.Drawing.Size(167, 28);
            this.bt_mostrarUsuarios.TabIndex = 3;
            this.bt_mostrarUsuarios.Text = "Mostrar Usuarios";
            this.bt_mostrarUsuarios.UseVisualStyleBackColor = true;
            this.bt_mostrarUsuarios.Click += new System.EventHandler(this.bt_mostrarUsuarios_Click);
            // 
            // grid_Todos
            // 
            this.grid_Todos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Todos.Location = new System.Drawing.Point(9, 76);
            this.grid_Todos.Name = "grid_Todos";
            this.grid_Todos.Size = new System.Drawing.Size(310, 273);
            this.grid_Todos.TabIndex = 2;
            // 
            // txtBx_contrasena
            // 
            this.txtBx_contrasena.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx_contrasena.Location = new System.Drawing.Point(170, 164);
            this.txtBx_contrasena.MaxLength = 100;
            this.txtBx_contrasena.Name = "txtBx_contrasena";
            this.txtBx_contrasena.PasswordChar = '*';
            this.txtBx_contrasena.Size = new System.Drawing.Size(135, 27);
            this.txtBx_contrasena.TabIndex = 40;
            // 
            // lbl_contrasena
            // 
            this.lbl_contrasena.AutoSize = true;
            this.lbl_contrasena.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contrasena.Location = new System.Drawing.Point(17, 167);
            this.lbl_contrasena.Name = "lbl_contrasena";
            this.lbl_contrasena.Size = new System.Drawing.Size(105, 19);
            this.lbl_contrasena.TabIndex = 39;
            this.lbl_contrasena.Text = "CONTRASEÑA";
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 424);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bt_atras);
            this.Controls.Add(this.lbl_usuarioConectado);
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_crear.ResumeLayout(false);
            this.tabPage_crear.PerformLayout();
            this.tabPage_eliminar.ResumeLayout(false);
            this.tabPage_eliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_todos_eliminar)).EndInit();
            this.tabPage_usuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Todos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_atras;
        private System.Windows.Forms.Label lbl_usuarioConectado;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_crear;
        private System.Windows.Forms.Button bt_crearUsuario;
        private System.Windows.Forms.TextBox txtbx_id_usuario;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TabPage tabPage_eliminar;
        private System.Windows.Forms.Label lbl_cuenta_borrar;
        private System.Windows.Forms.Label lbl_usuario_selected;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_mostrar_eliminar;
        private System.Windows.Forms.DataGridView grid_todos_eliminar;
        private System.Windows.Forms.TabPage tabPage_modificar;
        private System.Windows.Forms.TabPage tabPage_usuarios;
        private System.Windows.Forms.Button bt_mostrarUsuarios;
        private System.Windows.Forms.DataGridView grid_Todos;
        private System.Windows.Forms.TextBox txtBx_contrasena;
        private System.Windows.Forms.Label lbl_contrasena;
    }
}