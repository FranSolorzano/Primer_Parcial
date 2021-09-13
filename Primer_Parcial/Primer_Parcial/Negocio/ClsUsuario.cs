using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Primer_Parcial.Entidades;

namespace Primer_Parcial.Negocio
{
    class ClsUsuario
    {
        string usuario = "Franklin";
        int contraseña = 123;

        

            int y = 1;

            Usuario Cons = new Usuario();


            public string Acceso(Usuario Cons)
            {
                if (Cons.Nombre == usuario && Cons.Contra == contraseña)

                {
                    y = 1;
                    return "Has ingresado correctamente puedes continuar";
                }
                else
                    y = 2;
                return "No se a podido ingresar";



            }
        
    }
}
