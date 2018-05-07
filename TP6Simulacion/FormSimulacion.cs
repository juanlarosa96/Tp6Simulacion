using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP6Simulacion
{
    public partial class FormSimulacion : Form
    {

        Int64 cantidadNucleos;
        Simulacion simulacion;
        private decimal p;

        public FormSimulacion()
        {
            InitializeComponent();
        }

        public FormSimulacion(Int64 cantidadNucleos)
        {
            InitializeComponent();
            this.cantidadNucleos = cantidadNucleos;
            this.simulacion = new Simulacion(new Random(), cantidadNucleos);
        }


        private void FormSimulacion_Load(object sender, EventArgs e)
        {
            List<Evento> lista = new List<Evento>();
            lista.Add(new SalidaCPU());
            lista.Add(new Llegada());
            lista.Add(new SalidaIO());
            lista[0].tiempoOcurrencia = 3;
            lista[1].tiempoOcurrencia = 1;
            lista[2].tiempoOcurrencia = 2;
            lista.Sort();
        }
    }
}
