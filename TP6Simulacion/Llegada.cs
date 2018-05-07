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
        public int CompareTo(object obj)
        {
            Evento evento = obj as Evento;
            return tiempoOcurrencia - evento.tiempoOcurrencia;
        }

        public void ejecutar(List<Queue<Proceso>> colasCPU, Queue<Proceso> colaIO)
        {
            throw new NotImplementedException();
        }

    }
}
