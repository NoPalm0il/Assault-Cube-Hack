using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
//using System.Windows;

namespace Assault_Cube_Hack
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] prcarr = Process.GetProcessesByName("ac_client");
            Process pc;

            while (true)
            {
                try
                {
                    pc = prcarr[0];
                    break;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Start Assault Cube!");
                    Thread.Sleep(2000);
                }
            }

            ConsoleCLI conscli = new ConsoleCLI(pc.Handle);
            conscli.startCli();
        }
    }
}
