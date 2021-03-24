using System;

namespace OOP_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Lateral RobertoCarlos = new Lateral(38, "poco");

            RobertoCarlos.ataqueAlEspacio();
            RobertoCarlos.comunicarEstadoDeJuego();

            RobertoCarlos.defenderPosicionalmente();
            RobertoCarlos.comunicarEstadoDeJuego();

            JugadorFutbol jugadorDeFutbol = new Lateral(36,"medio");
            IVelocista velocista = new Lateral(39, "medio");
        }
    }
}
