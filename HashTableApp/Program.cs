using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable htable = new Hashtable();
            htable.Add(1, 10);
            htable[2] = 11;
            htable[3] = 12;
            htable[4] = "Rpm";

            ICollection l = htable.Keys;
            foreach (var i in l)
            {
                Console.WriteLine(htable[i]);
            }
            Console.Read();


            //Console.WriteLine(htable.Contains(3));
            //Console.Read();


            //Console.WriteLine(htable.ContainsValue("Rpm"));
            //Console.Read();


            //Console.WriteLine(htable.Count);
            //Console.Read();
        }
    }
}
