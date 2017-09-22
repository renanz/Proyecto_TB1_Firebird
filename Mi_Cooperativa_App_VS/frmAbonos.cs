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
    public partial class frmAbonos : Form
    {
        private Usuario _usuario;
        private Cooperativa _cooperativa;
        public frmAbonos(Usuario u, Cooperativa c)
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

        private void bt_mostrarAbonos_Click(object sender, EventArgs e)
        {
            Abonos ab = new Abonos(this._usuario);
            grid_Todos.DataSource = ab.getData();
        }

        private void bt_verCuentas_Click(object sender, EventArgs e)
        {
            Cuenta a = new Cuenta(this._usuario);
            dataGridView1.DataSource = a.getData();
        }

        private void bt_crearAbono_Click(object sender, EventArgs e)
        {
            Abonos a = new Abonos(this._usuario);
            a.NoCuenta = Convert.ToInt32(numericUpDown1.Value);
            a.Monto = numberMonto.Value;
            a.Fecha = date_abono.Value;
            a.Descripcion = textBox1.Text;


            if (a.Insertar())
            {
                MessageBox.Show("Agregada Correctamente");
                clearTxtBx();
            }

            void clearTxtBx()
            {
                numberMonto.Value = 0;
                numericUpDown1.Value = 0;
                textBox1.Clear();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int nRow = e.RowIndex;
            numericUpDown1.Text = dataGridView1[0, nRow].Value.ToString();
        }

        private void bt_mostrar_eliminar_Click(object sender, EventArgs e)
        {
            Abonos pg = new Abonos(this._usuario);
            grid_todos_eliminar.DataSource = pg.getData();
        }

        private void grid_todos_eliminar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int nRow = e.RowIndex;
            lbl_pago_borrar.Text = grid_todos_eliminar[0, nRow].Value.ToString();
            lbl_prestamo.Text = grid_todos_eliminar[1, nRow].Value.ToString();
        }
    }
}
