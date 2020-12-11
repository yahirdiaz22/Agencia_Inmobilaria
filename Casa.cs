using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Inmobilaria
{
    class Casa : Inmueble 
    {
        public Casa(string tipo, double precio)
        {
            TipoInmueble1 = tipo;
            Precio1 = precio;
        }
        public Casa() : base()
        {
            TipoInmueble = "";
            Precio = 0;
            Ubicacion = "";
            Codigopostal = 0;
            Dormitorio = "";
            
        }
        public override string ToString()
        {
            return base.ToString() + Codigopostal + "" + Ubicacion +""+Precio +""+ TipoInmueble+"" + Dormitorio+"";
        }
    }
}
