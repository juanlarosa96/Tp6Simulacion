using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6Simulacion
{
    public interface Evento
    {        
        List<Evento> ejecutar(Queue<Proceso> colasCPU, Queue<Proceso> colaIO, Int32 tiempo);
        int tiempoOcurrencia { get; set; }
    }
}
