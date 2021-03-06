﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6Simulacion
{
    public class SalidaCPU : Evento, IComparable
    {


        public Int32 tiempoOcurrencia { get; set; }


        public SalidaCPU(Int32 t)
        {
            this.tiempoOcurrencia = t;
        }

        public List<Evento> ejecutar(Queue<Proceso> colasCPU, Queue<Proceso> colaIO, Int32 tiempo)
        {
            List<Evento> eventosFuturos = new List<Evento>();
            Proceso p = colasCPU.Dequeue();            
            if (!p.decidirSiFinaliza())
            {
                colaIO.Enqueue(p);
                if (colaIO.Count == 1)
                {
                    SalidaIO salidaIO = new SalidaIO();
                    salidaIO.tiempoOcurrencia = tiempo + p.generarRafagaIO();
                    eventosFuturos.Add(salidaIO);
                }

            }
            else
            {
                Resultados.cantidadProcesosFinalizados++;
                Resultados.tiemposEspera += p.esperaTotal;
            }

            

            if (colasCPU.Count >= Resultados.nucleos)
            {
                Resultados.finesEsperas += tiempo;
                colasCPU.ElementAt(0).finEspera(tiempo);
                eventosFuturos.Add(new SalidaCPU(tiempo + p.generarRafagaCPU()));

            }
            else
            {
                //Resultados.iniciosTiempoOcioso += tiempo;
                Resultados.tiempoOciosoTotal -= tiempo;
            }

            return eventosFuturos;

        }

        public int CompareTo(object obj)
        {
            Evento evento = obj as Evento;
            return tiempoOcurrencia - evento.tiempoOcurrencia;
        }
    }
}
