using System;

namespace Cafeteria
{
    public class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }

    public class Pedido
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public bool ParaLlevar { get; set; }
        public decimal Subtotal { get; set; }
    }
}