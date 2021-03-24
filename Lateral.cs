using System;

enum Estado{
    estatico,
    corriendo
}

namespace OOP_Example
{
    class Lateral: JugadorFutbol, IVelocista
    {
        public Estado estadoDeJuego;
        private int velocidad_KMH;
        private string nivelDesgaste;
        public Lateral(int _velocidad, string _nivelDeDesgaste){
            this.estadoDeJuego = Estado.estatico;
            this.velocidad_KMH = _velocidad;
            this.nivelDesgaste = _nivelDeDesgaste;
        }
        public void ataqueAlEspacio(){
            this.estadoDeJuego = Estado.corriendo;
        }
        public void defenderPosicionalmente(){
            this.estadoDeJuego = Estado.estatico;
        }

        public void comunicarEstadoDeJuego(){
            Console.Write($"Estoy {this.estadoDeJuego}");
        }
        public int obtenerVelocidad(){
            return this.velocidad_KMH;
        }
        public string obtenerNivelDesgaste(){
            return this.nivelDesgaste;
        }

    }
}
