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
    class Abonos
    {
        private FbConnection _connection = null;
        private Usuario _usuario = null;
        public Abonos(Usuario u)
        {
            _usuario = u;
            _connection = u.conexion;

        }
        private int no_cuenta;
        public int NoCuenta
        {
            set { no_cuenta = value; }
            get { return no_cuenta; }
        }

        private string codigo_abono;
        public string CodAbono
        {
            get { return codigo_abono; }
            set { codigo_abono = value; }

        }

        private DateTime _fecha;
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        private Decimal _monto;
        public Decimal Monto
        {
            set { _monto = value; }
            get { return _monto; }
        }

        private string _descripcion;
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }

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
                cmd.CommandText = "sp_abonos_i";

                cmd.Parameters.Add("NO_CUENTA", FbDbType.Integer).Value = this.NoCuenta;
                cmd.Parameters.Add("MONTO", FbDbType.Decimal).Value = this.Monto;
                cmd.Parameters.Add("FECHA", FbDbType.Date).Value = this.Fecha;
                cmd.Parameters.Add("DESCRIPCION", FbDbType.VarChar).Value = this.Descripcion;

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
                cmd.CommandText = "SP_abonos_s";

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
                cmd.CommandText = "SP_abonos_d";
                cmd.Parameters.Add("CODIGO_ABONO", FbDbType.VarChar).Value = this.CodAbono;
                cmd.Parameters.Add("NO_CUENTA", FbDbType.Integer).Value = this.NoCuenta;

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
