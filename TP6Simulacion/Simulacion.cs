using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6Simulacion
{
    public class Simulacion
    {
        Random r;
        private Random random;
        private long cantidadNucleos;
        public List<Queue<Proceso>> colasCPU;

        public Int64 tiempo { get; set; }
        public Simulacion(Random r) {
            this.r = r;
        }

        public Simulacion(Random random, long cantidadNucleos)
        {
            this.random = random;
            List<Queue<Proceso>> colasCPU = new List<Queue<Proceso>>();
            for (int i = 0; i < cantidadNucleos; i++)
            {
                colasCPU.Add(new Queue<Proceso>());
            }
        }

        public Int64 generarTiempoProximaLlegada() {
            //Poner fdp
            return 5;
        }

    }
}
