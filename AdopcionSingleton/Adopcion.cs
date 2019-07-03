using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopcionSingleton
{
    class Adopcion
    {
        public Persona PersonaAdopta { set; get; }
        public Perro PerroAdopta { set; get; }
        public DateTime FechaAdopcion
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}
