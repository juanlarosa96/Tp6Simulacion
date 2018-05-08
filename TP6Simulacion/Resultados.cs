using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6Simulacion
{
    public static class Resultados
    {
        public static List<Int32> iniciosTiempoOcioso { get; set; }
        public static List<Int32> finesTiempoOcioso { get; set; }
        public static Int32 cantidadRafagas { get; set; }
        public static Int32 iniciosEsperas { get; set; }
        public static Int32 finesEsperas { get; set; }
        public static Int32 nucleos { get; set; }


        public static void inicializar(Int32 n)
        {
            nucleos = n;
            for (int i = 0; i < nucleos; i++)
            {
                iniciosTiempoOcioso.Add(0);
                finesTiempoOcioso.Add(0);
            }
            cantidadRafagas = 0;
            iniciosEsperas = 0;
            finesEsperas = 0;
        }

        public static Int32 calcularTiempoOcioso()
        {
            Int32 acumulador = 0;
            for (int i = 0; i < nucleos; i++)
            {
                acumulador = acumulador + finesTiempoOcioso[i] - iniciosTiempoOcioso[i];                
            }

            return acumulador;
        }
    }
}

