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
            /*
            off.localPlayer = mm.Read<int>((IntPtr)(off.baseAddress + off.offsetLocalPlayer));


            mm.Write((IntPtr)(baseLP + off.m_Health), 1337);
            mm.Write((IntPtr)(baseLP + off.m_Flashbangs), 69);
            Console.WriteLine("r");
        */
        }
    }
}
