using System;
using System.Threading;

namespace Assault_Cube_Hack
{
    class ConsoleCLI : Memory
    {
        public Offsets off { get; set; }

        public ConsoleCLI(IntPtr processHandle) : base(processHandle)
        {
            off = new Offsets();

            startCli();
        }

        public void startCli()
        {
            while (true)
            {
                Console.Write("ACSharp > ");

                string cmd = Console.ReadLine();

                //TODO: foreach searching the commands struct if the input matches the struct
                switch (cmd)
                {
                    case "help":
                        showHelp();
                        break;
                    case "clear":
                        Console.Clear();
                        break;
                    case "start":
                        startHackCli();
                        break;
                    case "hacks":
                        showHacks();
                        break;
                    case "exit":
                        Environment.Exit(1);
                        break;
                    default:
                        break;
                }
            }
        }

        private void startHackCli()
        {
            off.localPlayer = Read<int>((IntPtr)(off.baseAddress + off.offsetLocalPlayer));
            bool leave = false;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("AChackerinos ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("? ");
                Console.ResetColor();
                Console.Write("> ");

                string cmd = Console.ReadLine();
                //TODO: foreach searching the commands struct if the input matches the struct
                switch (cmd)
                {
                    case "godMode":
                        Thread thgod = new Thread(runGodMode);
                        thgod.Start();
                        break;
                    case "ammo":
                        Thread thammo = new Thread(runAmmo);
                        thammo.Start();
                        break;
                    case "help":
                        showHelp();
                        break;
                    case "clear":
                        Console.Clear();
                        break;
                    case "hacks":
                        showHacks();
                        break;
                    case "exit":
                        leave = true;
                        break;
                    default:
                        break;
                }
                if (leave)
                    break;
            }
        }

        private void showHelp()
        {
            Console.WriteLine("Help...");
        }

        private void showHacks()
        {
            Console.WriteLine("Hacks...");
        }

        private void runGodMode()
        {
            while (true)
            {
                Write((IntPtr)(off.localPlayer + off.m_Health), 1337);
                Thread.Sleep(500);
            }
        }

        private void runAmmo()
        {
            while (true)
            {
                Write((IntPtr)(off.localPlayer + off.m_Flashbangs), 69);
                Thread.Sleep(500);
            }
        }
    }
}
