using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace Mi_Cooperativa_App_VS
{
    class Cuenta
    {

        private FbConnection _connection = null;
        private Usuario _usuario = null;
        public Cuenta(Usuario u)
        {
            _usuario = u;
            _connection = u.conexion;

        }
        private int no_cuenta;
        public int NoCuenta
        {
            set { no_cuenta = value; }
        }

        private string _idEmp;
        public string id_empleado
        {
            set { _idEmp = value; }
            get { return _idEmp; }
        }

        private string _tipo;
        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        private Decimal _saldo;
        public Decimal Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        private Decimal _ahorroMensual;
        public Decimal AhorroMensual
        {
            get { return _ahorroMensual; }
            set { _ahorroMensual = value; }
        }

        private DateTime _fechaApertura;
        public DateTime FechaApertura
        {
            get { return _fechaApertura; }
            set { _fechaApertura = value; }
        }
        
        public bool Insertar()
        {

            FbCommand cmd = null;
            try
            {
                if (_connection != null && _connection.State == ConnectionState.Closed)
                    _connection.Open();
                cmd = new FbCommand();
                cmd.Connection = _connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_cuenta_i";

                cmd.Parameters.Add("ID_EMPLEADO", FbDbType.VarChar).Value = this.id_empleado;
                cmd.Parameters.Add("TIPO", FbDbType.VarChar).Value = this.Tipo;
                cmd.Parameters.Add("SALDO", FbDbType.Decimal).Value = this.Saldo;
                cmd.Parameters.Add("AHORRO_MENSUAL", FbDbType.Decimal).Value = this.AhorroMensual;
                cmd.Parameters.Add("FECHA_APERTURA", FbDbType.Date).Value = this.FechaApertura;
                cmd.Parameters.Add("USUARIO_CREADOR", FbDbType.VarChar).Value = this._usuario.Id_usuario;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                if (_connection != null && _connection.State != ConnectionState.Closed)
                    _connection.Close();
            }
        }

        public DataTable getData()
        {
            FbCommand cmd = null;
            FbDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                if (_connection != null && _connection.State == ConnectionState.Closed)
                    _connection.Open();
                cmd = new FbCommand();
                cmd.Connection = _connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_cuenta_s";

                da = new FbDataAdapter(cmd);

                da.Fill(dt);

                da.Dispose();
                cmd.Dispose();

                return dt;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                MessageBox.Show(e.Message);
                throw e;
                return null;
            }
            finally
            {
                if (_connection != null && _connection.State != ConnectionState.Closed)
                    _connection.Close();
            }
        }

        public bool eliminar()
        {
            FbCommand cmd = null;
            try
            {
                if (_connection != null && _connection.State == ConnectionState.Closed)
                    _connection.Open();
                cmd = new FbCommand();
                cmd.Connection = _connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_cuenta_d";
                cmd.Parameters.Add("NO_CUENTA", FbDbType.Integer).Value = this._idEmp;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                return true;

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                if (_connection != null && _connection.State != ConnectionState.Closed)
                    _connection.Close();
            }
        }

        public DataTable afiliado()
        {
            FbCommand cmd = null;
            FbDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                if (_connection != null && _connection.State == ConnectionState.Closed)
                    _connection.Open();
                cmd = new FbCommand();
                cmd.Connection = _connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_cuenta_sel";

                cmd.Parameters.Add("pid_empleado", FbDbType.VarChar).Value = _usuario.Id_usuario.ToLower();

                da = new FbDataAdapter(cmd);

                da.Fill(dt);

                da.Dispose();
                cmd.Dispose();

                return dt;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                MessageBox.Show(e.Message);
                throw e;
                return null;
            }
            finally
            {
                if (_connection != null && _connection.State != ConnectionState.Closed)
                    _connection.Close();
            }
        }
    }
}
