using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mi_Cooperativa_App_VS
{
    public partial class frmCuenta : Form
    {
        private Usuario _usuario;
        private Cooperativa _cooperativa;
        public frmCuenta(Usuario u, Cooperativa c)
        {
            _cooperativa = c;
            _usuario = u;
            InitializeComponent();
            lbl_usuarioConectado.Text = "Usuario conectado: " + _usuario.Id_usuario;
        }

        private void bt_crearCuenta_Click(object sender, EventArgs e)
        {
            Cuenta c = new Cuenta(this._usuario);
            c.id_empleado = txtbx_id_empleado.Text;
            int combo = combo_tipoCta.SelectedIndex;
            string tipo = (combo == 0 ? "Aportaciones" : "Ahorro Retirable");
            c.Tipo = tipo;
            c.Saldo = numberSaldo.Value;
            c.AhorroMensual = numberAhorro.Value;

            DateTime ape = date_apertura.Value;
            c.FechaApertura = ape;
            


            if (c.Insertar())
            {
                MessageBox.Show("Agregada Correctamente");
                clearTxtBx();
            }

            void clearTxtBx()
            {
                txtbx_id_empleado.Clear();
                numberAhorro.Value = 0;
                numberSaldo.Value = 0;

                date_apertura.Format = DateTimePickerFormat.Long;
                
            }

        }

        private void bt_atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            _cooperativa.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int nRow = e.RowIndex;
            txtbx_id_empleado.Text = dataGridView1[0, nRow].Value.ToString();
        }

        private void bt_verEmps_Click(object sender, EventArgs e)
        {
            Empleado em = new Empleado(this._usuario);
            dataGridView1.DataSource = em.getData();
        }

        private void bt_mostrarCuentas_Click(object sender, EventArgs e)
        {
            Cuenta ct = new Cuenta(this._usuario);
            grid_Todos.DataSource = ct.getData();
        }

        private void bt_mostrar_eliminar_Click(object sender, EventArgs e)
        {
            Cuenta ct = new Cuenta(this._usuario);
            grid_todos_eliminar.DataSource = ct.getData();
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (lbl_cuenta_borrar.Text != "-")
            {

                Cuenta ct = new Cuenta(this._usuario);
                ct.id_empleado = lbl_cuenta_borrar.Text;
                if (ct.eliminar())
                {
                    MessageBox.Show("Eliminado Correctamente");
                    bt_mostrar_eliminar_Click(bt_mostrar_eliminar, e);
                }
            }
        }

        private void grid_todos_eliminar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int nRow = e.RowIndex;
            lbl_cuenta_borrar.Text = (grid_todos_eliminar[0, nRow].Value == null ? "-" : grid_todos_eliminar[0, nRow].Value.ToString());
        }
    }
}
