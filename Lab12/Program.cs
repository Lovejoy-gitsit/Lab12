using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Toni", "1234 Main St", "C#", 2008, 20.9);
            Console.WriteLine(s);
        }
    }
}
