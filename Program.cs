using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DZ_2.zad
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<double> listOfIntegers = new GenericList<double>();

            listOfIntegers.Add(1.5); // [1]
            listOfIntegers.Remove(1);
            listOfIntegers.Add(2); // [1 ,2]
            listOfIntegers.Add(3); // [1 ,2 ,3]
            listOfIntegers.Add(4); // [1 ,2 ,3 ,4]
            listOfIntegers.Add(5); // [1 ,2 ,3 ,4 ,5]
            listOfIntegers.RemoveAt(0); // [2 ,3 ,4 ,5]
            listOfIntegers.Remove(5);

            Console.ReadLine();
        }
    }
}
