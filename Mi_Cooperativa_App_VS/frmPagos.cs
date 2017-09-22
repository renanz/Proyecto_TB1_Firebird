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
    public partial class frmPagos : Form
    {
        private Usuario _usuario;
        private Cooperativa _cooperativa;
        public frmPagos(Usuario u, Cooperativa c)
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

        private void bt_verPrestamos_Click(object sender, EventArgs e)
        {
            Prestamos p = new Prestamos(this._usuario);
            dataGridView1.DataSource = p.getData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int nRow = e.RowIndex;
            txtbx_no_prestamo.Text = dataGridView1[0, nRow].Value.ToString();
        }

        private void bt_crearPago_Click(object sender, EventArgs e)
        {
            Pagos p = new Pagos(this._usuario);
            p.NoPrestamo = txtbx_no_prestamo.Text;

            DateTime ape = date_pago.Value;
            p.Fecha = ape;



            if (p.Insertar())
            {
                MessageBox.Show("Agregada Correctamente");
                clearTxtBx();
            }

            void clearTxtBx()
            {
                txtbx_no_prestamo.Clear();
                date_pago.Format = DateTimePickerFormat.Long;

            }
        }

        private void grid_todos_eliminar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int nRow = e.RowIndex;
            lbl_prestamo.Text = grid_todos_eliminar[0, nRow].Value.ToString();
            lbl_pago_borrar.Text = grid_todos_eliminar[1, nRow].Value.ToString();
        }

        private void bt_mostrar_eliminar_Click(object sender, EventArgs e)
        {
            Pagos pg = new Pagos(this._usuario);
            grid_todos_eliminar.DataSource = pg.getData();
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (lbl_pago_borrar.Text != "-")
            {

                Pagos pago = new Pagos(this._usuario);
                pago.NoPago = lbl_pago_borrar.Text;
                pago.NoPrestamo = lbl_prestamo.Text;
                if (pago.eliminar())
                {
                    MessageBox.Show("Eliminado Correctamente");
                    bt_mostrar_eliminar_Click(bt_mostrar_eliminar, e);
                }
            }
        }

        private void bt_mostrarPagos_Click(object sender, EventArgs e)
        {
            Pagos pg = new Pagos(this._usuario);
            grid_Todos.DataSource = pg.getData();
        }
        
    }
}
