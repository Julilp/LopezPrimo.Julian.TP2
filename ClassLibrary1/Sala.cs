using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Sala
    {
        public int idSala;
        public string creador;
        public string tiempo;
        public string estado;
        

        public Sala(int idSala,string creador, string tiempo,string estado)
        {
            this.idSala = idSala;
            this.creador = creador;
            this.tiempo = tiempo;
            this.estado = estado;
        }
        public Sala(string creador)
        {
            this.creador = creador;
            this.tiempo = "";
            this.estado = "En Partida";
        }
        public Sala()
        {
            this.creador = "";
            this.tiempo = "";
            this.estado = "En Partida";
        }
        /// <summary>
        /// devuelve la informacion de una sala como un string
        /// </summary>
        /// <param name="sala"></param>
        /// <returns></returns>
        public static string[] devolverSalaString(Sala sala)
        {
            string[] devolver = {sala.idSala.ToString(),sala.creador,sala.estado,sala.tiempo };
            return devolver;
        }

    }
}
