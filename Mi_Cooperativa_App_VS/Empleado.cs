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

    class Empleado
    {
        private FbConnection _connection = null;
        private Usuario _usuario = null;
        public Empleado(Usuario u)
        {
            _usuario = u;
            _connection = u.conexion;
            
        }

        private string _idEmp;
        public string id_empleado
        {
           set { _idEmp = value; }
        }

        private string _id;
        public string id_usuario
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _primerNombre;
        public string primerNombre
        {
            get { return _primerNombre; }
            set { _primerNombre = value; }
        }

        private string _segundoNombre;
        public string segundoNombre
        { 
            get { return _segundoNombre; }
            set { _segundoNombre = value; }
        }

        private string _primerApellido;
        public string primerApellido
        {
            get { return _primerApellido; }
            set { _primerApellido = value; }
        }

        private string _segundoApellido;
        public string segundoApellido
        {
            get { return _segundoApellido; }
            set { _segundoApellido = value; }
        }

        private DateTime _fecha_nacimiento;
        public DateTime fechaNacimiento
        {
            get { return _fecha_nacimiento; }
            set { _fecha_nacimiento = value; }
        }

        private DateTime _fecha_inicio;
        public DateTime fechaInicio
        {
            get { return _fecha_inicio; }
            set { _fecha_inicio = value; }
        }

        private string _calle;
        public string calle
        {
            get { return _calle; }
            set { _calle = value; }
        }

        private string _avenida;
        public string avenida
        {
            get { return _avenida; }
            set { _avenida = value; }
        }

        private int _casa;
        public int no_casa
        {
            get { return _casa; }
            set { _casa = value; }
        }

        private string _ciudad;
        public string ciudad
        {
            get { return _ciudad; }
            set { _ciudad = value; }
        }

        private string _departamento;
        public string departamento
        {
            get { return _departamento; }
            set { _departamento = value; }
        }

        private string _referencia;
        public string referencia
        {
            get { return _referencia; }
            set { _referencia = value; }
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
                cmd.CommandText = "SP_empleado_i";

                cmd.Parameters.Add("ID_USUARIO", FbDbType.VarChar).Value = this.id_usuario;
                cmd.Parameters.Add("PRIMER_NOMBRE", FbDbType.VarChar).Value = this.primerNombre;
                cmd.Parameters.Add("SEGUNDO_NOMBRE", FbDbType.VarChar).Value = this.segundoNombre;
                cmd.Parameters.Add("PRIMER_APELLIDO", FbDbType.VarChar).Value = this.primerApellido;
                cmd.Parameters.Add("SEGUNDO_APELLIDO", FbDbType.VarChar).Value = this.segundoApellido;
                cmd.Parameters.Add("FECHA_NACIMIENTO", FbDbType.Date).Value = this.fechaNacimiento;
                cmd.Parameters.Add("FECHA_INICIO", FbDbType.Date).Value = this.fechaInicio;
                cmd.Parameters.Add("DIRECCION_CALLE", FbDbType.VarChar).Value = this.calle;
                cmd.Parameters.Add("DIRECCION_AVENIDA", FbDbType.VarChar).Value = this.avenida;
                cmd.Parameters.Add("DIRECCION_NO_CASA", FbDbType.Integer).Value = this.no_casa;
                cmd.Parameters.Add("DIRECCION_CIUDAD", FbDbType.VarChar).Value = this.ciudad;
                cmd.Parameters.Add("DIRECCION_DEPARTAMENTO", FbDbType.VarChar).Value = this.departamento;
                cmd.Parameters.Add("DIRECCION_REFERENCIA", FbDbType.VarChar).Value = this.referencia;
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
                cmd.CommandText = "SP_empleado_s";

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
                cmd.CommandText = "SP_empleado_d";
                cmd.Parameters.Add("ID_EMPLEADO", FbDbType.VarChar).Value = this._idEmp;

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
