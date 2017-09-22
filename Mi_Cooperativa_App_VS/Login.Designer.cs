namespace Mi_Cooperativa_App_VS
{
    partial class Login
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
            this.bt_Ingresar = new System.Windows.Forms.Button();
            this.txtBox_usuario = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.txtBox_contrasena = new System.Windows.Forms.TextBox();
            this.lbl_contrasena = new System.Windows.Forms.Label();
            this.lbl_ingresarComo = new System.Windows.Forms.Label();
            this.combo_IngresarComo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Ingresar
            // 
            this.bt_Ingresar.Location = new System.Drawing.Point(121, 254);
            this.bt_Ingresar.Name = "bt_Ingresar";
            this.bt_Ingresar.Size = new System.Drawing.Size(75, 23);
            this.bt_Ingresar.TabIndex = 0;
            this.bt_Ingresar.Text = "Ingresar";
            this.bt_Ingresar.UseVisualStyleBackColor = true;
            this.bt_Ingresar.Click += new System.EventHandler(this.bt_Ingresar_Click);
            // 
            // txtBox_usuario
            // 
            this.txtBox_usuario.Location = new System.Drawing.Point(71, 70);
            this.txtBox_usuario.Name = "txtBox_usuario";
            this.txtBox_usuario.Size = new System.Drawing.Size(175, 20);
            this.txtBox_usuario.TabIndex = 1;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(71, 51);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_usuario.TabIndex = 3;
            this.lbl_usuario.Text = "Usuario";
            // 
            // txtBox_contrasena
            // 
            this.txtBox_contrasena.Location = new System.Drawing.Point(71, 154);
            this.txtBox_contrasena.Name = "txtBox_contrasena";
            this.txtBox_contrasena.PasswordChar = '*';
            this.txtBox_contrasena.Size = new System.Drawing.Size(175, 20);
            this.txtBox_contrasena.TabIndex = 2;
            // 
            // lbl_contrasena
            // 
            this.lbl_contrasena.AutoSize = true;
            this.lbl_contrasena.Location = new System.Drawing.Point(71, 138);
            this.lbl_contrasena.Name = "lbl_contrasena";
            this.lbl_contrasena.Size = new System.Drawing.Size(61, 13);
            this.lbl_contrasena.TabIndex = 4;
            this.lbl_contrasena.Text = "Contraseña";
            // 
            // lbl_ingresarComo
            // 
            this.lbl_ingresarComo.AutoSize = true;
            this.lbl_ingresarComo.Location = new System.Drawing.Point(68, 196);
            this.lbl_ingresarComo.Name = "lbl_ingresarComo";
            this.lbl_ingresarComo.Size = new System.Drawing.Size(77, 13);
            this.lbl_ingresarComo.TabIndex = 5;
            this.lbl_ingresarComo.Text = "Ingresar como:";
            // 
            // combo_IngresarComo
            // 
            this.combo_IngresarComo.FormattingEnabled = true;
            this.combo_IngresarComo.Items.AddRange(new object[] {
            "Administrador",
            "Afiliado"});
            this.combo_IngresarComo.Location = new System.Drawing.Point(71, 224);
            this.combo_IngresarComo.Name = "combo_IngresarComo";
            this.combo_IngresarComo.Size = new System.Drawing.Size(121, 21);
            this.combo_IngresarComo.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 317);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.combo_IngresarComo);
            this.Controls.Add(this.lbl_ingresarComo);
            this.Controls.Add(this.lbl_contrasena);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.txtBox_contrasena);
            this.Controls.Add(this.txtBox_usuario);
            this.Controls.Add(this.bt_Ingresar);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Ingresar;
        private System.Windows.Forms.TextBox txtBox_usuario;
        private System.Windows.Forms.TextBox txtBox_contrasena;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_contrasena;
        private System.Windows.Forms.Label lbl_ingresarComo;
        private System.Windows.Forms.ComboBox combo_IngresarComo;
        private System.Windows.Forms.Button button1;
    }
}