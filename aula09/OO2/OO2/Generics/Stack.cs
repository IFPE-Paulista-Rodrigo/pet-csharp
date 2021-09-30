using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO2.Generics
{

    public class NPC{ }

    public class Stack<T> where T : IComparable
    {
        int position = 0;
        T[] data = new T[100];
        public void Push(T obj) => data[position++] = obj;
        public T Pop() => data[--position];
    }


    public class ObjectStack
    {
        int position;
        object[] data = new object[10];
        public void Push(object obj) => data[position++] = obj;
        public object Pop() => data[--position];
    }

    public class GenericMethod
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static void Zap<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = default(T);
        }
    }
}
