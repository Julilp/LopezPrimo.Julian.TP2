using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.Threading;
using System.Text.Json;
using System.IO;
namespace Serealizacion
{
    class CartasJson
    {
        
        public static List<Carta> listaCompleta = new List<Carta>() 
        { 
            #region CartasRojas
            (new Carta() { color = Colores.Rojo.ToString(), valor = "1", especial = false }),
            (new Carta() { color = Colores.Rojo.ToString(), valor = "2", especial = false }),
            (new Carta() { color = Colores.Rojo.ToString(), valor = "3", especial = false }),
            (new Carta() { color = Colores.Rojo.ToString(), valor = "4", especial = false }),
            (new Carta() { color = Colores.Rojo.ToString(), valor = "5", especial = false }),
            (new Carta() { color = Colores.Rojo.ToString(), valor = "6", especial = false }),
            (new Carta() { color = Colores.Rojo.ToString(), valor = "7", especial = false }),
            (new Carta() { color = Colores.Rojo.ToString(), valor = "8", especial = false }),
            (new Carta() { color = Colores.Rojo.ToString(), valor = "9", especial = false }),
            (new Carta() { color = Colores.Rojo.ToString(), valor = "X", especial = true }),
            (new Carta() { color = Colores.Rojo.ToString(), valor = "MD", especial = true }),
            (new Carta() { color = Colores.Rojo.ToString(), valor = "CT", especial = true }),

            #endregion
            #region CartasAzul
            (new Carta() { color = Colores.Azul.ToString(), valor = "1", especial = false }),
            (new Carta() { color = Colores.Azul.ToString(), valor = "2", especial = false }),
            (new Carta() { color = Colores.Azul.ToString(), valor = "3", especial = false }),
            (new Carta() { color = Colores.Azul.ToString(), valor = "4", especial = false }),
            (new Carta() { color = Colores.Azul.ToString(), valor = "5", especial = false }),
            (new Carta() { color = Colores.Azul.ToString(), valor = "6", especial = false }),
            (new Carta() { color = Colores.Azul.ToString(), valor = "7", especial = false }),
            (new Carta() { color = Colores.Azul.ToString(), valor = "8", especial = false }),
            (new Carta() { color = Colores.Azul.ToString(), valor = "9", especial = false }),
            (new Carta() { color = Colores.Azul.ToString(), valor = "X", especial = true }),
            (new Carta() { color = Colores.Azul.ToString(), valor = "MD", especial = true }),
            (new Carta() { color = Colores.Azul.ToString(), valor = "CT", especial = true }),

            #endregion
            #region CartasVerdes
            (new Carta() { color = Colores.Verde.ToString(), valor = "1", especial = false }),
            (new Carta() { color = Colores.Verde.ToString(), valor = "2", especial = false }),
            (new Carta() { color = Colores.Verde.ToString(), valor = "3", especial = false }),
            (new Carta() { color = Colores.Verde.ToString(), valor = "4", especial = false }),
            (new Carta() { color = Colores.Verde.ToString(), valor = "5", especial = false }),
            (new Carta() { color = Colores.Verde.ToString(), valor = "6", especial = false }),
            (new Carta() { color = Colores.Verde.ToString(), valor = "7", especial = false }),
            (new Carta() { color = Colores.Verde.ToString(), valor = "8", especial = false }),
            (new Carta() { color = Colores.Verde.ToString(), valor = "9", especial = false }),
            (new Carta() { color = Colores.Verde.ToString(), valor = "X", especial = true }),
            (new Carta() { color = Colores.Verde.ToString(), valor = "MD", especial = true }),
            (new Carta() { color = Colores.Verde.ToString(), valor = "CT", especial = true }),

            #endregion
            #region CartasAmarillas
            (new Carta() { color = Colores.Amarillo.ToString(), valor = "1", especial = false }),
            (new Carta() { color = Colores.Amarillo.ToString(), valor = "2", especial = false }),
            (new Carta() { color = Colores.Amarillo.ToString(), valor = "3", especial = false }),
            (new Carta() { color = Colores.Amarillo.ToString(), valor = "4", especial = false }),
            (new Carta() { color = Colores.Amarillo.ToString(), valor = "5", especial = false }),
            (new Carta() { color = Colores.Amarillo.ToString(), valor = "6", especial = false }),
            (new Carta() { color = Colores.Amarillo.ToString(), valor = "7", especial = false }),
            (new Carta() { color = Colores.Amarillo.ToString(), valor = "8", especial = false }),
            (new Carta() { color = Colores.Amarillo.ToString(), valor = "9", especial = false }),
            (new Carta() { color = Colores.Amarillo.ToString(), valor = "X", especial = true }),
            (new Carta() { color = Colores.Amarillo.ToString(), valor = "MD", especial = true }),
            (new Carta() { color = Colores.Amarillo.ToString(), valor = "CT", especial = true }),
            #endregion
            #region CartasComodin
            (new Carta() { color = Colores.Comodin.ToString(), valor = "CL", especial = true }),
            (new Carta() { color = Colores.Comodin.ToString(), valor = "CL", especial = true }),
            (new Carta() { color = Colores.Comodin.ToString(), valor = "CL", especial = true }),
            (new Carta() { color = Colores.Comodin.ToString(), valor = "CL", especial = true }),
            (new Carta() { color = Colores.Comodin.ToString(), valor = "MC", especial = true }),
            (new Carta() { color = Colores.Comodin.ToString(), valor = "MC", especial = true }),
            (new Carta() { color = Colores.Comodin.ToString(), valor = "MC", especial = true }),
            (new Carta() { color = Colores.Comodin.ToString(), valor = "MC", especial = true }),
            #endregion
            #region CartasRojas
            (new Carta() { color = Colores.Rojo.ToString(), valor = "1", especial = false }),
            (new Carta() { color = Colores.Rojo.ToString(), valor = "2", especial = false }),
            (new Carta() { color = Colores.Rojo.ToString(), valor = "3", especial = false }),
            (new Carta() { color = Colores.Rojo.ToString(), valor = "4", especial = false }),
            (new Carta() { color = Colores.Rojo.ToString(), valor = "5", especial = false }),
            (new Carta() { color = Colores.Rojo.ToString(), valor = "6", especial = false }),
            (new Carta() { color = Colores.Rojo.ToString(), valor = "7", especial = false }),
            (new Carta() { color = Colores.Rojo.ToString(), valor = "8", especial = false }),
            (new Carta() { color = Colores.Rojo.ToString(), valor = "9", especial = false }),
            (new Carta() { color = Colores.Rojo.ToString(), valor = "X", especial = true }),
            (new Carta() { color = Colores.Rojo.ToString(), valor = "MD", especial = true }),
            (new Carta() { color = Colores.Rojo.ToString(), valor = "CT", especial = true }),

            #endregion
            #region CartasAzul
            (new Carta() { color = Colores.Azul.ToString(), valor = "1", especial = false }),
            (new Carta() { color = Colores.Azul.ToString(), valor = "2", especial = false }),
            (new Carta() { color = Colores.Azul.ToString(), valor = "3", especial = false }),
            (new Carta() { color = Colores.Azul.ToString(), valor = "4", especial = false }),
            (new Carta() { color = Colores.Azul.ToString(), valor = "5", especial = false }),
            (new Carta() { color = Colores.Azul.ToString(), valor = "6", especial = false }),
            (new Carta() { color = Colores.Azul.ToString(), valor = "7", especial = false }),
            (new Carta() { color = Colores.Azul.ToString(), valor = "8", especial = false }),
            (new Carta() { color = Colores.Azul.ToString(), valor = "9", especial = false }),
            (new Carta() { color = Colores.Azul.ToString(), valor = "X", especial = true }),
            (new Carta() { color = Colores.Azul.ToString(), valor = "MD", especial = true }),
            (new Carta() { color = Colores.Azul.ToString(), valor = "CT", especial = true }),

            #endregion
            #region CartasVerdes
            (new Carta() { color = Colores.Verde.ToString(), valor = "1", especial = false }),
            (new Carta() { color = Colores.Verde.ToString(), valor = "2", especial = false }),
            (new Carta() { color = Colores.Verde.ToString(), valor = "3", especial = false }),
            (new Carta() { color = Colores.Verde.ToString(), valor = "4", especial = false }),
            (new Carta() { color = Colores.Verde.ToString(), valor = "5", especial = false }),
            (new Carta() { color = Colores.Verde.ToString(), valor = "6", especial = false }),
            (new Carta() { color = Colores.Verde.ToString(), valor = "7", especial = false }),
            (new Carta() { color = Colores.Verde.ToString(), valor = "8", especial = false }),
            (new Carta() { color = Colores.Verde.ToString(), valor = "9", especial = false }),
            (new Carta() { color = Colores.Verde.ToString(), valor = "X", especial = true }),
            (new Carta() { color = Colores.Verde.ToString(), valor = "MD", especial = true }),
            (new Carta() { color = Colores.Verde.ToString(), valor = "CT", especial = true }),

            #endregion
            #region CartasAmarillas
            (new Carta() { color = Colores.Amarillo.ToString(), valor = "1", especial = false }),
            (new Carta() { color = Colores.Amarillo.ToString(), valor = "2", especial = false }),
            (new Carta() { color = Colores.Amarillo.ToString(), valor = "3", especial = false }),
            (new Carta() { color = Colores.Amarillo.ToString(), valor = "4", especial = false }),
            (new Carta() { color = Colores.Amarillo.ToString(), valor = "5", especial = false }),
            (new Carta() { color = Colores.Amarillo.ToString(), valor = "6", especial = false }),
            (new Carta() { color = Colores.Amarillo.ToString(), valor = "7", especial = false }),
            (new Carta() { color = Colores.Amarillo.ToString(), valor = "8", especial = false }),
            (new Carta() { color = Colores.Amarillo.ToString(), valor = "9", especial = false }),
            (new Carta() { color = Colores.Amarillo.ToString(), valor = "X", especial = true }),
            (new Carta() { color = Colores.Amarillo.ToString(), valor = "MD", especial = true }),
            (new Carta() { color = Colores.Amarillo.ToString(), valor = "CT", especial = true }),
            #endregion
            #region CartasComodin
            (new Carta() { color = Colores.Comodin.ToString(), valor = "CL", especial = true }),
            (new Carta() { color = Colores.Comodin.ToString(), valor = "CL", especial = true }),
            (new Carta() { color = Colores.Comodin.ToString(), valor = "CL", especial = true }),
            (new Carta() { color = Colores.Comodin.ToString(), valor = "CL", especial = true }),
            (new Carta() { color = Colores.Comodin.ToString(), valor = "MC", especial = true }),
            (new Carta() { color = Colores.Comodin.ToString(), valor = "MC", especial = true }),
            (new Carta() { color = Colores.Comodin.ToString(), valor = "MC", especial = true }),
            (new Carta() { color = Colores.Comodin.ToString(), valor = "MC", especial = true }),
            #endregion
        };
        static void Main(string[] args)
        {
            string json;
            
            StreamWriter Serealizar = new StreamWriter("..\\..\\..\\..\\WinFormsApp1\\bin\\Debug\\net5.0-windows\\Carta.Json");
            foreach (Carta item in listaCompleta)
            {
                json = JsonSerializer.Serialize(item);
                Serealizar.WriteLine(json);
               
            }
            Serealizar.Close();
            Serealizar.Dispose();
        }

    }
   
}
    
