using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoEnClase15092025
{
    public abstract class Conico : Figura
    {
        public abstract decimal Radio { get; set; }
    }

    public class Circunferencia : Conico
    {
        // MÉTODO DE CONICO
        public override decimal Radio { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException();
        }
        // MÉTODO DE FIGURA
        public override string Nombre { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public override decimal CalcularArea()
        {
            throw new NotImplementedException();
        }

        public override decimal CalcularPerimetro()
        {
            throw new NotImplementedException();
        }
    }

    public class Eclipse : Conico
    {
        public override decimal Radio { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public override string Nombre { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public override decimal CalcularArea()
        {
            throw new NotImplementedException();
        }

        public override decimal CalcularPerimetro()
        {
            throw new NotImplementedException();
        }
    }
}
