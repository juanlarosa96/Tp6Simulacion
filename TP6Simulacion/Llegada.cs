using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6Simulacion
{
    public class Llegada : Evento, IComparable
    {
        public Int32 tiempoOcurrencia { get; set; }
        public Random r { get; set; }

        public Llegada(Int32 tiempo, Random r)
        {
            tiempoOcurrencia = tiempo;
            this.r = r;
        }

        public Llegada()
        {
            // TODO: Complete member initialization
        }


        public int CompareTo(object obj)
        {
            Evento evento = obj as Evento;
            return tiempoOcurrencia - evento.tiempoOcurrencia;
        }

        public List<Evento> ejecutar(Queue<Proceso> colaCPU, Queue<Proceso> colaIO, Int32 tiempo)
        {
            Proceso p = new Proceso(new Random());
            List<Evento> eventosFuturos = new List<Evento>();
            colaCPU.Enqueue(p);
            eventosFuturos.Add(new Llegada(tiempo + generarTiempoProximaLlegada(), new Random()));
            if (colaCPU.Count <= Resultados.nucleos)
            {
                eventosFuturos.Add(new SalidaCPU(colaCPU.Count, tiempo + p.generarRafagaCPU()));
            }

            return eventosFuturos;
        }



        internal Int32 generarTiempoProximaLlegada()
        {
            Boolean rechazo = true;
            Double maxY = 0.0873;
            Double maxX = 1015;
            Double pLlegada = 0.09656;
            Double x = r.NextDouble() * (maxX - 1) + 1;
            Double y = r.NextDouble() * maxY;

            while (rechazo)
            {
                if (Math.Pow((1 - pLlegada), (x - 1)) * pLlegada >= y)
                {
                    rechazo = false;
                }
                else
                {
                    x = r.NextDouble() * (maxX - 1) + 1;
                    y = r.NextDouble() * maxY;
                }
            }

            return Convert.ToInt32(x);
        }

    }
}

