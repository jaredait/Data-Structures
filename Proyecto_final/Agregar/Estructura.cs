using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Como enviar una referencia de una form a otra
 * */

namespace Proyecto_final.Agregar
{
    public class Estructura
    {
		public Queue<Persona> ColaGeneral;

		public Estructura()
		{
			ColaGeneral = new Queue<Persona>();
		}

		// Agregar una persona a la cola
		public void AgregarPersona(Persona persona)
		{
			ColaGeneral.Enqueue(persona);
		}

		public Queue<Persona> Consultar()
        {
			return ColaGeneral;
        }

		public void LlenarColaGeneral()
		{
			Persona persona1 = new Persona("a", 20, false);
			Persona persona2 = new Persona("b", 20, true);
			Persona persona3 = new Persona("c", 20, false);
			Persona persona4 = new Persona("d", 20, true);
			Persona persona5 = new Persona("e", 20, false);
		}
	}
}
