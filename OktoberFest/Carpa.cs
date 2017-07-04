using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktoberFest
{
    class Carpa
    {
        public int limiteDeGenteAdmitida { get; set; }
        public bool musicaTradicional { get; set; }
        public Jarra jarra { get; set; }
        List<Persona> personas { get; set; }

        public bool dejaEntrar(Persona persona) 
        {
            return !superaElLimite() && !persona.estaEbrio(); 
        }

        public bool superaElLimite() 
        {
            return personas.Count + 1 > limiteDeGenteAdmitida;
        }

        public void dejarPasar(Persona persona) 
        {
            if (!persona.puedeEntrar(this))
                throw new Exception("No Puede Entrar");    
            personas.Add(persona);
            persona.comprarJarra(venderJarra());
        }
        
        public Jarra venderJarra() 
        {
            return new Jarra() 
            {
                capacidadEnLitros = jarra.capacidadEnLitros,
                marca = jarra.marca
            };
        }

        public int cantidadDeEbriosEmpedernidos() 
        {
            return personas.Count(p => p.ebrioEmpedernido());
        }

    }
}
