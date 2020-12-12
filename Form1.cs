using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia_Inmobilaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCabaña_Click(object sender, EventArgs e)
        {
            Inmueble casa = new Inmueble();
            casa.Precio = 150000;
            casa.TipoInmueble = " Cabaña ";
            casa.Ubicacion = " Avenida los rios ";
            casa.Dormitorio = " 3 dormitorios ";
            casa.Codigopostal = 20112;
            casa.Vender();
            MessageBox.Show(casa.ToString());
            MessageBox.Show(" Se ha vendido correctamente ");
        }

        private void btnCasacampo_Click(object sender, EventArgs e)
        {
            Inmueble casa = new Inmueble();
            casa.Precio = 50000;
            casa.TipoInmueble = " Cabaña ";
            casa.Ubicacion = " Avenida los rios ";
            casa.Dormitorio = " 3 dormitorios ";
            casa.Codigopostal = 20451;
            casa.Vender();
            MessageBox.Show(casa.ToString());
            MessageBox.Show(" Se  ha vendido correctamente ");
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMasnsion_Click(object sender, EventArgs e)
        {
            Inmueble casa = new Inmueble();
            casa.Precio = 2000000;
            casa.TipoInmueble = " Mansion ";
            casa.Ubicacion = " Holywood ";
            casa.Dormitorio = " 10 dormitorios ";
            casa.Codigopostal = 20157;
            casa.Alquilar();
            MessageBox.Show(casa.ToString());
            MessageBox.Show(" Se ha alquidado exitosamente ");
        }

        private void btnCasaplaya_Click(object sender, EventArgs e)
        {
            Inmueble casa = new Inmueble();
            casa.Precio = 37000;
            casa.TipoInmueble = " Casa Playa ";
            casa.Ubicacion = " Zona Centro ";
            casa.Dormitorio = " 2 dormitorios ";
            casa.Codigopostal = 50399;
            casa.Vender();
            MessageBox.Show(casa.ToString());
            MessageBox.Show(" Se ha vendido exitosamente ");
        }

        private void btnCasaprefabricada_Click(object sender, EventArgs e)
        {
            Inmueble casa = new Inmueble();
            casa.Precio = 130000;
            casa.TipoInmueble = " Casa Prefabricada ";
            casa.Ubicacion = " Colonia guadalupe ";
            casa.Dormitorio = " 5 dormitorios ";
            casa.Codigopostal = 18990;
            casa.Registrar();
            MessageBox.Show(casa.ToString());
            MessageBox.Show(" Se ha registrado correctamente ");
        }

        private void btnCasaunifamiliar_Click(object sender, EventArgs e)
        {
            Inmueble casa = new Inmueble();
            casa.Precio = 1890000;
            casa.TipoInmueble = " Casa Unifamiliar ";
            casa.Ubicacion = " Ampliacion las flores ";
            casa.Dormitorio = " 10 dormitorios ";
            casa.Codigopostal = 20987;
            casa.Alquilar();
            MessageBox.Show(casa.ToString());
            MessageBox.Show("Se ha registrado correctamente ");
        }

        private void btnDepartamentoduplex_Click(object sender, EventArgs e)
        {
            Inmueble departamento = new Inmueble();
            departamento.Precio = 3800;
            departamento.TipoInmueble = " Departamento Duplex ";
            departamento.Ubicacion = " Mazatlan ";
            departamento.Dormitorio = " 2 dormitorios ";
            departamento.Codigopostal = 20987;
            departamento.Alquilar();
            MessageBox.Show(departamento.ToString());
            MessageBox.Show("Se ha alquilado correctamente ");
        }
        private void btnRegistar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("se ha registrado correctamente");

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            MessageBox.Show("se ha vendido correctamente");
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("se ha alquilado correctamente");
        }

        private void btnPenhouse_Click(object sender, EventArgs e)
        {
            Inmueble departamento = new Inmueble();
            departamento.Precio = 2300000;
            departamento.TipoInmueble = " Departamento Penhouse ";
            departamento.Ubicacion = " Cancun ";
            departamento.Dormitorio = " 3 dormitorios ";
            departamento.Codigopostal = 09351;
            departamento.Vender();
            MessageBox.Show(departamento.ToString());
            MessageBox.Show("Se ha vendido correctamente ");
        }
    }
}

