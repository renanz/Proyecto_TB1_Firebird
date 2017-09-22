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
    class Prestamos
    {
        private FbConnection _connection = null;
        private Usuario _usuario = null;
        public Prestamos(Usuario u)
        {
            _usuario = u;
            _connection = u.conexion;

        }
        private string no_prestamo;
        public string NoPrestamo
        {
            set { no_prestamo = value; }
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

        private Decimal _monto;
        public Decimal Monto
        {
            get { return _monto; }
            set { _monto = value; }
        }

        private DateTime _fecha;
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        private int _periodos;
        public int Periodos
        {
            get { return _periodos; }
            set { _periodos = value; }
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
                cmd.CommandText = "sp_PRESTAMO_i";

                cmd.Parameters.Add("ID_EMPLEADO", FbDbType.VarChar).Value = this.id_empleado;
                cmd.Parameters.Add("TIPO", FbDbType.VarChar).Value = this.Tipo;
                cmd.Parameters.Add("FECHA", FbDbType.Date).Value = this.Fecha;
                cmd.Parameters.Add("MONTO", FbDbType.Decimal).Value = this.Monto;
                cmd.Parameters.Add("PERIODOS", FbDbType.Integer).Value = this.Periodos;
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
                cmd.CommandText = "SP_PRESTAMO_s";

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
                cmd.CommandText = "SP_PRESTAMO_sel";

                cmd.Parameters.Add("pid_usuario", FbDbType.VarChar).Value = _usuario.Id_usuario;

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
                cmd.CommandText = "SP_PRESTAMO_d";
                cmd.Parameters.Add("NO_PRESTAMO", FbDbType.VarChar).Value = this.no_prestamo;

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
    }
}

