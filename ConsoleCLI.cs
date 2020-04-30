using System;
using System.Collections;
using System.Threading;

namespace Assault_Cube_Hack
{
    class ConsoleCLI : Memory
    {
        public Offsets off { get; set; }
        private ArrayList hacks { get; set; }
        private ArrayList commands { get; set; }

        private Hack hvh { get; set; }
        private Hack ammo { get; set; }
        private Hack godMode { get; set; }
        private Hack walls { get; set; }
        private Hack aimbot { get; set; }

        public ConsoleCLI(IntPtr processHandle) : base(processHandle)
        {
            off = new Offsets();
            //maybe delete hacks
            hacks = new ArrayList();
            commands = new ArrayList();

            hvh = new Hack("hvh");
            ammo = new Hack("ammo");
            godMode = new Hack("godMode");
            walls = new Hack("walls");
            aimbot = new Hack("aimbot");

            hacks.Add(hvh);
            hacks.Add(ammo);
            hacks.Add(new Hack("godMode"));
            hacks.Add(walls);
            hacks.Add(aimbot);

            commands.Add("help");
            commands.Add("clear");
            commands.Add("start");
            commands.Add("exit");
        }

        public void startCli()
        {
            Console.Clear();
            while (true)
            {
                Console.Write("ACSharp > ");

                string cmd = Console.ReadLine();

                if (commands.Contains(cmd))
                {
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
                        case "exit":
                            Environment.Exit(1);
                            break;
                        default:
                            break;
                    }
                }
                else
                    Console.WriteLine("Incorrect command");
            }
        }

        private void startHackCli()
        {
            off.localPlayer = Read<int>((IntPtr)(off.baseAddress + off.offsetLocalPlayer));

            Console.Clear();

            bool leave = false;

            while (true)
            {
                hacksStatus();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("AChackerinos ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("? ");
                Console.ResetColor();
                Console.Write("> ");

                string cmd = Console.ReadLine();

                if (hacks.Contains(cmd))
                {
                    switch (cmd)
                    {
                        case "hvh":
                            //if (!hvhbool)
                            //{
                            //    //hacks.BinarySearch("hvh") = true;
                            //    ThreadPool.QueueUserWorkItem(runHvh);
                            //}
                            //else
                            //    hvhbool = false;
                            break;
                        case "walls":
                            ThreadPool.QueueUserWorkItem(runWalls);
                            break;
                        case "aimbot":
                            ThreadPool.QueueUserWorkItem(runAimbot);
                            break;
                        case "godMode":
                            //maybe static would be more efficient
                            if (!((Hack)hacks[hacks.IndexOf(new Hack("hvh"))]).isActive)
                            {
                                ((Hack)hacks[hacks.IndexOf(new Hack("hvh"))]).isActive = true;
                                ThreadPool.QueueUserWorkItem(runGodMode);
                            }
                            else
                                ((Hack)hacks[hacks.IndexOf(new Hack("hvh"))]).isActive = false;
                            break;
                        case "ammo":
                            //if (!ammobool)
                            //{
                            //    ammobool = true;
                            //    ThreadPool.QueueUserWorkItem(runAmmo);
                            //}
                            //else
                            //    ammobool = false;
                            break;
                        case "help":
                            showHelp();
                            break;
                        case "clear":
                            Console.Clear();
                            break;
                        case "exit":
                            leave = true;
                            break;
                        default:
                            break;
                    }
                }
                else
                    Console.WriteLine("Enter a correct command");
                if (leave)
                    break;
            }
        }

        private void showHelp()
        {
            Console.WriteLine("Help...");
        }

        private void hacksStatus()
        {
            //do single hack object, more dynamic
            foreach (string item in hacks)
            {
                if(true)//TODO
                Console.Write(item);
            }


            Console.WriteLine("");
        }

        private void runGodMode(object state)
        {
            //maybe static is more efficient
            //while(hack.isActive)
            while (true)
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
            while (true)
            {

            }
        }

        private void runAmmo(object state)
        {
            while (true)
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
