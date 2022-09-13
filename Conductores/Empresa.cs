using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conductores;

namespace Conductores
{
    public class Empresa
    {
        Conductor[] conductores;

        private Empresa()
        {
            conductores = new Conductor[3];
        }

        public Empresa(Conductor[] conductores) : this()
        {
            this.conductores = conductores;
        }
    }
}
