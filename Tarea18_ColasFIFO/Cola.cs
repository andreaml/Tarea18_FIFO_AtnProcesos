using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea18_ColasFIFO
{
    class Cola
    {
        private static Random _numCiclos = new Random();
        private Proceso _primero;
        public Proceso primero { get { return _primero; } }
        //private Proceso _ultimo;

        public Cola()
        {
        }

        public void agregarProceso()
        {
            if (_primero == null)
                _primero = new Proceso(_numCiclos.Next(4, 15));
            else
                agregarProceso(_primero);
        }

        private void agregarProceso(Proceso ultimo)
        {
            if (ultimo.siguiente == null)
                ultimo.siguiente = new Proceso(_numCiclos.Next(4, 15));
            else
                agregarProceso(ultimo.siguiente);
        }
        
        public void eliminarProceso()
        {
            _primero = _primero.siguiente;
        }

        public int calcularCiclosPendientes()
        {
            if (_primero != null)
                return calcularCiclosPendientes(_primero);
            else
                return 0;
        }

        private int calcularCiclosPendientes(Proceso ultimo)
        {
            if (ultimo.siguiente != null)
                return ultimo.ciclos + calcularCiclosPendientes(ultimo.siguiente);
            else
            {
                return ultimo.ciclos;
            }
        }
    }
}
