namespace Mi_Cooperativa_App_VS
{
    partial class Cooperativa
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
            this.bt_usuarios = new System.Windows.Forms.Button();
            this.bt_empleados = new System.Windows.Forms.Button();
            this.bt_cuentas = new System.Windows.Forms.Button();
            this.bt_prestamos = new System.Windows.Forms.Button();
            this.lbl_usuarioConectado = new System.Windows.Forms.Label();
            this.bt_logout = new System.Windows.Forms.Button();
            this.btPrivilegios = new System.Windows.Forms.Button();
            this.btRoles = new System.Windows.Forms.Button();
            this.btRolesPrivilegios = new System.Windows.Forms.Button();
            this.btUsuariosRoles = new System.Windows.Forms.Button();
            this.btAbonos = new System.Windows.Forms.Button();
            this.btPagos = new System.Windows.Forms.Button();
            this.btCierre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_usuarios
            // 
            this.bt_usuarios.Location = new System.Drawing.Point(51, 110);
            this.bt_usuarios.Name = "bt_usuarios";
            this.bt_usuarios.Size = new System.Drawing.Size(153, 44);
            this.bt_usuarios.TabIndex = 0;
            this.bt_usuarios.Text = "Usuarios";
            this.bt_usuarios.UseVisualStyleBackColor = true;
            this.bt_usuarios.Click += new System.EventHandler(this.bt_usuarios_Click);
            // 
            // bt_empleados
            // 
            this.bt_empleados.Location = new System.Drawing.Point(236, 110);
            this.bt_empleados.Name = "bt_empleados";
            this.bt_empleados.Size = new System.Drawing.Size(153, 44);
            this.bt_empleados.TabIndex = 1;
            this.bt_empleados.Text = "Empleados";
            this.bt_empleados.UseVisualStyleBackColor = true;
            this.bt_empleados.Click += new System.EventHandler(this.bt_empleados_Click);
            // 
            // bt_cuentas
            // 
            this.bt_cuentas.Location = new System.Drawing.Point(236, 188);
            this.bt_cuentas.Name = "bt_cuentas";
            this.bt_cuentas.Size = new System.Drawing.Size(153, 44);
            this.bt_cuentas.TabIndex = 3;
            this.bt_cuentas.Text = "Cuentas";
            this.bt_cuentas.UseVisualStyleBackColor = true;
            this.bt_cuentas.Click += new System.EventHandler(this.bt_cuentas_Click);
            // 
            // bt_prestamos
            // 
            this.bt_prestamos.Location = new System.Drawing.Point(51, 188);
            this.bt_prestamos.Name = "bt_prestamos";
            this.bt_prestamos.Size = new System.Drawing.Size(153, 44);
            this.bt_prestamos.TabIndex = 2;
            this.bt_prestamos.Text = "Prestamos";
            this.bt_prestamos.UseVisualStyleBackColor = true;
            this.bt_prestamos.Click += new System.EventHandler(this.bt_prestamos_Click);
            // 
            // lbl_usuarioConectado
            // 
            this.lbl_usuarioConectado.AutoSize = true;
            this.lbl_usuarioConectado.Location = new System.Drawing.Point(51, 13);
            this.lbl_usuarioConectado.Name = "lbl_usuarioConectado";
            this.lbl_usuarioConectado.Size = new System.Drawing.Size(0, 13);
            this.lbl_usuarioConectado.TabIndex = 4;
            // 
            // bt_logout
            // 
            this.bt_logout.Location = new System.Drawing.Point(346, 13);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(78, 24);
            this.bt_logout.TabIndex = 5;
            this.bt_logout.Text = "Cerrar Sesion";
            this.bt_logout.UseVisualStyleBackColor = true;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // btPrivilegios
            // 
            this.btPrivilegios.Location = new System.Drawing.Point(236, 317);
            this.btPrivilegios.Name = "btPrivilegios";
            this.btPrivilegios.Size = new System.Drawing.Size(153, 44);
            this.btPrivilegios.TabIndex = 7;
            this.btPrivilegios.Text = "Privilegios";
            this.btPrivilegios.UseVisualStyleBackColor = true;
            this.btPrivilegios.Click += new System.EventHandler(this.btPrivilegios_Click);
            // 
            // btRoles
            // 
            this.btRoles.Location = new System.Drawing.Point(51, 317);
            this.btRoles.Name = "btRoles";
            this.btRoles.Size = new System.Drawing.Size(153, 44);
            this.btRoles.TabIndex = 6;
            this.btRoles.Text = "Roles";
            this.btRoles.UseVisualStyleBackColor = true;
            this.btRoles.Click += new System.EventHandler(this.btRoles_Click);
            // 
            // btRolesPrivilegios
            // 
            this.btRolesPrivilegios.Location = new System.Drawing.Point(236, 387);
            this.btRolesPrivilegios.Name = "btRolesPrivilegios";
            this.btRolesPrivilegios.Size = new System.Drawing.Size(153, 44);
            this.btRolesPrivilegios.TabIndex = 8;
            this.btRolesPrivilegios.Text = "Roles y Privilegios";
            this.btRolesPrivilegios.UseVisualStyleBackColor = true;
            this.btRolesPrivilegios.Click += new System.EventHandler(this.btRolesPrivilegios_Click);
            // 
            // btUsuariosRoles
            // 
            this.btUsuariosRoles.Location = new System.Drawing.Point(54, 387);
            this.btUsuariosRoles.Name = "btUsuariosRoles";
            this.btUsuariosRoles.Size = new System.Drawing.Size(153, 44);
            this.btUsuariosRoles.TabIndex = 9;
            this.btUsuariosRoles.Text = "Usuario y sus Roles";
            this.btUsuariosRoles.UseVisualStyleBackColor = true;
            this.btUsuariosRoles.Click += new System.EventHandler(this.btUsuariosRoles_Click);
            // 
            // btAbonos
            // 
            this.btAbonos.Location = new System.Drawing.Point(236, 252);
            this.btAbonos.Name = "btAbonos";
            this.btAbonos.Size = new System.Drawing.Size(153, 44);
            this.btAbonos.TabIndex = 11;
            this.btAbonos.Text = "Abonos";
            this.btAbonos.UseVisualStyleBackColor = true;
            this.btAbonos.Click += new System.EventHandler(this.btAbonos_Click);
            // 
            // btPagos
            // 
            this.btPagos.Location = new System.Drawing.Point(51, 252);
            this.btPagos.Name = "btPagos";
            this.btPagos.Size = new System.Drawing.Size(153, 44);
            this.btPagos.TabIndex = 10;
            this.btPagos.Text = "Pagos";
            this.btPagos.UseVisualStyleBackColor = true;
            this.btPagos.Click += new System.EventHandler(this.btPagos_Click);
            // 
            // btCierre
            // 
            this.btCierre.Location = new System.Drawing.Point(184, 464);
            this.btCierre.Name = "btCierre";
            this.btCierre.Size = new System.Drawing.Size(75, 23);
            this.btCierre.TabIndex = 12;
            this.btCierre.Text = "Cierre Mensual";
            this.btCierre.UseVisualStyleBackColor = true;
            this.btCierre.Click += new System.EventHandler(this.btCierre_Click);
            // 
            // Cooperativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 499);
            this.Controls.Add(this.btCierre);
            this.Controls.Add(this.btAbonos);
            this.Controls.Add(this.btPagos);
            this.Controls.Add(this.btUsuariosRoles);
            this.Controls.Add(this.btRolesPrivilegios);
            this.Controls.Add(this.btPrivilegios);
            this.Controls.Add(this.btRoles);
            this.Controls.Add(this.bt_logout);
            this.Controls.Add(this.lbl_usuarioConectado);
            this.Controls.Add(this.bt_cuentas);
            this.Controls.Add(this.bt_prestamos);
            this.Controls.Add(this.bt_empleados);
            this.Controls.Add(this.bt_usuarios);
            this.Name = "Cooperativa";
            this.Text = "Mi Cooperativa";
            this.Load += new System.EventHandler(this.Cooperativa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_usuarios;
        private System.Windows.Forms.Button bt_empleados;
        private System.Windows.Forms.Button bt_cuentas;
        private System.Windows.Forms.Button bt_prestamos;
        private System.Windows.Forms.Label lbl_usuarioConectado;
        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Button btPrivilegios;
        private System.Windows.Forms.Button btRoles;
        private System.Windows.Forms.Button btRolesPrivilegios;
        private System.Windows.Forms.Button btUsuariosRoles;
        private System.Windows.Forms.Button btAbonos;
        private System.Windows.Forms.Button btPagos;
        private System.Windows.Forms.Button btCierre;
    }
}

