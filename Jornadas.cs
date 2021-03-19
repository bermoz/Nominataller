using System;
using System.Collections.Generic;
using System.Text;

namespace Nominataller
{
    class Jornadas
    {
        private Operario operario;
        private RegistroEntradaSalida registroentradasalida;

        public Jornadas(Operario oper, RegistroEntradaSalida regentsal)
        {
            operario = oper;
            registroentradasalida = regentsal;
        }

        // Metodo Virtuales que se pueden reescribir una vez heredados.
        public virtual void Crear()
        {
            // Metodo ..
         

        }

        public virtual void Modificar()
        {

        }

        public virtual void Consultar()
        {

        }

        public virtual void Deshabilitar()
        {

        }
    }
}
