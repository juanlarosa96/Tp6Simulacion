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
        List<Queue<Proceso>> colasCPU;

        public FormSimulacion()
        {
            InitializeComponent();
        }

        public FormSimulacion(Int64 cantidadNucleos)
        {
            InitializeComponent();
            this.cantidadNucleos = cantidadNucleos;
        }

        private void FormSimulacion_Load(object sender, EventArgs e)
        {
            List<Queue<Proceso>> colasCPU = new List<Queue<Proceso>>();
            for (int i = 0; i < cantidadNucleos; i++) {
                colasCPU.Add(new Queue<Proceso>());
            }
        }
    }
}
