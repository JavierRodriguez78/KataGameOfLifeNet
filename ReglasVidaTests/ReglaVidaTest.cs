using GameOfLife;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglasVidaTests
{
    [TestFixture]
    public class ReglaVidaTest
    {
        [Test]
        public void CelulaViva_CuandoHayMenos2Supervivientes_Muere(
            [Values(0,1)] int vecinosVivos)
        {
            var estadoActual = estadoCelula.vivo;
            
            estadoCelula nuevoEstado = ReglasVida.GetNuevoEstado(estadoActual, vecinosVivos);
            Assert.AreEqual(estadoCelula.muerto, nuevoEstado);

        }

        [Test]
        public void CelulaViva_CuandoHay2o3Supervivientes_Vive([Values(2,3)] int vecinosVivos)
        {
            var estadoActual = estadoCelula.vivo;
            estadoCelula nuevoEstado = ReglasVida.GetNuevoEstado(estadoActual, vecinosVivos);
            Assert.AreEqual(estadoCelula.vivo, nuevoEstado);
        }
        
        [Test]
        public void CelulaViva_CuandoMas3Supervivientes_Muere([Range(4,8)] int vecinosVivos)
        {
            var estadoActual = estadoCelula.vivo;
            estadoCelula nuevoEstado = ReglasVida.GetNuevoEstado(estadoActual, vecinosVivos);
            Assert.AreEqual(estadoCelula.muerto, nuevoEstado);
        }

        [Test]
        public void CelulaMuerta_CuandoExactamente3Supervivientes_Vive()
        {
            var vecinosVivos = 3;
            var estadoActual = estadoCelula.muerto;
            estadoCelula nuevoEstado = ReglasVida.GetNuevoEstado(estadoActual, vecinosVivos);
            Assert.AreEqual(estadoCelula.vivo, nuevoEstado);
        }

        [Test]
        public void CelulaMuerta_Mientrashayamenos3Supervivientes_Muere([Range(0,2)] int vecinosVivos)
        {
            var estadoActual = estadoCelula.muerto;
            estadoCelula nuevoEstado = ReglasVida.GetNuevoEstado(estadoActual, vecinosVivos);
            Assert.AreEqual(estadoCelula.muerto, nuevoEstado);

        }

        [Test]
        public void CelulaMuerta_MientrasMas3Supervivientes_Muere([Range(4,8)] int vecinosVivos)
        {
            var estadoActual = estadoCelula.muerto;
            estadoCelula nuevoEstado = ReglasVida.GetNuevoEstado(estadoActual, vecinosVivos);
            Assert.AreEqual(estadoCelula.muerto, nuevoEstado);
        }

    }
}
