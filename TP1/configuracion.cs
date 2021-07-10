using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;

namespace TP1
{
    public static class configuracion
    {
        public static string Cadena_Conexion = ConfigurationManager.ConnectionStrings
            ["dbTP1"].ConnectionString;
    }
}
