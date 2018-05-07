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
        private Queue<Proceso> colasCPU;
        private Queue<Proceso> colaIO;
        private List<Evento> eventos;
        private Int32 procesosFinalizados;
        private Int32 sumatoriasInicioEsperaProceso;
        private Int32 sumatoriasFinEsperaProceso;
        private Int32 sumatoriasInicioTiempoOciosoCPU;
        private Int32 sumatoriasFinTiempoOciosoCPU;

        public Int32 cantidadFinalProcesos { get; set; }
        public Int64 tiempo { get; set; }
        public Simulacion(Random r)
        {
            this.r = r;
        }

        public Simulacion(Random random, long cantidadNucleos)
        {
            this.random = random;
            this.tiempo = 0;
            this.procesosFinalizados = 0;
            List<Queue<Proceso>> colasCPU = new List<Queue<Proceso>>();

            for (int i = 0; i < cantidadNucleos; i++)
            {
                colasCPU.Add(new Queue<Proceso>());
            }

            colaIO = new Queue<Proceso>();
            eventos = new List<Evento>();

        }

        public void iniciarSimulacion()
        {
            while (procesosFinalizados < cantidadFinalProcesos && eventos.Count != 0)
            {
                if (eventos.Count == 0)
                {
                    Llegada e = new Llegada();
                    e.tiempoOcurrencia = e.generarTiempoProximaLlegada();
                    eventos.Add(e);
                }
                else
                {
                    eventos.Sort();
                    Evento e = eventos[0];
                    tiempo = e.tiempoOcurrencia;
                    Evento eventoFuturo = e.ejecutar(colasCPU, colaIO);  //Falta ver donde se almacenan las variables auxiliares de los resultados, si en el evento o el proceso
                    if (eventoFuturo != null)
                    {
                        eventos.Add(eventoFuturo);
                    }
                }
            }
        }


    }
}

