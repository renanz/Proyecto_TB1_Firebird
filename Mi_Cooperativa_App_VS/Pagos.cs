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
    class Pagos
    {
        private FbConnection _connection = null;
        private Usuario _usuario = null;
        public Pagos(Usuario u)
        {
            _usuario = u;
            _connection = u.conexion;

        }
        private string no_prestamo;
        public string NoPrestamo
        {
            set { no_prestamo = value; }
            get { return no_prestamo; }
        }

        private string no_pago;
        public string NoPago
        {
            get { return no_pago; }
            set { no_pago = value; }
            
        }

        private DateTime _fecha;
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
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
                cmd.CommandText = "sp_PAGOS_i";

                cmd.Parameters.Add("NO_PRESTAMO", FbDbType.VarChar).Value = this.NoPrestamo;
                cmd.Parameters.Add("FECHA", FbDbType.Date).Value = this.Fecha;

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
                cmd.CommandText = "SP_PAGOS_s";

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
                cmd.CommandText = "SP_PAGOS_d";
                cmd.Parameters.Add("NO_PRESTAMO", FbDbType.VarChar).Value = this.no_prestamo;
                cmd.Parameters.Add("NO_PAGO", FbDbType.VarChar).Value = this.no_pago;

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
