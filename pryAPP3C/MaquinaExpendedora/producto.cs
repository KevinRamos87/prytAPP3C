using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryMaquinaexpendedora
{
    internal class producto
    {
        private string nombre;
        private int existenciastock;
        private float precio;

        public string Nombre
        {
            get { return nombre; }
        }

        public int Stock
        {
            get { return existenciastock; }
        }

        public float Precio
        {
            get { return precio; }
        }


        public producto(string nombre, int cantidad, float precio)
        {
            this.nombre = nombre;
            this.existenciastock = cantidad;
            this.precio = precio;

        }

        public string mostrarproducto()
        {
            return "Producto: " + nombre + "      Precio:   $ " + precio + "         Cantidad disponible: " + existenciastock;

        }

        public string hacerCompra(int cantidadallevar)
        {
            if (cantidadallevar >0 && existenciastock >= cantidadallevar)
            {
                float total = cantidadallevar * precio;
                existenciastock = existenciastock - cantidadallevar;
                return "Compra realizada. Total a pagar: " + total;
            }
            else
            {
                return "Exitencias insuficientes";
            }
        }

        public string Abastecer(int cantidad_demas)
        {
            if (cantidad_demas <= 0)
            {
                return "Error: La cantidad a surtir debe ser mayor a cero";
            }
            else
            {
                existenciastock = existenciastock + cantidad_demas;

                return "El inventario se actualizo correctamente";
            }
        }


    }
}
