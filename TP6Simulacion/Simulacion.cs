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
        private List<Queue<Proceso>> colasCPU;
        private Queue<Proceso> colaIO;
        private List<Evento> eventos;

        public Int32 cantidadProcesos { get; set; }
        public Int64 tiempo { get; set; }
        public Simulacion(Random r) {
            this.r = r;
        }

        public Simulacion(Random random, long cantidadNucleos)
        {
            this.random = random;
            this.tiempo = 0;
            List<Queue<Proceso>> colasCPU = new List<Queue<Proceso>>();
            
            for (int i = 0; i < cantidadNucleos; i++)
            {
                colasCPU.Add(new Queue<Proceso>());
            }

            colaIO = new Queue<Proceso>();
            eventos = new List<Evento>();
            eventos.Add(new Llegada(generarTiempoProximaLlegada()));
        }

        public Int32 generarTiempoProximaLlegada() {
            //Poner fdp
            return 5;
        }

    }
}
