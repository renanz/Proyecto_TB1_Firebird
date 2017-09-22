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
    public partial class Afiliado : Form
    {
        private Login _login;
        private Usuario _usuario;
        public Afiliado(Login l, Usuario u)
        {
            _login = l;
            _usuario = u;
            InitializeComponent();
            lbl_usuarioConectado.Text = "Usuario conectado: " + _usuario.Id_usuario;
            fillGrids();
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            _login.Show();
        }

        private void fillGrids()
        {
            Cuenta c = new Cuenta(_usuario);
            grid_cuentas.DataSource = c.afiliado();
            Prestamos p = new Prestamos(_usuario);
            grid_prestamos.DataSource = p.afiliado();
        }

        private void Afiliado_Load(object sender, EventArgs e)
        {
            grid_cuentas.AutoGenerateColumns = true;
            grid_prestamos.AutoGenerateColumns = true;
        }
    }
}
