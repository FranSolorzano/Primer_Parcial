using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Parcial.Entidades
{
    class Venta
    {
        private double identificador_de_Producto;
        private String nombre_del_Producto;
        private String descripcion_del_Producto;
        private double precio_del_Producto;
        private int cantidad_del_Producto;
       


        public double Identificador_de_Producto { get => identificador_de_Producto; set => identificador_de_Producto = value; }
        public string Nombre_del_Producto { get => nombre_del_Producto; set => nombre_del_Producto = value; }
        public string Descripcion_del_Producto { get => descripcion_del_Producto; set => descripcion_del_Producto = value; }
        public double Precio_del_Producto { get => precio_del_Producto; set => precio_del_Producto = value; }
        public int Cantidad_del_Producto { get => cantidad_del_Producto; set => cantidad_del_Producto = value; }
       

        public Venta()
        {
        }

        public Venta(double identificaodor_de_Producto, string nombre_del_Producto, string descripcion_del_Producto, double precio_del_Producto, int cantidad_del_Producto)
        {
            this.Identificador_de_Producto = identificaodor_de_Producto;
            this.Nombre_del_Producto = nombre_del_Producto;
            this.Descripcion_del_Producto = descripcion_del_Producto;
            this.Precio_del_Producto = precio_del_Producto;
            this.Cantidad_del_Producto = cantidad_del_Producto;
        }

     
        

        public override string ToString()
        {
            return "el id de su producto es " + identificador_de_Producto +
                "\n el nombre de su producto es " + nombre_del_Producto +
                "\n la descripcion de su producto es" + descripcion_del_Producto +
                "\n el precio del prudcto es" + precio_del_Producto +
                "\n la cantidad de producto es " + cantidad_del_Producto;
        }
   
    }
}
