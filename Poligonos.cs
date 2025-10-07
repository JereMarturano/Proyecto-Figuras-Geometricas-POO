using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoEnClase15092025
{
    public abstract class Poligonos : Figura
    {
        public decimal Lado1 { get; set; }
        public int CantidadLados{ get; set; }
    }

    public class Cuadrado : Poligonos
    {
        public override string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override decimal CalcularArea()
        {
            throw new NotImplementedException();
        }

        public override decimal CalcularPerimetro()
        {
            throw new NotImplementedException();
        }
    }

    public class Rectangulo : Poligonos
    {
        public override string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override decimal CalcularArea()
        {
            throw new NotImplementedException();
        }

        public override decimal CalcularPerimetro()
        {
            throw new NotImplementedException();
        }
    }

    public abstract class Triangulo : Poligonos
    {
        public abstract decimal Base { get; set; }
        public abstract decimal Altura { get; set; }
    }

    public class Equilatero : Triangulo
    {
        // MÉTODOS Y PROP DE TRIANGULO
        public override decimal Base { get; set; }

        public override decimal Altura { get; set; }

        // MÉTODOS Y PROP DE FIGURA
        public override string Nombre
        {
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

    public class Isoceles : Triangulo
    {
        public override decimal Base
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public override decimal Altura
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public override string Nombre
        {
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
