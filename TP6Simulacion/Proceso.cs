using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6Simulacion
{
    public class Proceso
    {
        Double pCPU = 0.09656;
        Double pIO = 0.00499;
        Random r;
        public Proceso(Random r)
        {
            this.r = r;
        }

        public Proceso()
        {

        }
        public Int32 generarRafagaCPU()
        {

            Boolean rechazo = true;
            Double maxY = 0.08728;
            Double maxX = 131;
            Double x = r.NextDouble() * (maxX - 1) + 1;
            Double y = r.NextDouble() * maxY;

            while (rechazo)
            {
                if (Math.Pow((1 - pCPU), (x - 1)) * pCPU >= y)
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

        public Int32 generarRafagaIO()
        {
            Boolean rechazo = true;
            Double maxY = 0.00385;
            Double maxX = 349;
            Double x = r.NextDouble() * (maxX - 1) + 1;
            Double y = r.NextDouble() * maxY;

            while (rechazo)
            {
                if (Math.Pow((1 - pIO), (x - 1)) * pIO >= y)
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

        public Boolean decidirSiFinaliza() {

            return r.Next(10000) < 6;
        }

    }
}
