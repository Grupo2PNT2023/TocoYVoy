using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TocoYVoy
{
    public class Jugador
    {
        private String _nombre { get; set; }
        private String _apellido { get; set; }
        private static int _id { get; set; }
        private DateTime _nacimiento { get; set; }
        private Puesto _puesto { get; set; }
        private PiernaHabil _piernaHabil { get; set; }
        private Sexo _sexo { get; set; }

        /*   public Jugador(string nombre, string apellido, DateTime nacimiento,
                           Puesto puesto, PiernaHabil piernaHabil, Sexo sexo)
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
        */
    }

}
