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
    public partial class frmEmpleados : Form
    {
        private Usuario _usuario;
        private Cooperativa _cooperativa;

        public frmEmpleados(Usuario u, Cooperativa c)
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

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado(this._usuario);
            emp.id_usuario = txtbx_id_usuario.Text;
            emp.primerApellido = txtbx_primer_apellido.Text;
            emp.segundoNombre = txtbx_segundo_nombre.Text;
            emp.primerNombre = txtbx_primer_nombre.Text;
            emp.segundoApellido = txtbx_segundo_apellido.Text;

            int dia, mes, anio;

            date_fecha_nacimiento.Format = DateTimePickerFormat.Custom;
            date_fecha_nacimiento.CustomFormat = "yyyy";
            anio = Convert.ToInt32(date_fecha_nacimiento.Text);
            date_fecha_nacimiento.CustomFormat = "mm";
            mes = Convert.ToInt32(date_fecha_nacimiento.Text);
            date_fecha_nacimiento.CustomFormat = "dd";
            dia = Convert.ToInt32(date_fecha_nacimiento.Text);
            DateTime nac = new DateTime(anio, mes, dia);
            emp.fechaNacimiento = nac;

            date_fecha_inicio.Format = DateTimePickerFormat.Custom;
            date_fecha_inicio.CustomFormat = "yyyy";
            anio = Convert.ToInt32(date_fecha_inicio.Text);
            date_fecha_inicio.CustomFormat = "mm";
            mes = Convert.ToInt32(date_fecha_inicio.Text);
            date_fecha_inicio.CustomFormat = "dd";
            dia = Convert.ToInt32(date_fecha_inicio.Text);
            DateTime ini = new DateTime(anio, mes, dia);
            emp.fechaInicio = ini;


            emp.calle = txtbx_calle.Text;
            emp.avenida = txtbx_avenida.Text;
            emp.no_casa = Convert.ToInt32(txtbx_no_casa.Text);
            emp.departamento = txtbx_departamento.Text;
            emp.ciudad = txtbx_ciudad.Text;
            emp.referencia = txtbx_referencia.Text;

            if(emp.Insertar())
            {
                MessageBox.Show("Agregado Correctamente");
                clearTxtBx();
            }

            void clearTxtBx()
            {
                txtbx_id_usuario.Clear();
                txtbx_primer_apellido.Clear();
                txtbx_segundo_nombre.Clear();
                txtbx_primer_nombre.Clear();
                txtbx_segundo_apellido.Clear();

                date_fecha_nacimiento.Format = DateTimePickerFormat.Long;
                date_fecha_inicio.Format = DateTimePickerFormat.Long;
                
                txtbx_calle.Clear();
                txtbx_avenida.Clear();
                txtbx_no_casa.Clear();
                txtbx_departamento.Clear();
                txtbx_ciudad.Clear();
                txtbx_referencia.Clear();
            }
        }

        private void bt_mostrarEmps_Click(object sender, EventArgs e)
        {
            Empleado em = new Empleado(this._usuario);
            grid_Todos.DataSource = em.getData();
        }
        void DataGridTodosEliminar(object seneder, DataGridViewCellEventArgs e)
        {
            int nRow = e.RowIndex;
            lbl_usuario_borrar.Text = (grid_todos_eliminar[0, nRow].Value == null?"-": grid_todos_eliminar[0, nRow].Value.ToString());
        }

        private void bt_mostrar_eliminar_Click(object sender, EventArgs e)
        {
            Empleado em = new Empleado(this._usuario);
            grid_todos_eliminar.DataSource = em.getData();
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (lbl_usuario_borrar.Text != "-")
            {

                Empleado em = new Empleado(this._usuario);
                em.id_empleado = lbl_usuario_borrar.Text;
                if (em.eliminar())
                {
                    MessageBox.Show("Eliminado Correctamente");
                    bt_mostrar_eliminar_Click(bt_mostrar_eliminar, e);
                }
            }
        }
    }
}
