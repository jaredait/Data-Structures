using System;
using System.Collections.Generic;
using Proyecto_final;

public class Agregar
{
	public Queue<persona> ColaGeneral;

	public Agregar()
    {
		ColaGeneral = new Queue<persona>();
    }

	// Agregar una persona a la cola
	public void AgregarPersona(Persona persona)
	{
		ColaGeneral.Enqueue(persona);
	}

	public void LlenarColaGeneral()
    {
		
    }
}
