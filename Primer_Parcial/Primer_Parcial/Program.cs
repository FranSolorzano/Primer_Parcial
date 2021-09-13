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

            Console.ReadLine();

           


        }
    }
}
