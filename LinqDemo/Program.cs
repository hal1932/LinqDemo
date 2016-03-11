using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Test : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            for (var i = 0; i < 3; ++i)
            {
                Console.WriteLine("enumerated: " + i);
                yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var test = new Test();
            foreach (var item in test)
            {
                Console.WriteLine(item);
            }
            foreach (var item in test)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(test.Count());

            var testArray = test.ToArray();
            foreach (var item in testArray)
            {
                Console.WriteLine(item);
            }
            foreach (var item in testArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(testArray.Length);

            var testSelected = test.Select(item => item);
            foreach (var item in testSelected)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
