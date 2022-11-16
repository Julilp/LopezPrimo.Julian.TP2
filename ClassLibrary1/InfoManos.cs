using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class InfoManos
    {
        int idSala;

        public List<Carta> jugador1 = new List<Carta>();
        public List<Carta> jugador2 = new List<Carta>();
        public Baraja baraja;
        public List<Carta> mazo = new List<Carta>();

        public InfoManos(int idSala, List<Carta> jugador1, List<Carta> jugador2, Baraja baraja, List<Carta> mazo)
        {
            this.idSala = idSala;
            this.jugador1 = jugador1;
            this.jugador2 = jugador2;
            this.baraja = baraja;
            this.mazo = mazo;
        }
        public InfoManos()
        {
            this.jugador1 = new List<Carta>();
            this.jugador2 = new List<Carta>();
            this.baraja = new Baraja();
            this.mazo = new List<Carta>();
        }
        /// <summary>
        /// guarda las cartas de cada persona y cada mazo con su dueño 
        /// </summary>
        /// <param name="mano"> todas las listas de cartsa de la partida</param>
        public void GuardarMano(InfoManos mano)
        {
            
            conexion bd = new conexion();
            foreach (Carta item in mano.jugador1)
            {
                bd.CartaAguardar("jugador1", item.valor.ToString(), item.color.ToString(), item.especial.ToString(), idSala);

            }
            foreach (Carta item in mano.jugador2)
            {
                bd.CartaAguardar("jugador2", item.valor.ToString(), item.color.ToString(), item.especial.ToString(), idSala);
            }
            foreach (Carta item in mano.mazo)
            {
                bd.CartaAguardar("mazo", item.valor.ToString(), item.color.ToString(), item.especial.ToString(), idSala);
            }
            foreach (Carta item in mano.baraja.listaCompleta)
            {
                bd.CartaAguardar("baraja", item.valor.ToString(), item.color.ToString(), item.especial.ToString(), idSala);
            }
        }
        public void ActualizarManos(InfoManos mano)
        {

        }

        /// <summary>
        /// le reparte las cartas a sus dueños segun el parametro de dueño
        /// </summary>
        /// <param name="mano"></param>
        public void distribuirCartas(InfoManos mano)
        {
            conexion bD = new conexion();
            List<CartaDevuelta> cartasBase = bD.devolverTodasCartas(mano.idSala);
            
            foreach (CartaDevuelta item in cartasBase)
            {
                Carta cartaAux = new Carta();
                cartaAux.color = item.color;
                cartaAux.especial = item.especial;
                cartaAux.valor = item.valor;
                switch (item.dueño)
                {
                    case "jugador1":                     
                        mano.jugador1.Add(cartaAux);
                    break;
                    case "jugador2":
                        mano.jugador2.Add(cartaAux);
                    break;
                    case "mazo":
                        mano.mazo.Add(cartaAux);
                    break;
                    case "baraja":
                        mano.baraja.listaCompleta.Add(cartaAux);
                    break;
                }
            }
        }
    }
}
