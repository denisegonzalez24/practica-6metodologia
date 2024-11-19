/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 12/11/2024
 * Time: 22:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica6
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		public string nombre {get; set;}
		public int puntos {get; set;}
		
		public Persona(string nom)
		{
			nombre = nom;
			puntos =0;
		}
		
		public void agregarPuntos(int p)
		{
			puntos += p;
		}
		public void festejar()
		{
			Console.WriteLine("Yo {0} gane! con {1} puntos ", nombre, puntos);
		}
	}
}
