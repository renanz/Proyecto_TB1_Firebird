namespace Mi_Cooperativa_App_VS
{
    partial class Afiliado
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
            this.grid_cuentas = new System.Windows.Forms.DataGridView();
            this.bt_logout = new System.Windows.Forms.Button();
            this.lbl_usuarioConectado = new System.Windows.Forms.Label();
            this.grid_prestamos = new System.Windows.Forms.DataGridView();
            this.lbl_cuentas = new System.Windows.Forms.Label();
            this.lbl_prestamos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_prestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_cuentas
            // 
            this.grid_cuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_cuentas.Location = new System.Drawing.Point(31, 164);
            this.grid_cuentas.Name = "grid_cuentas";
            this.grid_cuentas.Size = new System.Drawing.Size(395, 87);
            this.grid_cuentas.TabIndex = 1;
            // 
            // bt_logout
            // 
            this.bt_logout.Location = new System.Drawing.Point(348, 12);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(78, 24);
            this.bt_logout.TabIndex = 7;
            this.bt_logout.Text = "Cerrar Sesion";
            this.bt_logout.UseVisualStyleBackColor = true;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // lbl_usuarioConectado
            // 
            this.lbl_usuarioConectado.AutoSize = true;
            this.lbl_usuarioConectado.Location = new System.Drawing.Point(53, 12);
            this.lbl_usuarioConectado.Name = "lbl_usuarioConectado";
            this.lbl_usuarioConectado.Size = new System.Drawing.Size(0, 13);
            this.lbl_usuarioConectado.TabIndex = 6;
            // 
            // grid_prestamos
            // 
            this.grid_prestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_prestamos.Location = new System.Drawing.Point(31, 315);
            this.grid_prestamos.Name = "grid_prestamos";
            this.grid_prestamos.Size = new System.Drawing.Size(395, 87);
            this.grid_prestamos.TabIndex = 8;
            // 
            // lbl_cuentas
            // 
            this.lbl_cuentas.AutoSize = true;
            this.lbl_cuentas.Location = new System.Drawing.Point(31, 145);
            this.lbl_cuentas.Name = "lbl_cuentas";
            this.lbl_cuentas.Size = new System.Drawing.Size(46, 13);
            this.lbl_cuentas.TabIndex = 9;
            this.lbl_cuentas.Text = "Cuentas";
            // 
            // lbl_prestamos
            // 
            this.lbl_prestamos.AutoSize = true;
            this.lbl_prestamos.Location = new System.Drawing.Point(31, 299);
            this.lbl_prestamos.Name = "lbl_prestamos";
            this.lbl_prestamos.Size = new System.Drawing.Size(56, 13);
            this.lbl_prestamos.TabIndex = 10;
            this.lbl_prestamos.Text = "Prestamos";
            // 
            // Afiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 458);
            this.Controls.Add(this.lbl_prestamos);
            this.Controls.Add(this.lbl_cuentas);
            this.Controls.Add(this.grid_prestamos);
            this.Controls.Add(this.bt_logout);
            this.Controls.Add(this.lbl_usuarioConectado);
            this.Controls.Add(this.grid_cuentas);
            this.Name = "Afiliado";
            this.Text = "Afiliado";
            this.Load += new System.EventHandler(this.Afiliado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_cuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_prestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_cuentas;
        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Label lbl_usuarioConectado;
        private System.Windows.Forms.DataGridView grid_prestamos;
        private System.Windows.Forms.Label lbl_cuentas;
        private System.Windows.Forms.Label lbl_prestamos;
    }
}