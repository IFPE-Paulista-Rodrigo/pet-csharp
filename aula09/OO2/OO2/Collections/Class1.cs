using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO2.Collections
{
    internal class ExemploCollections
    {
        public static void TestList()
        {
            var words = new List<string>();

            words.Add("melon");
            words.Add("avocado");
            words.AddRange(new[] { "Banana", "Plum" }); //ameixa
            words.Insert(0, "lemon");
            words.InsertRange(0, new[] { "peach", "nashi" }); //pessego e pera


            words.Remove("melon");
            words.RemoveAt(3);
            words.RemoveRange(0, 2);

            words.RemoveAll(s => s.StartsWith("n"));

        }

    }
}
