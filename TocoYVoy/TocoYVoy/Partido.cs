using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TocoYVoy
{
    public class Partido
    {
        private String _lugar;
        
        private DateTime _fecha;
        private TimeOnly _hora;
        private int _totalJugadores;
        private List<Jugador> _jugadoresConfirmados = new List<Jugador>();
        private Tipo _tipo;
        private Estado _estado;

        public Partido(string lugar, DateTime fecha, TimeOnly hora,
                         int totalJugadores, Tipo tipo, Estado estado)
        {
            _lugar = lugar;
            _fecha = fecha;
            _hora = hora;
            _totalJugadores = totalJugadores;
            _tipo = tipo;
            _estado = estado;
        }

        public int MyProperty { get; set; }




        /*     public Boolean agregarJugador (Jugador jug)
            {
                Boolean sePudo = false;
                _jugadoresConfirmados.Add(jug);

                return sePudo;
            }

            public Boolean cumpleRequisitos (Jugador jug)
            {
                return false;
            }

            public Boolean buscarJugador(Jugador jug)
            {
                Boolean esta = false;
                Jugador jugadorBuscado = null;
                int idx = 0;
                    while(jugadorBuscado == null && !esta) { 

                }
                return esta;
            }

            */
    }
}
