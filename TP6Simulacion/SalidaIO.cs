using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6Simulacion
{
    public class SalidaIO : Evento, IComparable
    {
        public Int32 tiempoOcurrencia { get; set; }

        public SalidaIO()
        {

        }

        public SalidaIO(Int32 tiempoOcurrencia)
        {
            this.tiempoOcurrencia = tiempoOcurrencia;
        }

        public int CompareTo(object obj)
        {
            Evento evento = obj as Evento;
            return tiempoOcurrencia - evento.tiempoOcurrencia;
        }

        public List<Evento> ejecutar(Queue<Proceso> colasCPU, Queue<Proceso> colaIO, Int32 tiempo)
        {
            Proceso p;
            List<Evento> eventosFuturos = new List<Evento>();
            p = colaIO.Dequeue();
            colasCPU.Enqueue(p);

            if (colaIO.Count != 0)
            {
                eventosFuturos.Add(new SalidaIO(colaIO.ElementAt(0).generarRafagaIO() + tiempo));
            }
            if (colasCPU.Count <= Resultados.nucleos)
            {
                eventosFuturos.Add(new SalidaCPU(tiempo + p.generarRafagaCPU()));
                //Resultados.finesTiempoOcioso += tiempo;
                Resultados.tiempoOciosoTotal += tiempo;
            }
            else
            {
                Resultados.iniciosEsperas += tiempo;
                p.iniciarEspera(tiempo);
            }

            return eventosFuturos;

        }


    }
}
