using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktoberFest
{
    class Persona
    {
        public decimal peso { get; set; }
        List<Jarra> jarrasCompradas { get; set; }
        public bool gustaDeLaMusicaTradicional { get; set; }
        public decimal aguante { get; set; }
        public virtual bool leGusta(Marca marca) 
        {
            return true;
        }
        public decimal litrosQueIngirio() 
        {
            return jarrasCompradas.Select(s => s.litrosDeAlcohol()).Sum();
        }
        public bool estaEbrio() 
        {
            return litrosQueIngirio() > aguante;
        }
        public bool quiereEntrar(Carpa carpa) 
        {
            return carpa.musicaTradicional == gustaDeLaMusicaTradicional
                && leGusta(carpa.jarra.marca);
        }
        public bool puedeEntrar(Carpa carpa) 
        {
            return quiereEntrar(carpa) && carpa.dejaEntrar(this);
        }

        public void entrar(Carpa carpa) 
        {
            carpa.dejarPasar(this);
        }

        public void comprarJarra(Jarra jarra) 
        {
            jarrasCompradas.Add(jarra);
        }

        public bool ebrioEmpedernido() 
        {
            return jarrasCompradas.All(j => j.jarraDeLitro());
        }

        public int cantidadDeJarras()
        {
            return jarrasCompradas.Count;
        }
    }

    class Belga : Persona
    {
        public override bool leGusta(Marca marca)
        {
            return base.leGusta(marca) && marca.pais == "belgica";
        }
    }
    class Checo : Persona
    {
        public override bool leGusta(Marca marca)
        {
            return base.leGusta(marca) && marca.graduacionAlcoholica > (decimal)0.08;
        }
    }
    class Aleman : Persona
    {
        public override bool leGusta(Marca marca)
        {
            return base.leGusta(marca);
        }
    }
}
