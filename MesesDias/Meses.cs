using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesesDias
{
    internal class Meses
    {
        public string Mes { get; set; }
        public int Dias { get; set; }

        public override string ToString()
        {
            return $"El mes selecionado es {Mes} y tine {Dias}";
        }
    }
}
