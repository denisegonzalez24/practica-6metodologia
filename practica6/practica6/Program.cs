/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 12/11/2024
 * Time: 22:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica6
{
	class Program
    {
        public static void Main(string[] args)
        {
        	Console.WriteLine("Primer juego.... Truco");
            Persona j1 = new Persona("Carla");
            Persona j2 = new Persona("Camila");

            Truco truco1 = new Truco();
            Persona ganador = truco1.jugar(j1, j2);

            ganador.festejar();
            j1.puntos =0;
            j2.puntos =0;
            
            Console.WriteLine("\n");
            Console.WriteLine("Segundo juego.... Chinchon");
            	
            Chinchon chinchon = new Chinchon();
            Persona ganador2 = chinchon.jugar(j1,j2);
            
            ganador2.festejar();
            
            Console.ReadKey(true);
        }
    }
}