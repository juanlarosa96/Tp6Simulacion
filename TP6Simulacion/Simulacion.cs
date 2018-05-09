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
        private Queue<Proceso> colaCPU;
        private Queue<Proceso> colaIO;
        private List<Evento> eventos;
        private Int32 procesosFinalizados;
        private Int32 sumatoriasInicioEsperaProceso;
        private Int32 sumatoriasFinEsperaProceso;
        private Int32 sumatoriasInicioTiempoOciosoCPU;
        private Int32 sumatoriasFinTiempoOciosoCPU;
        private Int32 finesRafagaTotales;
        public Int32 cantidadFinalProcesos { get; set; }
        public Int32 cantidadNucleos { get; set; }
        public Int32 tiempo { get; set; }

        public Simulacion(Random r)
        {
            this.r = r;
            this.tiempo = 0;
            this.procesosFinalizados = 0;
            this.sumatoriasFinEsperaProceso = 0;
            this.sumatoriasFinTiempoOciosoCPU = 0;
            this.sumatoriasInicioEsperaProceso = 0;
            this.sumatoriasInicioTiempoOciosoCPU = 0;
            finesRafagaTotales = 0;
            this.cantidadNucleos = cantidadNucleos;
            Resultados.nucleos = cantidadNucleos;

            colaCPU = new Queue<Proceso>();
            colaIO = new Queue<Proceso>();
            eventos = new List<Evento>();

        }

        public Simulacion(Random random, Int32 cantidadNucleos, Int32 cantidadProcesos)
        {
            this.random = random;
            this.tiempo = 0;
            this.procesosFinalizados = 0;
            this.sumatoriasFinEsperaProceso = 0;
            this.sumatoriasFinTiempoOciosoCPU = 0;
            this.sumatoriasInicioEsperaProceso = 0;
            this.sumatoriasInicioTiempoOciosoCPU = 0;
            this.cantidadFinalProcesos = cantidadProcesos;
            finesRafagaTotales = 0;

            cantidadFinalProcesos = cantidadProcesos;
            this.cantidadNucleos = cantidadNucleos;

            Resultados.nucleos = cantidadNucleos;
            colaCPU = new Queue<Proceso>();
            colaIO = new Queue<Proceso>();
            eventos = new List<Evento>();

        }

        public void iniciarSimulacion()
        {

            while (Resultados.cantidadProcesosFinalizados < cantidadFinalProcesos)
            {
                if (eventos.Count == 0)
                {
                    Llegada llegada = new Llegada(0, new Random());
                    llegada.tiempoOcurrencia = llegada.generarTiempoProximaLlegada();
                    eventos.Add(llegada);
                }
                else
                {
                    eventos.Sort();
                    Evento proximoEvento = eventos[0];
                    eventos.RemoveAt(0);
                    tiempo = proximoEvento.tiempoOcurrencia;
                    List<Evento> eventosFuturos = proximoEvento.ejecutar(colaCPU, colaIO, tiempo);  //Falta ver donde se almacenan las variables auxiliares de los resultados, si en el evento o el proceso
                    foreach (Evento ev in eventosFuturos)
                    {
                        eventos.Add(ev);
                    }
                }
            }
            Resultados.cantidadProcesosEnCola = colaCPU.Count;
            Resultados.tiempoFinal = tiempo;
            if (colaCPU.Count < cantidadNucleos)
            {
                //Resultados.finesTiempoOcioso += (tiempo * (cantidadNucleos - colaCPU.Count));
                Resultados.tiempoOciosoTotal += (tiempo * (cantidadNucleos - colaCPU.Count));
            }
            Resultados.finesEsperas += (tiempo * (colaCPU.Count - cantidadNucleos));

        }

        public void clear()
        {
            colaCPU.Clear();
            colaIO.Clear();
            eventos.Clear();

            this.tiempo = 0;
            this.procesosFinalizados = 0;
            this.sumatoriasFinEsperaProceso = 0;
            this.sumatoriasFinTiempoOciosoCPU = 0;
            this.sumatoriasInicioEsperaProceso = 0;
            this.sumatoriasInicioTiempoOciosoCPU = 0;

        }



    }
}

