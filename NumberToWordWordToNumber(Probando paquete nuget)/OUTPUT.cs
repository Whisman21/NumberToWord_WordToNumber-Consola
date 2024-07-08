using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWordWordToNumber_Probando_paquete_nuget_
{
    public class OUTPUT
    {
        private dynamic result { get; }
        private int id { get; }

        public OUTPUT(dynamic Salir)
        {
            result = Salir;
            id = generateId();
        }
        public dynamic GetResult()
        {
            return result;
        }
        static int generateId()
        {
            int counter = 0;
            return ++counter;
        }
    }
}
