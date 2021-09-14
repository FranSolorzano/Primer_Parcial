using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Parcial.Entidades
{
    class Usuario
    {
        private String nombre;
        private int contra;
       


        public string Nombre { get => nombre; set => nombre = value; }
        public int Contra { get => contra; set => contra = value; }
       
        public Usuario()
        {
        }

        public Usuario(string nombre, int contra)
        {
            this.Nombre = nombre;
            this.Contra = contra;
        }

        public override String ToString()
        {
            return "su nombre de usuario es: " + Nombre + " su clave es: " + Contra;
        }


    }
}
