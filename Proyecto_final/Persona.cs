using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool terceraEdad;
        public bool Discapacidad { get; set; }

        // Constructor
        public Persona()
        {
            Nombre = "";
            Edad = 0;
            TerceraEdad = false;
            Discapacidad = false;
        }
        public Persona(string nombre, int edad, bool discapacidad)
        {
            Nombre = nombre;
            Edad = edad;
            Discapacidad = discapacidad;
        }

        public bool TerceraEdad
        {
            get
            {
                if (Edad >= 65)
                    return true;
                else
                    return false;
            }
            set
            {
                terceraEdad = value;
            }
        }
    }
}
