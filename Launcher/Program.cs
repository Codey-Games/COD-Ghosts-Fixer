// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;

namespace Launcher
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                // Use the first command-line argument as the game path
                string gamePath = args[0];

                // Start the game with elevated privileges
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = gamePath,
                    Verb = "runas" // Request elevation
                };

                Process.Start(startInfo);
            }
            else
            {
                Console.WriteLine("Please launch the COD Ghosts Fixer instead.");
            }
        }
    }
}
