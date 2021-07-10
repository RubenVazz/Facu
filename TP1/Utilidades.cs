using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    class Utilidades
    {
        public static short ObtenerCodigo()
        {
            short id;
            var rnd = new Random();
            id = (short)rnd.Next(1, 1000);
            return id;
        }
    }
}
