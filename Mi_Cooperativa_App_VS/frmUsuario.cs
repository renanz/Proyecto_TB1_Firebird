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
using System.Data;
using System.Diagnostics;

namespace Mi_Cooperativa_App_VS
{
    public partial class frmUsuario : Form
    {
        private Usuario _usuario;
        private Cooperativa _cooperativa;
        public frmUsuario(Usuario u, Cooperativa c)
        {
            _cooperativa = c;
            _usuario = u;
            InitializeComponent();
            lbl_usuarioConectado.Text = "Usuario conectado: " + _usuario.Id_usuario;
        }

        private void bt_atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            _cooperativa.Show();
        }

        private void bt_crearUsuario_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario(_usuario.conexion);
            u.Contrasena = txtBx_contrasena.Text;
            u.Id_usuario = txtbx_id_usuario.Text;
            if (u.Insertar())
            {
                MessageBox.Show("Agregado Correctamente");
                clearTxtBx();
            }

            void clearTxtBx()
            {
                txtbx_id_usuario.Clear();
                txtBx_contrasena.Clear();

            }
        }

        private void bt_mostrar_eliminar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario(_usuario.conexion);
            grid_todos_eliminar.DataSource = u.getData();
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (lbl_cuenta_borrar.Text != "-")
            {

                Usuario u = new Usuario(this._usuario.conexion);
                u.Id_usuario = lbl_cuenta_borrar.Text;
                if (u.Eliminar())
                {
                    MessageBox.Show("Eliminado Correctamente");
                    bt_mostrar_eliminar_Click(bt_mostrar_eliminar, e);
                }
            }
        }

        private void bt_mostrarUsuarios_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario(this._usuario.conexion);
            grid_Todos.DataSource = u.getData();
        }

        private void grid_todos_eliminar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int nRow = e.RowIndex;
            lbl_cuenta_borrar.Text = (grid_todos_eliminar[0, nRow].Value == null ? "-" : grid_todos_eliminar[0, nRow].Value.ToString());
        }
    }
}
