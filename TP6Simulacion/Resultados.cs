using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6Simulacion
{
    public static class Resultados
    {
        public static int cantidadProcesosFinalizados { get; set; }
        public static Int32 cantidadProcesosTotales { get; set; }
        public static int cantidadProcesosEnCola { get; set; }        
        public static Double iniciosTiempoOcioso { get; set; }
        public static Double tiempoOciosoTotal { get; set; }
        public static Double finesTiempoOcioso { get; set; }
        public static Int32 cantidadRafagas { get; set; }
        public static Double iniciosEsperas { get; set; }
        public static Double finesEsperas { get; set; }
        public static Int64 tiemposEspera { get; set; }
        public static Int32 tiempoFinal { get; set; }
        public static Int32 nucleos { get; set; }



        public static void inicializar(Int32 n)
        {
            nucleos = n;
            iniciosTiempoOcioso = 0;
            finesTiempoOcioso = 0;
            cantidadRafagas = 0;
            iniciosEsperas = 0;
            finesEsperas = 0;
            cantidadProcesosFinalizados = 0;
            cantidadProcesosTotales = 0;
            tiemposEspera = 0;
            tiempoOciosoTotal = 0;
        }

        public static Double calcularTiempoOcioso()
        {
            return finesTiempoOcioso - iniciosTiempoOcioso;

        }

        public static Double calcularTiempoOciosoPromedio()
        {
            //return (finesTiempoOcioso - iniciosTiempoOcioso) / nucleos;
            return tiempoOciosoTotal / nucleos;

        }

        public static Double calcularPorcentajeTiempoOcioso()
        {

            return tiempoOciosoTotal * 100 / (tiempoFinal * nucleos);
        }


        public static Double calcularTiempoPromedioEspera()
        {
            return tiemposEspera / cantidadProcesosFinalizados;
            //return (finesEsperas - iniciosEsperas) / cantidadProcesosTotales;
        }






    }
}

