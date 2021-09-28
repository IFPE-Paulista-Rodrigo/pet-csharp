using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOClasse.Finalizadores
{
    class ClassFinalizador
    {

        ~ClassFinalizador() => Console.WriteLine("Finalizando classe");
    }
}
