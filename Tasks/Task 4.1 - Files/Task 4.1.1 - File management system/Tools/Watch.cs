using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_4._1._1___File_management_system
{
    class Watch
    {
        public static void Watching(string path)
        {
            using (FileSystemWatcher watcher = new FileSystemWatcher())
            {
                Console.WriteLine($"Wathcing: {path}");

                watcher.Path = path;

                watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite 
                    | NotifyFilters.FileName | NotifyFilters.DirectoryName;

                watcher.Filter = "*.*";
                watcher.Changed += Backup.Change;
                watcher.Created += Backup.Change;
                watcher.Deleted += Backup.Change;
                watcher.Renamed += Backup.Rename;
                watcher.IncludeSubdirectories = true;
                watcher.EnableRaisingEvents = true;

                Console.WriteLine("Press 'q' to quit and go to main menu");

                while (Console.ReadLine() != "q") ;

                Program.Beginning();
            }
        }
    }
}
