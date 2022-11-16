using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Carta 
    {
        public string color;
        public string valor;
        public bool especial;

        public string Color { get => color; set => color = value; }
        public string Valor { get => valor; set => valor = value; }
        public bool Especial { get => especial; set => especial = value; }

        public Carta(string color, string valor, bool especial)
        {
            this.color = color;
            this.valor = valor;
            this.especial = especial;
        }
        public Carta()
        {
            this.color = "";
            this.valor = "";
            this.especial = false;
        }

        /// <summary>
        /// string builder para poder rellenar un listbox
        /// </summary>
        /// <param name="cartaADevolver"></param>
        /// <returns> devuelve un string con todos los datos de la carta </returns>
        public  string StringCarta(Carta cartaADevolver)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{cartaADevolver.valor}  ");
            sb.AppendLine($"{cartaADevolver.color}  ");
            return sb.ToString();
        }
        /// <summary>
        /// compara un string builder de carta y te devuelve la carta, es un m,etodo para poder arrijar una carta elegida en un listbox
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="cartaString"></param>
        /// <returns> devuelve la carta elegida </returns>
        public  Carta CompararYDevolverCarta(List<Carta> lista, string cartaString)
        {
            Carta cartaDevolver = new Carta();
            foreach (Carta item in lista)
            {
                if (StringCarta(item) == cartaString)
                {
                    cartaDevolver = item;
                    break;
                }
            }
            return cartaDevolver;
        }
        /// <summary>
        /// este metodo sirve para poder pasar una carta especifica de una lista a otra, como tirar una carta
        /// </summary>
        /// <param name="Usuario"> lista de cartas que posee el usuario </param>
        /// <param name="cartaAux"> carta elegida para pasar, usada como referencia </param>
        /// <param name="mazo"> mazo con todas las cartas que los usuarios van tirando  </param>
        /// <returns> devuelve el mazo con la nueva carta arrojada </returns>
        public static List<Carta> AgregarCartaAlMazo(List<Carta> Usuario, Carta cartaAux, List<Carta> mazo)
        {
            foreach (Carta item in Usuario)
            {
                if(item == cartaAux)
                {
                    mazo.Add(item);
                }
            }
            return mazo;
        }
        /// <summary>
        /// Elimina una carta especifica de una lista 
        /// </summary>
        /// <param name="Usuario"> lista de cartas que tiene el usuario </param>
        /// <param name="cartaAux"> carta que se usa como referencia </param>
        /// <returns> devuelve la lista sin la carta eliminada </returns>
        public static List<Carta> EliminarCarta(List<Carta> Usuario, Carta cartaAux)
        {
            int contador = 0;
            foreach (Carta item in Usuario)
            {
                
                if (item == cartaAux)
                {
                    Usuario.RemoveAt(contador);
                    break;
                }
                contador++;
            }
            return Usuario;
        }
        /// <summary>
        /// compara el tipo de carta especial que es y devuelve un int para identificar
        /// </summary>
        /// <param name="carta"></param>
        /// <returns>un int para identificar</returns>
        public static int CartaEspecialColor( Carta carta)
        {
            int id=0;
            switch (carta.valor)
            {
                case "X":
                    id = 1;
                break;
                case "MD":
                    id = 2;
                break;
                case "CT":
                    id = 3;
                break;
            }

            return id;
        }
        /// <summary>
        /// compara el tipo de carta especial que es y devuelve un int para identificar
        /// </summary>
        /// <param name="carta"></param>
        /// <returns>un int para identificar</returns>
        public static int CartaEspecialComodin(Carta carta)
        {
            int id = 0;
            switch (carta.valor)
            {
                case "MC":
                    id = 1;
                    break;
                case "CL":
                    id = 2;
                    break;
            }

            return id;
        }
    }
}
