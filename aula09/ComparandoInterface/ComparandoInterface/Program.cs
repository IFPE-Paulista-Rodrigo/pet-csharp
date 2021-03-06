using System;

namespace ComparandoInterface
{
    class Program
    {
        static void Main(string[] args)
        {

            // Exemplo usando Pessoa
            Pessoa[] pessoas = new Pessoa[4];
            pessoas[0] = new Pessoa() { Nome = "Rodrigo" };
            pessoas[1] = new Pessoa() { Nome = "Abel" };
            pessoas[2] = new Pessoa() { Nome = "Berenice" };
            pessoas[3] = new Pessoa() { Nome = "Axel" };

            Console.WriteLine("Ordenado os objetos de pessoa");
            MySort(pessoas);
            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa.Nome);
            }


            // Exemplo usando Temperature
            Temperature[] temperaturas = new Temperature[5];
            temperaturas[0] = new Temperature(20);
            temperaturas[1] = new Temperature(2);
            temperaturas[2] = new Temperature(-20);
            temperaturas[3] = new Temperature(33);
            temperaturas[4] = new Temperature(89);
            
            Console.WriteLine("Ordenado a temperatura");
            MySort(temperaturas);
            foreach (Temperature temperatura in temperaturas)
            {
                Console.WriteLine(temperatura.Celsius.ToString("F2"));
            }

            Pessoa rodrigo = new Pessoa() { Nome = "Rodrigo" };
            Pessoa marcilio = new Pessoa() { Nome = "Marcilio" };

            
            Console.WriteLine(marcilio.CompareTo(rodrigo)); 
        }

        //10, 3, 20, 5
        static void MySort(IComparable[] array)
        { 
            for(int i = 0; i < array.Length; i += 1)
            {
                for (int j = i+1; j < array.Length; j += 1)
                {
                    if (array[i].CompareTo(array[j]) == 1)
                    {
                        IComparable temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
