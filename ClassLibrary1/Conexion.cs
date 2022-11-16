using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClassLibrary1
{
    public class conexion : IConexion<Sala>
    {
        SqlConnection connection;
        SqlCommand comando;
        SqlDataReader lector;

        private static string conectar;
        static conexion()
        {
            conexion.conectar = @"Data source = . ; initial catalog = DB1 ; integrated security = true ";
        }
        public conexion()
        {
            this.connection = new SqlConnection(conexion.conectar);
        }

        public bool probarConexion()
        {
            bool validacion = true;
            try
            {
                this.connection.Open();

            }
            catch (Exception)
            {
                validacion = false;
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }
            return validacion;
        }
        /// <summary>
        /// devuelve todas las salas de sql
        /// </summary>
        /// <returns></returns>
        public List<Sala> DevolverSalas()
        {
            List<Sala> salas = new List<Sala>();

            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM TablaSalas";
                this.comando.Connection = this.connection;

                this.connection.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Sala item = new Sala();

                    salas.Add(new Sala((int)lector["Id"], lector[1].ToString(), lector[2].ToString(), lector[3].ToString()));

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

            return salas;
        }
        /// <summary>
        /// inserta una sala a la base de sql
        /// </summary>
        /// <param name="sala"></param>
        /// <returns></returns>
        public bool insert(Sala sala)
        {
            bool rta = true;

            try
            {
                string sql = "INSERT INTO TablaSalas (Creador, Tiempo, Estado) VALUES(";
                sql = sql + "'" + sala.creador + "','" + sala.tiempo + "','" + sala.estado + "')";

                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.connection;

                this.connection.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception )
            {
                rta = false;
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return rta;
        }
        /// <summary>
        /// devuelve el tiempo de una sala en especifica
        /// </summary>
        /// <param name="idSala"> id para identificar la sala</param>
        /// <returns></returns>
        public string DevolverTiempo(int idSala)
        {
            string tiempo = "";

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = $"SELECT * FROM TablaSalas WHERE Id='{idSala}'";
                this.comando.Connection = this.connection;

                this.connection.Open();
                this.lector = this.comando.ExecuteReader();

                if (!this.lector.Read())
                {
                    tiempo = lector["Tiempo"].ToString();
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

            return tiempo;
        }
        /// <summary>
        /// te da todas las cartas de una sala paara despues repartirlas
        /// </summary>
        /// <param name="salaId">id para identificar la sala</param>
        /// <returns></returns>
        public List<CartaDevuelta> devolverTodasCartas(int salaId)
        {
            List<CartaDevuelta> lista = new List<CartaDevuelta>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = $"SELECT * FROM TablaManos WHERE idSala='{salaId}'";
                this.comando.Connection = this.connection;

                this.connection.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    CartaDevuelta item = new CartaDevuelta();
                    string stbool;

                    // ACCEDO POR NOMBRE, POR INDICE O POR GETTER (SEGUN TIPO DE DATO)
                    item.dueño = lector[0].ToString();
                    item.valor = lector[1].ToString();
                    item.color = lector[2].ToString();
                    stbool = lector[3].ToString();
                    if(stbool == "False")
                    {
                        item.especial = false;
                    }
                    else
                    {
                        item.especial = true;
                    }

                    lista.Add(item);
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

            return lista;
        }
        public bool CrearManos(int idSala)
        {
            bool rta = true;

            try
            {
                string sql = "INSERT INTO TablaManos (idSala) VALUES(";
                sql = sql + "'" + idSala + ")";

                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.connection;

                this.connection.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception )
            {
                rta = false;
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return rta;
        }
        public List<Carta> DevolverManos(string parametro, int idSala)
        {
            List<Carta> aDevolver = new List<Carta>();
            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = $"SELECT * FROM TablaManos WHERE idSala='{idSala}' and dueñoCartas = {parametro}";
                this.comando.Connection = this.connection;

                this.connection.Open();
                this.lector = this.comando.ExecuteReader();

                if (!this.lector.Read())
                {

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

            return aDevolver;
        }
        public bool CartaAguardar(string dueñoCarta, string valorCarta, string colorCarta, string tipoCarta, int idSala)
        {
            bool rta = true;

            try
            {
                string sql = "INSERT INTO TablaManos (dueñoCartas,valorCarta,colorCarta,tipoCarta,idSala) VALUES(";
                sql = sql + "'" + dueñoCarta + "','" + valorCarta + "','" + colorCarta + "','" + tipoCarta + "'," + idSala + ")";

                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.connection;

                this.connection.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception )
            {
                rta = false;
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return rta;
        }
        public bool GuardarSala(int idSala, string tiempo)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@idSala", idSala);
                this.comando.Parameters.AddWithValue("@tiempo", tiempo);

                string sql = "UPDATE TablaSalas ";
                sql += "SET Tiempo = @tiempo ";
                sql += "WHERE id = @idSala";


                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.connection;

                this.connection.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception )
            {
                rta = false;
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return rta;
        }
        public bool BorrarManos(int idSalas)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();


                string sql = "DELETE FROM TablaManos ";
                sql += $"WHERE idSala = {idSalas}";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.connection;

                this.connection.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return rta;
        }
        public bool TerminarPartida(int Id)
        {
             bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@Estado", "Finalizado");
                this.comando.Parameters.AddWithValue("@Id", Id);



                string sql = "UPDATE TablaSalas ";
                sql += "SET Estado = @Estado ";
                sql += "WHERE Id = @Id";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.connection;

                this.connection.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception )
            {
                rta = false;
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

                return rta;           
        }
    }
}
