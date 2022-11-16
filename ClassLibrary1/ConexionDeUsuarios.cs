using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace ClassLibrary1
{
    public class ConexionDeUsuarios : IConexion<Usuario>
    {

        SqlConnection connection;
        SqlCommand comando;
        SqlDataReader lector;

        private static string conectar;

        static ConexionDeUsuarios()
        {
            ConexionDeUsuarios.conectar = @"Data source = . ; initial catalog = DB1 ; integrated security = true ";
        }
        public ConexionDeUsuarios()
        {
            this.connection = new SqlConnection(ConexionDeUsuarios.conectar);
        }
        /// <summary>
        /// inserta los usuarios en la tabla de usuarios de sql
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        public bool insert(Usuario persona)
        {
            bool retorno = false;
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM dbo.TablaUsuarios";
                this.comando.Connection = this.connection;

                this.connection.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    if ((lector["Usuario"].ToString() == persona.nombre) && (lector["Contraseña"].ToString() == persona.contrasenia))
                    {
                        retorno = true;
                        break;
                    }
                }

                lector.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }
            return retorno;
        }
        /// <summary>
        /// registra un usuario nuevo
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        public bool RegistrarUsuario(Usuario persona)
        {
            bool respuesta = false;

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = $"SELECT * FROM dbo.TablaUsuarios WHERE Usuario='{persona.nombre}'";
                this.comando.Connection = this.connection;

                this.connection.Open();
                this.lector = this.comando.ExecuteReader();

                if (!this.lector.Read())
                {
                    this.lector.Close();

                    string SQL = "INSERT INTO dbo.TablaUsuarios (Usuario, Contraseña) VALUES(";
                    SQL = SQL + "'" + persona.nombre + "','" + persona.contrasenia + "')";

                    this.comando.CommandText = SQL;

                    int filasAfectadas = this.comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        respuesta = true;
                    }
                }

                lector.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return respuesta;
        }
    }
}
