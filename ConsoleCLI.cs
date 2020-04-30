using System;
using System.Threading;

namespace Assault_Cube_Hack
{
    class ConsoleCLI : Memory
    {
        public Offsets off { get; set; }

        private bool ammobool { get; set; }
        private bool gmbool { get; set; }
        private bool hvhbool { get; set; }
        private bool wallsbool { get; set; }
        private bool aimbotbool { get; set; }

        public ConsoleCLI(IntPtr processHandle) : base(processHandle)
        {
            off = new Offsets();

            ammobool = false;
            gmbool = false;
            hvhbool = false;
            wallsbool = false;
            aimbotbool = false;
        }

        public void startCli()
        {
            Console.Clear();
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
            Console.Clear();

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
                    case "hvh":
                        if (!hvhbool) {
                            hvhbool = true;
                            ThreadPool.QueueUserWorkItem(runHvh);
                        }
                        else 
                            hvhbool = false;
                        break;
                    case "walls":
                        ThreadPool.QueueUserWorkItem(runWalls);
                        break;
                    case "aimbot":
                        ThreadPool.QueueUserWorkItem(runAimbot);
                        break;
                    case "godMode":
                        if (!gmbool)
                        {
                            gmbool = true;
                            ThreadPool.QueueUserWorkItem(runGodMode);
                        }
                        else
                            gmbool = false;
                        break;
                    case "ammo":
                        if (!ammobool)
                        {
                            ammobool = true;
                            ThreadPool.QueueUserWorkItem(runAmmo);
                        }
                        else
                            ammobool = false;
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

        private void runGodMode(object state)
        {
            while (gmbool)
            {
                Write((IntPtr)(off.localPlayer + off.m_Health), 1337);
                Thread.Sleep(400);
                Write((IntPtr)(off.localPlayer + off.m_Health), 3371);
                Thread.Sleep(400);
                Write((IntPtr)(off.localPlayer + off.m_Health), 3713);
                Thread.Sleep(400);
                Write((IntPtr)(off.localPlayer + off.m_Health), 7133);
                Thread.Sleep(400);
            }
        }

        private void runHvh(object state)
        {
            while (hvhbool)
            {

            }
        }

        private void runAmmo(object state)
        {
            while (ammobool)
            {
                Write((IntPtr)(off.localPlayer + off.m_Ammo), 69);
                //Write((IntPtr)(off.localPlayer + off.m_AmmoMags), 69);
                //Write((IntPtr)(off.localPlayer + off.m_SecAmmo), 69);
                Write((IntPtr)(off.localPlayer + off.m_Grenades), 69);
                Thread.Sleep(200);
            }
        }

        private void runWalls(object state)
        {

        }

        private void runAimbot(object state)
        {

        }
    }
}
