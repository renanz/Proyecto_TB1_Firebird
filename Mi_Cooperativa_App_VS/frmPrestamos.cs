using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mi_Cooperativa_App_VS
{
    public partial class frmPrestamos : Form
    {
        private Usuario _usuario;
        private Cooperativa _cooperativa;
        public frmPrestamos(Usuario u, Cooperativa c)
        {
            _cooperativa = c;
            _usuario = u;
            InitializeComponent();
            lbl_usuarioConectado.Text = "Usuario conectado: " + _usuario.Id_usuario;
        }

        private void bt_verEmps_Click(object sender, EventArgs e)
        {
            Empleado em = new Empleado(this._usuario);
            dataGridView1.DataSource = em.getData();
        }

        private void bt_atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            _cooperativa.Show();
        }

        private void bt_crearPrestamo_Click(object sender, EventArgs e)
        {
            Prestamos p = new Prestamos(this._usuario);
            p.id_empleado = txtbx_id_empleado.Text;
            int combo = combo_tipoPtmo.SelectedIndex;
            string tipo = (combo == 0 ? "Automatico" : "Fiduciario");
            p.Tipo = tipo;

            DateTime ape = date_fecha.Value;
            p.Fecha = ape;

            p.Monto = numberMonto.Value;
            p.Periodos = Convert.ToInt32(numberPeriodos.Value);



            if (p.Insertar())
            {
                MessageBox.Show("Agregada Correctamente");
                clearTxtBx();
            }

            void clearTxtBx()
            {
                txtbx_id_empleado.Clear();
                numberMonto.Value = 0;
                numberPeriodos.Value = 1;

                date_fecha.Format = DateTimePickerFormat.Long;

            }
        }

        private void grid_todos_eliminar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int nRow = e.RowIndex;
            lbl_prestamo_borrar.Text = (grid_todos_eliminar[0, nRow].Value == null ? "-" : grid_todos_eliminar[0, nRow].Value.ToString());
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (lbl_prestamo_borrar.Text != "-")
            {

                Prestamos pt = new Prestamos(this._usuario);
                pt.id_empleado = lbl_prestamo_borrar.Text;
                if (pt.eliminar())
                {
                    MessageBox.Show("Eliminado Correctamente");
                    bt_mostrar_eliminar_Click(bt_mostrar_eliminar, e);
                }
            }
        }

        private void bt_mostrar_eliminar_Click(object sender, EventArgs e)
        {
            Prestamos pt = new Prestamos(this._usuario);
            grid_todos_eliminar.DataSource = pt.getData();
        }

        private void bt_mostrarPrestamos_Click(object sender, EventArgs e)
        {
            Prestamos pt = new Prestamos(this._usuario);
            grid_Todos.DataSource = pt.getData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int nRow = e.RowIndex;
            txtbx_id_empleado.Text = dataGridView1[0, nRow].Value.ToString();
        }
    }
}
