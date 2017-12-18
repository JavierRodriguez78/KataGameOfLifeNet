using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public enum estadoCelula
    {
        vivo,
        muerto
    }

    public class ReglasVida
    {
        public static estadoCelula GetNuevoEstado(estadoCelula estadoActual, int vecinosVivos)
        {

            /*Refactorizado*/
            switch(estadoActual)
            {
                case estadoCelula.vivo:
                    if (vecinosVivos < 2 || vecinosVivos > 3)
                        return estadoCelula.muerto;
                    break;
                case estadoCelula.muerto:
                    if (vecinosVivos == 3)
                        return estadoCelula.vivo;
                    break;
            }
            return estadoActual;

            /*
            if (estadoActual == estadoCelula.vivo && vecinosVivos < 2)
                return estadoCelula.muerto;
            if (estadoActual == estadoCelula.vivo && vecinosVivos > 3)
                return estadoCelula.muerto;
            if (estadoActual == estadoCelula.muerto && vecinosVivos == 3)
                return estadoCelula.vivo;

            return estadoActual;
            */


           
        }
    }
}
