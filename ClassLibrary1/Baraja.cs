using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace ClassLibrary1
{
    public class Baraja
    {
        Carta cartaAux = new Carta();
        public  List<Carta> listaCompleta = new List<Carta>();
        StreamReader leer;
        string json;
        public Baraja()
        {
            CargarBaraja();
        }
        /// <summary>
        /// Esta funcion deserealiza las cartas del archivo y las guarda en una lista
        /// </summary>
        public void CargarBaraja()
        {
            leer = File.OpenText("Carta.Json");           
            while ((json=leer.ReadLine()) is not null)
            {
                cartaAux = JsonSerializer.Deserialize<Carta>(json);
                listaCompleta.Add(cartaAux);
            }
        }
        /// <summary>
        /// recorre toda la lista de baraja y devuelve la cantidad de cartas en ella
        /// </summary>
        /// <param name="baraja"></param> recibe la baraja de cartas
        /// <returns> cevuelve el total de cartas </returns>
        public int VerTamanio (List<Carta> baraja)
        {
            int retorno = 0;
            foreach (Carta item in baraja)
            {
                retorno++;
            }
            return retorno;
        }
        /// <summary>
        /// reparte una sola carta de manera random
        /// </summary>
        /// <param name="baraja"> recibe la baraja con las cartas disponibles</param>
        /// <returns> devuelve una carta que fue retirada de manera random </returns>
        public Carta DarCartaRandom(List<Carta> baraja)
        {
            int random;
            int maximo = this.VerTamanio(baraja);
            Carta cartaADevolver = new Carta();
            Random IndiceDeCarta = new Random();
            random = IndiceDeCarta.Next(0, maximo);
            if (baraja.Count >= 1)
            {
                cartaADevolver = this.listaCompleta[random];
                this.listaCompleta.RemoveAt(random);
            }
            else
            {
              cartaADevolver = null;
            }
                
            return cartaADevolver;
        }
        /// <summary>
        /// reparte 7 cartas de manera aleatoria para comenzar la partida
        /// </summary>
        /// <param name="baraja"></param>
        /// <returns> devuelve una lista con las 7 cartas </returns>
        public List<Carta> Repartir(List<Carta> baraja)
        {
            Carta cartaAAgregar = new Carta();
            List<Carta> manoADevolver = new List<Carta>();
            for(int i = 0; i< 7; i++)
            {               
                manoADevolver.Add(this.DarCartaRandom(baraja));
            }
            return manoADevolver;
        }
    }
}
        
 
    

