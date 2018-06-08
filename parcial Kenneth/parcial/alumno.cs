using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial
{
    class alumno
    {
        string nombre;
        int  carne;

        public string Nombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        public int Carne
        {
            set { this.carne = value; }
            get { return this.carne; }
        }

    }
}
