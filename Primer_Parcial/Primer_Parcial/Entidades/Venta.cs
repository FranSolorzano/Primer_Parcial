using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Parcial.Entidades
{
    class Venta
    {
        private String identificaodor_de_Producto;
        private String nombre_del_Producto;
        private String descripcion_del_Producto;
        private double precio_del_Producto;
        private int cantidad_del_Producto;


        public string Identificaodor_de_Producto { get => identificaodor_de_Producto; set => identificaodor_de_Producto = value; }
        public string Nombre_del_Producto { get => nombre_del_Producto; set => nombre_del_Producto = value; }
        public string Descripcion_del_Producto { get => descripcion_del_Producto; set => descripcion_del_Producto = value; }
        public double Precio_del_Producto { get => precio_del_Producto; set => precio_del_Producto = value; }
        public int Cantidad_del_Producto { get => cantidad_del_Producto; set => cantidad_del_Producto = value; }

        public Venta()
        {
        }

        
    }
}
