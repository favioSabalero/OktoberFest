using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktoberFest
{
    class Juego
    {
        public decimal limiteDeAlcoholEnSangre { get; set; }
        public bool puedeJugar(Persona persona) 
        {
            return tomoAlMenosUnaJarra(persona) && alcanzoElLimiteDeAlcohol(persona);
        }

        public bool tomoAlMenosUnaJarra(Persona persona) 
        {
            return persona.cantidadDeJarras() > 0;
        }

        public bool alcanzoElLimiteDeAlcohol(Persona persona) 
        {
            return persona.litrosQueIngirio() < limiteDeAlcoholEnSangre;
        }
    }
}
