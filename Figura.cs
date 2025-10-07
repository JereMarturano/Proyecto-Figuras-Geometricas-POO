using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoEnClase15092025
{
    public abstract class Figura
    {
        public abstract string Nombre { get; set; }
        public abstract decimal CalcularPerimetro();
        public abstract decimal CalcularArea();
        
    }
}
