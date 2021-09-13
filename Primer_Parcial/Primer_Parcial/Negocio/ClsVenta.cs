using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Primer_Parcial.Entidades;
using Primer_Parcial.Negocio;

namespace Primer_Parcial.Negocio
{
    class ClsVenta
    {
        public string Cobro(Venta vent)
        {
            double total = vent.Precio_del_Producto * vent.Cantidad_del_Producto;

            if (vent.Precio_del_Producto > 50)
            {
                double descuento = total - (total * 0.20);
                Console.WriteLine("Usted esta aplicando al 20 % de descuento de descuento, por lo cual su total es de:  " + descuento);
            }
            else
            {
                Console.WriteLine("Usted no esta aplicando al descuento, por lo tanto su total es de: " + total);
            }

            return "";
        }
    }
}
