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
        private int y = 1;


        public string Nombre { get => nombre; set => nombre = value; }
        public int Contra { get => contra; set => contra = value; }
        public int Y { get => y; set => y = value; }

        public Usuario()
        {
        }

        public Usuario(string nombre, int contra)
        {
            this.Nombre = nombre;
            this.Contra = contra;
        }

        public Usuario(int y)
        {
            this.y = y;
        }
    
    }
}
