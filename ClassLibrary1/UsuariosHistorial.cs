using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class UsuariosHistorial 
    {
        public string usuario;
        public string tiempo;

        public UsuariosHistorial(string usuario, string tiempo)
        {
            this.usuario = usuario;
            this.tiempo = tiempo;
        }
        public UsuariosHistorial()
        {
            this.usuario = "";
            this.tiempo = "";
        }

        public override string ToString()
        {
            return $"{usuario},{tiempo}";
        }
        /// <summary>
        /// devuelve una linea de string de los datos de los usuarios
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        public string DevolverStringHistorial(UsuariosHistorial persona)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{persona.usuario}");
            sb.AppendLine($"{persona.tiempo}");
            return sb.ToString();
        }

    }
}
