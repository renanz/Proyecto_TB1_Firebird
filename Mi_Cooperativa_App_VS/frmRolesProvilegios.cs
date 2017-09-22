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
    public partial class frmRolesProvilegios : Form
    {
        private Usuario _usuario;
        private Cooperativa _cooperativa;
        public frmRolesProvilegios(Usuario u, Cooperativa c)
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
    }
}
