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

        public Llegada(Int32 tiempo)
        {
            tiempoOcurrencia = tiempo;
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

        public Evento ejecutar(Queue<Proceso> colasCPU, Queue<Proceso> colaIO)
        {
            throw new NotImplementedException();
        }



        internal Int32 generarTiempoProximaLlegada()
        {
            return 5;
        }
    }
}
