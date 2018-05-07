using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6Simulacion
{
    public class SalidaCPU : Evento, IComparable
    {
        public Int32 tiempoOcurrencia {get; set;}


        public Evento ejecutar(Queue<Proceso> colasCPU, Queue<Proceso> colaIO)
        {
            return null;
        }

        public int CompareTo(object obj)
        {
            Evento evento = obj as Evento;
            return tiempoOcurrencia - evento.tiempoOcurrencia;
        }
    }
}
