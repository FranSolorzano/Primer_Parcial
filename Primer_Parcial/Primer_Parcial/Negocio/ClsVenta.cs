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
        public string Cobro(Venta cobro)

        {
            cobro.Total  = (cobro.Precio_del_Producto * cobro.Cantidad_del_Producto);

            if (cobro.Total > 50)
            {
                cobro.Descuento = cobro.Total - (cobro.Total * 0.50);
                return("Usted esta aplicando al 20 % de descuento, por lo cual su total es de:  " + cobro.Descuento);
            }
            else
            {
                return ("Usted no esta aplicando al descuento, por lo tanto su total es de: " + cobro.Total);
            }
        }
    }
}
