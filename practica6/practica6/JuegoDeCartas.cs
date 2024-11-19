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
	/// Description of JuegoDeCartas.
	/// </summary>
	public abstract class JuegoDeCartas
	{
		
		
		protected abstract void mezclarMazo();
        protected abstract void repartirCartasIniciales();
        protected abstract void jugarRonda(Persona jugador);
        protected abstract bool ganoElJuego(Persona j1, Persona j2);
        protected abstract Persona determinarGanador(Persona j1, Persona j2);
        
        public Persona jugar(Persona j1, Persona j2)
        {
            mezclarMazo();
            repartirCartasIniciales();

            while (!ganoElJuego(j1, j2))
            {
                jugarRonda(j1);
                jugarRonda(j2);
            }
            return determinarGanador(j1, j2);
        }
    }
		
}
		
	

