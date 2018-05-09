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

        Int32 cantidadNucleos;
        Int32 cantidadProcesos;
        Simulacion simulacion;
        private decimal p;

        public FormSimulacion()
        {
            InitializeComponent();
        }

        public FormSimulacion(Int32 cantidadNucleos, Int32 cantidadProcesos)
        {
            InitializeComponent();
            Resultados.inicializar(cantidadNucleos);
            this.cantidadNucleos = cantidadNucleos;
            this.cantidadProcesos = cantidadProcesos;
            this.simulacion = new Simulacion(new Random(), cantidadNucleos, cantidadProcesos);

        }


        private void FormSimulacion_Load(object sender, EventArgs e)
        {
            List<Evento> lista = new List<Evento>();
            this.simulacion.iniciarSimulacion();
            Double a = Resultados.calcularTiempoPromedioEspera();
            numTiempoEsperaPromedio.Value = Convert.ToDecimal(Resultados.calcularTiempoPromedioEspera());
            numTiempoOciosoPromedio.Value = Convert.ToDecimal(Resultados.calcularTiempoOciosoPromedio());
            numPorcentajeTiempoOcioso.Value = Convert.ToDecimal(Resultados.calcularPorcentajeTiempoOcioso());
            txtCantidadProcesosTotales.Text = Resultados.cantidadProcesosTotales.ToString();
            txtTiempo.Text = Resultados.tiempoFinal.ToString();
            simulacion.clear();

        }



    }
}
