using System;

namespace ClassLibrary1
{
    public class Usuario

    {
        public string nombre;
        public string contrasenia;

        public Usuario(string nombre, string contrasenia)
        {
            this.nombre = nombre;
            this.contrasenia = contrasenia;
        }
        public Usuario()
        {
            this.nombre = "";
            this.contrasenia = "";
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
    }
}
