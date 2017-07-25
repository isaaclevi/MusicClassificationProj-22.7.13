using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicClassificationBL;
using MusicClassificationAlgotihm;

namespace MusicClassificationConsole
{
    class Program
    {
        short Centers;
        string k; //number of centroids
        string ConsoleIO;
        string Path;
        string FileName;
        string dir;
        bool classtered;
        ClusterList<SongVector> ClusterList;
        static void Main(string[] args)
        {
            Program P = new Program();
            while (true)
                P.Run();
        }

        public Program()
        {
            this.ConsoleIO = "";
            this.Path = "";
            this.FileName = "";
            this.dir = "";
            classtered = false;
            ClusterList = null;
        }

        private void Run()
        {
            Console.WriteLine("Enter A Command:\n");
            ConsoleIO = Console.ReadLine().ToLower();
            switch (ConsoleIO.Split(' ')[0].ToLower())
            {
                case "path":
                    Path = ConsoleIO.Split(new string[] { "path " }, StringSplitOptions.None)[1];
                    ParsPath(Path);
                    break;
                //graph "File Name"
                case "graph":
                    Graph(FileName);
                    Console.WriteLine("Enter A Command:\n");
                    break;
                case "kmeans":
                    classtered = true;
                    if (this.dir != "")
                    {
                        Console.WriteLine("Enter the Number Of Genres");
                        k=Console.ReadLine();
                        if (!Int16.TryParse(k, out Centers))
                        {
                            new Exception("error invalid number");
                        }
                        SongList ListOfSongs = new SongList();
                        foreach (string FilePath in Directory.GetFiles(this.dir))
                        {
                            if (FilePath.EndsWith(".mp3") || FilePath.EndsWith(".wav"))
                            {
                                try
                                {
                                    SongClass newSong = new SongClass(FilePath);
                                    ListOfSongs.Add(newSong);
                                }
                                catch (Exception)
                                {
                                }

                            }
                        }
                        IDistance<SongVector> df = new Euclidean();
                        //IDistance<SongVector> df = new Manhattan();
                        ICenterSelection<SongVector> cs = new SongRandomSelection();
                        //ICenterSelection<SongVector> cs = new KCenterEachLenghDivKPoints();
                        ClusterList = SongKMeans.RunKMeans(ListOfSongs.GetSongsVectors(), Centers/*int.Parse(MusicClassificationConsole.Properties.Resources.K)*/ , df, cs);

                        foreach (var cluster in ClusterList)
                        {
                            Console.WriteLine();
                            Console.WriteLine(cluster.Centroid.Song.FileName + " " + cluster.Points.Count);
                            Console.WriteLine("List of song");
                            foreach (var item in cluster.Points)
                            {
                                Console.WriteLine(item.ToString());
                            }
                            Console.WriteLine();
                        }

                        //Kmeans.;

                    }
                    else
                    {
                        Console.WriteLine("Error Directory Path is Empty");
                    }
                    break;
                case "get_list":
                    if (FileName != null && classtered == true)
                    {
                        if (File.Exists(FileName))
                        {
                            SongVector SempleVector = null;
                            try
                            {
                                SongClass newSong = new SongClass(FileName);
                                SempleVector = newSong.GetMusicVector();
                            }
                            catch (Exception)
                            {

                            }
                            IDistance<SongVector> df = new Euclidean();
                            //IDistance<SongVector> df = new Manhattan();
                            Cluster<SongVector> SempleClaster = ClusterList.ClusterBlong(SempleVector, df);
                            for (int i = 0; i < SempleClaster.Points.Count; i++)
                            {
                                Console.WriteLine(SempleClaster.Points[i].ToString());
                            }
                        }
                        else
                        {
                            Console.WriteLine("file not exists");
                        }
                    }
                    else
                    {
                        Console.WriteLine("no kmeans or no file path");
                    }
                    break;
                default:
                    Console.WriteLine("No Command Was Entered Enter A Command\n");
                    break;
            }
        }

        private void ParsPath(string Path)
        {
            int Amount = Path.Split('\\').Length;
            string[] PathArgs = Path.Split('\\');
            if (PathArgs[Amount - 1].Split('.').Length != 1)
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

        public void Graph(string FileName)
        {
        }
    }
}
