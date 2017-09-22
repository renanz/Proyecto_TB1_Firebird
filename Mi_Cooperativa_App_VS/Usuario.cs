using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using Dapper;
using System.Windows.Forms;

namespace Mi_Cooperativa_App_VS
{
    public class Usuario
    {
        private FbConnection connection = null;
        public Usuario(FbConnection db)
        {
            connection = db;
        }

        private string id_usuario;

        public FbConnection conexion
        {
            get { return connection; }
        }
        public string Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }

        private string contrasena;
        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        public bool Insertar()
        {
            FbCommand cmd = null;
            try
            {
                if (connection != null && connection.State == ConnectionState.Closed)
                    connection.Open();
                cmd = new FbCommand();
                cmd.Connection = connection;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "SP_USUARIO_I";

                cmd.Parameters.Add("ID_USUARIO", FbDbType.VarChar).Value = this.id_usuario;
                cmd.Parameters.Add("CONTRASENA", FbDbType.VarChar).Value = this.contrasena;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                //Atrapar el error y mostrarlo al usuario

                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                if (connection != null && connection.State != ConnectionState.Closed )
                    connection.Close();
            }

        }

        public bool Actualizar()
        {
            FbCommand cmd = null;
            try
            {
                if (connection != null && connection.State == ConnectionState.Closed)
                    connection.Open();
                cmd = new FbCommand();
                cmd.Connection = connection;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "SP_USUARIO_U";

                cmd.Parameters.Add("ID_USUARIO", FbDbType.VarChar).Value = this.id_usuario;
                cmd.Parameters.Add("CONTRASENA", FbDbType.VarChar).Value = this.contrasena;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                //Atrapar el error y mostrarlo al usuario

                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                if (connection != null && connection.State != ConnectionState.Closed)
                    connection.Close();
            }

        }
        public bool Eliminar()
        {
            FbCommand cmd = null;
            try
            {
                if (connection != null && connection.State == ConnectionState.Closed)
                    connection.Open();
                cmd = new FbCommand();
                cmd.Connection = connection;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "SP_USUARIO_D";

                cmd.Parameters.Add("ID_USUARIO", FbDbType.VarChar).Value = this.id_usuario;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                //Atrapar el error y mostrarlo al usuario

                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                if (connection != null && connection.State != ConnectionState.Closed)
                    connection.Close();
            }

        }

        public DataTable Select()
        {
            FbCommand cmd = null;
            DataTable dt = new DataTable();
            try
            {
                if (connection != null && connection.State == ConnectionState.Closed)
                    connection.Open();
                cmd = new FbCommand();
                cmd.Connection = connection;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "SP_USUARIO_S";

                cmd.Parameters.Add("P_USUARIO", FbDbType.VarChar).Value = this.id_usuario;

                FbDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);

                reader.Close();
                reader.Dispose();
                cmd.Dispose();

                return dt;
            }
            catch (Exception ex)
            {
                //Atrapar el error y mostrarlo al usuario

                MessageBox.Show(ex.Message);
                throw ex;
                return null;
            }
            finally
            {
                if (connection != null && connection.State != ConnectionState.Closed)
                    connection.Close();
            }
        }
        public DataTable getData()
        {
            FbCommand cmd = null;
            FbDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                if (connection != null && connection.State == ConnectionState.Closed)
                    connection.Open();
                cmd = new FbCommand();
                cmd.Connection = connection;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = @"SELECT 
										* 
									FROM 
										USUARIO";

                da = new FbDataAdapter(cmd);

                da.Fill(dt);

                da.Dispose();
                cmd.Dispose();

                return dt;
            }
            catch (Exception ex)
            {
                //Atrapar el error y mostrarlo al usuario
                throw ex;
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                if (connection != null && connection.State != ConnectionState.Closed)
                    connection.Close();
            }
        }

        public DataTable getPass(string u)
        {
            FbCommand cmd = null;
            FbDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                if (connection != null && connection.State == ConnectionState.Closed)
                    connection.Open();
                cmd = new FbCommand();
                cmd.Connection = connection;
                cmd.CommandType = System.Data.CommandType.Text;
                string comm = "execute procedure sp_contrasena ('" + u + "')";
                cmd.CommandText = comm;

                da = new FbDataAdapter(cmd);

                da.Fill(dt);

                da.Dispose();
                cmd.Dispose();

                return dt;
            }
            catch (Exception ex)
            {
                //Atrapar el error y mostrarlo al usuario
                throw ex;
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                if (connection != null && connection.State != ConnectionState.Closed)
                    connection.Close();
            }
        }
    }
}
