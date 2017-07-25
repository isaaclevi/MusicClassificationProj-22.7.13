using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicClassificationBL;

namespace MusicClassificationConsole
{
    class Program
    {
        string ConsoleIO;
        string Path;
        string FileName;
        string dir;
        static void Main(string[] args)
        {
            Program P=new Program();
            while(true)
                P.Run();
        }

        public Program()
        {
            this.ConsoleIO = "";
            this.Path = "";
            this.FileName = "";
        }

        private void Run()
        {
            Console.WriteLine("Enter A Command:\n");
            ConsoleIO=Console.ReadLine().ToLower();
            switch (ConsoleIO.Split(' ')[0])
            {
                case "path":
                    Path = ConsoleIO.Split(new string[] {"path "} , StringSplitOptions.None)[0];
                    ParsPath(Path);
                    Console.WriteLine("Enter A Command:\n");
                break;
                    //graph "File Name"
                case "graph":
                    Graph(FileName);
                    Console.WriteLine("Enter A Command:\n");
                break;
                case "kmeans":

                break;
                    
                default:
                    Console.WriteLine("No Command Was Entered Enter A Command\n");
                    break;
            }
        }

        private void ParsPath(string Path)
        {
            int Amount = Path.Split('\\').Length;
            string[] PathArgs=Path.Split('\\');
            if (PathArgs[Amount - 1].Split('.')[1] != null)
            {
                if (PathArgs[Amount - 1].Split('.')[1] == "wav" || PathArgs[Amount - 1].Split('.')[1] == "mp3")
                    { FileName = Path; }
                else
                    { 
                        Console.WriteLine("File Not Supported\n");
                        Console.WriteLine("Enter A Command:\n");
                    }
            }
            else
                dir = Path;

        }

        private void Graph(object FileName)
        {
            
        }
    }
}
