using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktoberFest
{
    class Jarra
    {
        public decimal capacidadEnLitros { get; set; }
        public Marca marca { get; set; }
        public decimal litrosDeAlcohol() 
        {
            return capacidadEnLitros * marca.graduacionAlcoholica;
        }

        public bool jarraDeLitro() 
        {
            return capacidadEnLitros == 1;
        }
    }
}
