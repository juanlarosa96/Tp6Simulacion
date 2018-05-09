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
    public partial class FormPrincipal : Form
    {
        Simulacion simulacion;
        public FormPrincipal()
        {
            InitializeComponent();
            simulacion = new Simulacion(new Random());
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {            
            
            Resultados.inicializar(Convert.ToInt32(numNucleos.Value));

            simulacion.cantidadFinalProcesos = Convert.ToInt32(numProcesos.Value);
            simulacion.cantidadNucleos = Convert.ToInt32(numNucleos.Value);

            this.simulacion.iniciarSimulacion();


            lblTiempoEsperaPromedio.Text = Resultados.calcularTiempoPromedioEspera().ToString() + " Ns";

            
            lblTiempoOciosoPromedio.Text = Resultados.calcularTiempoOciosoPromedio().ToString() + " Ns";

            
            lblTiempoOciosoPorcentaje.Text =  Math.Round(Resultados.calcularPorcentajeTiempoOcioso(), 2).ToString() + "%";
            
            lblTiempo.Text = Resultados.tiempoFinal.ToString() + " Ns";

            simulacion.clear();
        }
    }
}
