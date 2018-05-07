using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6Simulacion
{
    public interface Evento
    {        
        void ejecutar(List<Queue<Proceso>> colasCPU, Queue<Proceso> colaIO);
        int tiempoOcurrencia { get; set; }
    }
}
