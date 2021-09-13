using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Primer_Parcial.Entidades;
using Primer_Parcial.Negocio;

namespace Primer_Parcial.Negocio
{
    class ClsUsuario
    {
        string usuario = "Ronald";
        Double contraseña = 123;
        public int y = 1;

        Usuario Cons = new Usuario();


        public string Acceso(Usuario Cons)
        {
            if (Cons.Nombre == usuario && Cons.Contra == contraseña)

            {
                y = 1;
                return "Has logrado ingresar correctamente puedes continuar";
            }
            else
                y = 2;
            return "No has podido ingresar de forma correcta";
        }





    }
}
