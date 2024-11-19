/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 12/11/2024
 * Time: 22:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica6
{
	/// <summary>
	/// Description of Truco_cs.
	/// </summary>S
	public class Truco : JuegoDeCartas
    {
        protected override void mezclarMazo()
        {
            Console.WriteLine("Mezclando el mazo...");
        }

        protected override void repartirCartasIniciales()
        {
            Console.WriteLine("Repartiendo cartas iniciales...");
        }

        protected override void jugarRonda(Persona jugador)
        {
            Console.WriteLine(jugador.nombre + " juega una mano.");
            jugador.agregarPuntos(new Random().Next(1, 10));
        }
        protected override bool ganoElJuego(Persona j1, Persona j2)
        {
            return j1.puntos >= 30 || j2.puntos >= 30;
        }

        protected override Persona determinarGanador(Persona j1, Persona j2)
        {
            if (j1.puntos >= 30) return j1;
            return j2;
        }
    }
	
}