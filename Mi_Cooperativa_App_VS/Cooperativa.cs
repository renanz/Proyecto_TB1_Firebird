using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using Dapper;
using System.Diagnostics;

namespace Mi_Cooperativa_App_VS
{
    public partial class Cooperativa : Form
    {
        private Usuario _user;
        private Login _login;
        public Cooperativa(Usuario u,Login l)
        {
            _user = u;
            _login = l;
            InitializeComponent();
            lbl_usuarioConectado.Text = "Usuario conectado: " + _user.Id_usuario;
        }

        private void bt_usuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuario us = new frmUsuario(_user, this);
            us.Show();
        }

        private void bt_empleados_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmpleados emp = new frmEmpleados(_user, this);
            emp.Show();
        }

        private void bt_cuentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCuenta cta = new frmCuenta(_user, this);
            cta.Show();
        }

        private void bt_prestamos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrestamos ptmo = new frmPrestamos(_user, this);
            ptmo.Show();
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            _login.Show();
        }
         
        private void Cooperativa_Load(object sender, EventArgs e)
        {
            
        }

        private void btPagos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPagos pagos = new frmPagos(_user, this);
            pagos.Show();
        }

        private void btAbonos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAbonos abonos = new frmAbonos(_user, this);
            abonos.Show();
        }

        private void btRoles_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRoles roles = new frmRoles(_user, this);
            roles.Show();
        }

        private void btPrivilegios_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrivilegios priv = new frmPrivilegios(_user, this);
            priv.Show();
        }

        private void btUsuariosRoles_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuariosRoles ur = new frmUsuariosRoles(_user, this);
            ur.Show();
        }

        private void btRolesPrivilegios_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRolesProvilegios rp = new frmRolesProvilegios(_user, this);
            rp.Show();
        }

        private void btCierre_Click(object sender, EventArgs e)
        {
            FbCommand cmd = null;
            try
            {
                if (_user.conexion != null && _user.conexion.State == ConnectionState.Closed)
                    _user.conexion.Open();
                cmd = new FbCommand();
                cmd.Connection = _user.conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_cierre";

                //cmd.ExecuteNonQuery();
                cmd.Dispose();
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                if (_user.conexion != null && _user.conexion.State != ConnectionState.Closed)
                    _user.conexion.Close();
            }
        }
    }
}
