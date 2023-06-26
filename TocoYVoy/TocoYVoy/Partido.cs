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
        private String _lugar { get; set; }
        private static int _id { get; set; }
        private DateTime _fecha { get; set; }
        private DateTime _hora { get; set; }
        private int _totalJugadores { get; set; }
        private List<Jugador> _jugadoresConfirmados = new List<Jugador>();
        private Tipo _tipo { get; set; }
        private Estado _estado { get; set; }

        /* public Partido(string lugar, DateTime fecha, DateTime hora,
                         int totalJugadores, Tipo tipo)
        {
            _lugar = lugar;
            _fecha = fecha;
            _hora = hora;
            _totalJugadores = totalJugadores;
            _tipo = tipo;
            _estado = Estado.Activo;
        }

        public int MyProperty { get; set; }




             public Boolean agregarJugador (Jugador jug)
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
