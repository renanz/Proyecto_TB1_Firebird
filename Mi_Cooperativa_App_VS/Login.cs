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
using System.Diagnostics;

namespace Mi_Cooperativa_App_VS
{
    public partial class Login : Form
    {
        private FbConnection db;
        private Usuario u;
        public Login(FbConnection connection)
        {
            db = connection;
            InitializeComponent();
            u = new Usuario(db);
        }

        private String usuario, contrasena;

        private void bt_Ingresar_Click(object sender, EventArgs e)
        {
            this.usuario = txtBox_usuario.Text.ToUpper().ToString();
            this.contrasena = txtBox_contrasena.Text.ToString();
            u.Id_usuario = usuario;
            u.Contrasena = contrasena;
            int combo = combo_IngresarComo.SelectedIndex;
            if (loginCorrecto(combo) && combo==0)//administrador
            {
                this.Hide();
                Cooperativa c = new Cooperativa(this.u,this);
                c.Show();
            }
            else if(true && combo == 1)//afiliado
            {
                this.Hide();
                Afiliado a = new Afiliado(this, this.u);
                a.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBox_contrasena.Text = "admin";
            txtBox_usuario.Text = "admin";
            combo_IngresarComo.SelectedIndex = 0; ;
            bt_Ingresar_Click(bt_Ingresar, e);
        }

        private bool loginCorrecto(int combo){
            string select = (combo==0?"administrador":"afiliado");

            if (db != null && db.State == ConnectionState.Closed)
                db.Open();
            FbCommand cmd = new FbCommand();
            cmd.Connection = this.db;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_contrasena";
            FbParameter par =  cmd.Parameters.Add("p_usuario", FbDbType.VarChar);
            par.Value = u.Id_usuario.ToLower();
            FbParameter par3 = cmd.Parameters.Add("p_logas", FbDbType.VarChar);
            par3.Value = select;
            FbParameter par2 = cmd.Parameters.Add("contrasena", FbDbType.VarChar);
            par2.Direction = System.Data.ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            string result = par2.Value.ToString();

            if (result == u.Contrasena)
                return true;
            else
            {
                MessageBox.Show("Contraseña incorrecta. Escribala de nuevo");
                return false;
            }
        }
    }
}
