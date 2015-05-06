using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSkeleton
{
    internal class Program
    {
        private static List<int> _list = new List<int>();
        
        private static void Main(string[] args)
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            for (var i=0; i<100; i++)
            {
                var element = rnd.Next(1,100);
                _list.Add(element);
            }
            
            var q = from x in _list
                    where x % 2 == 0
                    select x;
                    
            foreach (var x in q)
                Console.WriteLine(x);
        }
    }
}