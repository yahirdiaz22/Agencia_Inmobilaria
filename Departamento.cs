using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Inmobilaria
{
    class Departamento : Inmueble
    {
        public Departamento(string tipo, double precio)
        {
           
        }
        public Departamento() : base()
        {
            TipoInmueble = "";
            Precio = 0;
        }
               public override string ToString()
        {
            return base.ToString() + Codigopostal + "" + Ubicacion + "" + Precio + "" + TipoInmueble + "" + Dormitorio + "";
        }
    }
    
}



