using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea18_ColasFIFO
{
    class Procesador
    {
        private static Random _procesoNuevo = new Random();
        private Cola _cola = new Cola();
        private int _ciclosVacia;
        private int _procesosFormados;
        private int _procesosTerminados;

        public Procesador()
        {
        }

        public void iniciarCiclos()
        {
            for (int i = 0; i < 200; i++)
            {
                if (_procesoNuevo.Next(1, 5) == 1)
                {
                    _cola.agregarProceso();
                    _procesosFormados++;
                }

                if (_cola.primero != null)
                {
                    atenderProceso();
                }
                else
                    _ciclosVacia++;
            }
        }

        private void atenderProceso()
        {
            if (--_cola.primero.ciclos == 0)
            {
                _cola.eliminarProceso();
                _procesosTerminados++;
            }
        }

        public int procesosPendientes()
        {
            return _procesosFormados - _procesosTerminados;
        }


        public int ciclosPendientes()
        {
            return _cola.calcularCiclosPendientes();
        }

        public int ciclosVacia()
        {
            return _ciclosVacia;
        }
    }
}
