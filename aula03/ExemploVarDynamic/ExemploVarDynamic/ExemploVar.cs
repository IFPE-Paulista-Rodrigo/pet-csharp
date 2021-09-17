using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploVarDynamic
{
    class ExemploVar
    {
        internal static void Exemplo()
        {
            dynamic x = 10;
            var y = (byte) 20;
            var z = "Maria";

            Console.WriteLine(x.Rodrigo);
            Console.WriteLine(y);
            Console.WriteLine(z);
            
        }

        internal static void Exemplo2()
        {
            //var myVar;
            var myVar = "Rosa";

            dynamic myDynamic;
            myDynamic = 1;
            Console.WriteLine(myDynamic);
            myDynamic = "http://ifpé.edu.br";
            Console.WriteLine(myDynamic);

        }
    }
}
