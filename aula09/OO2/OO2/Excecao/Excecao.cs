using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO2.Excecao
{
    internal class TestException
    {

        public static double Divisao(int dividendo, int divisor) => dividendo / divisor;

        public static void MethodTest1()
        {
            try { 
                Console.WriteLine(Divisao(10, 0));
            }catch (DivideByZeroException ex)
            {
                throw ex;
            }
        }

        public static void MethodTest2()
        {
            try
            {
                Console.WriteLine(Divisao(10, 0));
            }
            catch (DivideByZeroException)
            {
                throw;
            }
            finally
            {
                Console.WriteLine("Executando o finally");
            }
        }

        public static void MethodTestThrow()
        {
            throw new MyException("primeira mensagem", "segunda mensagem");
        }
    }

    public class MyException : Exception
    {
        public string SecondMessage { get; private set; }

        public MyException(string message, string secondMessage) : base(message) {
            SecondMessage = message;
        }

        public override string ToString() => $"{Message} / {SecondMessage}";
    }
}
