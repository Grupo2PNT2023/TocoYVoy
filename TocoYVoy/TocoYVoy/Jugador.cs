using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TocoYVoy
{
    internal class Jugador
    {
        private String _nombre;
        private String _apellido;
        private static int _id;
        private DateTime _nacimiento;
        private Puesto _puesto;
        private String _piernaHabil;
        private Sexo _sexo;

        public Jugador(string nombre, string apellido, DateTime nacimiento,
                        Puesto puesto, string piernaHabil, Sexo sexo)
        {
            _nombre = nombre;
            _apellido = apellido;
            _nacimiento = nacimiento;
            _puesto = puesto;
            _piernaHabil = piernaHabil;
            _sexo = sexo;
            _id++;
        }

        public int id { get; set; }

        public Sexo sexo { get; set; }
    }
}
