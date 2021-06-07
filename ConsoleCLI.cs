using System;
using System.Collections;
using System.Drawing;
using System.Threading;

namespace Assault_Cube_Hack
{
    class ConsoleCLI : Memory
    {
        public Offsets off { get; set; }
        private ArrayList hackscmds { get; set; }
        private ArrayList commands { get; set; }
        private ArrayList hacks { get; set; }

        private Hack hvh { get; set; }
        private Hack ammo { get; set; }
        private Hack godMode { get; set; }
        private Hack walls { get; set; }
        private Hack aimbot { get; set; }

        public ConsoleCLI(IntPtr processHandle) : base(processHandle)
        {
            off = new Offsets();
            //maybe delete hacks
            hackscmds = new ArrayList();
            commands = new ArrayList();
            hacks = new ArrayList();

            hvh = new Hack("hvh");
            ammo = new Hack("ammo");
            godMode = new Hack("godMode");
            walls = new Hack("walls");
            aimbot = new Hack("aimbot");

            hacks.Add(hvh);
            hacks.Add(ammo);
            hacks.Add(godMode);
            hacks.Add(walls);
            hacks.Add(aimbot);

            hackscmds.Add("hvh");
            hackscmds.Add("ammo");
            hackscmds.Add("godMode");
            hackscmds.Add("walls");
            hackscmds.Add("aimbot");
            hackscmds.Add("help");
            hackscmds.Add("exit");

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

                if (commands.Contains(cmd) || cmd == "")
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
                            Console.Clear();
                            break;
                        case "exit":
                            Environment.Exit(1);
                            break;
                        default:
                            break;
                    }
                }
                else
                    Console.WriteLine("Type a correct command");
            }
        }

        private void startHackCli()
        {
            off.localPlayer = Read<int>((IntPtr)(off.baseAddress + off.offsetLocalPlayer));

            Console.Clear();

            bool leave = true;

            while (leave)
            {
                hacksStatus();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("AChackerinos ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("? ");
                Console.ResetColor();
                Console.Write("> ");

                string cmd = Console.ReadLine();

                if (hackscmds.Contains(cmd) || cmd == "")
                {
                    switch (cmd)
                    {
                        case "hvh":
                            if (!hvh.isActive)
                            {
                                hvh.isActive = true;
                                ThreadPool.QueueUserWorkItem(runHvh);
                            }
                            else
                                hvh.isActive = false;
                            break;
                        case "walls":
                            if (!walls.isActive)
                            {
                                walls.isActive = true;
                                ThreadPool.QueueUserWorkItem(runWalls);
                            }
                            else
                                walls.isActive = false;
                            break;
                        case "aimbot":
                            if (!aimbot.isActive)
                            {
                                aimbot.isActive = true;
                                ThreadPool.QueueUserWorkItem(runAimbot);
                            }
                            else
                                aimbot.isActive = false;
                            break;
                        case "godMode":
                            //maybe static would be more efficient
                            if (!godMode.isActive)
                            {
                                godMode.isActive = true;
                                ThreadPool.QueueUserWorkItem(runGodMode);
                            }
                            else
                                godMode.isActive = false;
                            break;
                        case "ammo":
                            if (!ammo.isActive)
                            {
                                ammo.isActive = true;
                                ThreadPool.QueueUserWorkItem(runAmmo);
                            }
                            else
                                ammo.isActive = false;
                            break;
                        case "help":
                            showHelp();
                            break;
                        case "exit":
                            leave = false;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Type a correct command");
                    Thread.Sleep(700);
                }
                Console.Clear();
            }
        }

        private void showHelp()
        {
            Console.WriteLine("Help...");
        }

        private void hacksStatus()
        {
            Console.WriteLine();
            foreach (Hack item in hacks)
            {
                Console.Write("         ");
                if (item.isActive)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write(" " + item.Name + " ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(" " + item.Name + " ");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }

            Console.WriteLine("\n\n");
        }

        private void runGodMode(object state)
        {
            //maybe static is more efficient
            //while(hack.isActive)
            while (godMode.isActive)
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
            while (hvh.isActive)
            {

            }
        }

        private void runAmmo(object state)
        {
            while (ammo.isActive)
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
            while (walls.isActive)
            {
                //Do wallhack
            }

        }

        private void runAimbot(object state)
        {
            while (aimbot.isActive)
            {
                //Do Aimbot
            }
        }
    }
}
