using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CartaDevuelta 
    {
        public string dueño;
        public string color;
        public string valor;
        public bool especial;

        public CartaDevuelta(string dueño, string color, string valor, bool especial)
        {
            this.dueño = dueño;
            this.color = color;
            this.valor = valor;
            this.especial = especial;
        }
        public CartaDevuelta()
        {
            this.dueño = "";
            this.color = "";
            this.valor = "";
            this.especial = false;
        }
    }
}
