using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Primer_Parcial.Entidades;
using Primer_Parcial.Negocio;

namespace Primer_Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, presione 1 en dos ocaciones para continuar");
            String nombre = Console.ReadLine();
            int contra = Convert.ToInt32(Console.ReadLine());

            Usuario Cons = new Usuario(nombre, contra);
            ClsUsuario clsUsuario = new ClsUsuario();

            Console.WriteLine("Por favor ingrese el nombre del usuario"); //El nombre es: Franklin
            Cons.Nombre = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Por favor ingresar su contraseña de ingreso"); //La contraseña es: 123
            Cons.Contra = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(clsUsuario.Acceso(Cons));

            Venta venta = new Venta();

            if (clsUsuario.y == 1)
            {
                int x = 1;
                while (x == 1)
                {
                    Console.WriteLine("Por favor ingresar el id que tiene el producto");
                    double identificador_de_Producto = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingresar el nombre del producto a llevar");
                    string nombre_del_Producto = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Ingrese la descripcion que contiene el producto");
                    string descripcion_del_Producto = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Ingresar el precio que tiene el producto");
                    double precio_del_Producto = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingresar el numero de cantidad de producto a llevar");
                    int cantidad_del_Producto = Convert.ToInt32(Console.ReadLine());

                    ClsVenta clsventa = new ClsVenta();

                    Venta vent = new Venta(identificador_de_Producto, nombre_del_Producto, descripcion_del_Producto, precio_del_Producto, cantidad_del_Producto);
                    Console.WriteLine(clsventa.Cobro(vent));

                    Console.ReadLine();

                }
            }




        }
    }
}
