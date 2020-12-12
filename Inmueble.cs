using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Inmobilaria
{
    class Inmueble
    {
        public string TipoInmueble;

        public string Ubicacion;

        public double Precio;

        public int Codigopostal;

        public string Dormitorio;
        public string TipoInmueble1 { get => TipoInmueble; set => TipoInmueble = value; }
        public string Ubicacion1 { get => Ubicacion; set => Ubicacion = value; }
        public double Precio1 { get => Precio; set => Precio = value; }
        public int Area1 { get => Codigopostal; set => Codigopostal = value; }
        public string Dormitorio1 { get => Dormitorio; set => Dormitorio = value; }
        public void Registrar()
        {

        }
        public void Vender()
        {

           
        }
        public void Alquilar()
        {
            
        }

        public Inmueble(string tipo, double precio)
        {

            TipoInmueble1 = tipo;
            Precio1 = precio;
        }
       
        public Inmueble() 
        {
        }
        public override string ToString()

        {
            return  +Codigopostal + " " + Ubicacion + "" + Precio + "$" + TipoInmueble + "  " + Dormitorio + " ";
        }
    }
}
