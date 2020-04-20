using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
//using System.Windows;

namespace Assault_Cube_Hack
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryMan mm = new MemoryMan();

            Console.WriteLine(mm.ToString());
        }
    }
}
