using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_4._1._1___File_management_system
{
    public class Backup
    {
        public static void Change(object source, FileSystemEventArgs e)
        {
            Console.WriteLine($"File: {e.FullPath} {e.ChangeType}");

            string mainDir = e.FullPath.Substring(0, e.FullPath.Length - e.Name.Length);
            string nameDirForBackup = mainDir.Substring(0, mainDir.Length - 1);

            nameDirForBackup = nameDirForBackup.Substring(nameDirForBackup.LastIndexOf('\\') + 1);

            CreateBackup(nameDirForBackup, mainDir);
        }

        private static void CreateBackup(string nameFolder, string mainPath)
        {
            string pathToBackup = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, @"BackUpFolder");

            if (!Directory.Exists(pathToBackup))
            {
                throw new Exception("Backup Folder does not exist");
            }
            else
            {
                string correctDateTime = DateTime.Now.ToString("s");
                DirectoryCopy(mainPath, $@"{pathToBackup}\{nameFolder}\{DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss.fff")}", true);
            }
        }

        public static void CreateBackupFolder()
        {
            string path = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, @"BackUpFolder\");

            if (!File.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException("Source directory does not exist or could not be found: " + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string tempPath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                }
            }
        }

        private static string GetCorrectPath()
        {
            bool flag = false;
            string path;

            Console.Write("\nInsert your path: ");
            do
            {
                path = $@"{Console.ReadLine()}";

                if (Directory.Exists(path))
                {
                    flag = true;
                }
                else
                {
                    Console.Write("\nTry one more time: ");
                }
            } while (!flag);

            Console.WriteLine("\nOkey, lets go to the next step!");
            Thread.Sleep(1200);
            Console.Clear();

            return path;
        }

        public static string GetFolder(WorkFiles type)
        {
            Console.WriteLine($"\nPress number of folder which you want to {type.ToString().ToLower()}?\n" +
                $"1 - Default\n2 - Enter your folder");

            switch (Сhecking.RangeInsert(1, 2))
            {
                case 1:
                    string path = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, @"ExampleFolder");

                    if (!File.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                return path;
                case 2:
                    return GetCorrectPath();
                default:
                    throw new ArgumentOutOfRangeException("\nIncorrect input!");
            }
        }

        public static void Rename(object source, RenamedEventArgs element)
        {
            Console.WriteLine($"File: {element.OldFullPath} renamed to {element.FullPath}");
        }

        public static void Recoil(string path)
        {
            string pathBackupFolder = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, @"BackUpFolder\");
            string nameDir = path.Substring(0, path.Length);
            nameDir = nameDir.Substring(nameDir.LastIndexOf('\\') + 1);

            foreach (var item in Directory.GetDirectories(pathBackupFolder))
            {
                if (item.Substring(item.LastIndexOf('\\') + 1) == nameDir)
                {
                    string dateTimeOfRevert = SelectRecoil(Path.Combine(pathBackupFolder, $@"{nameDir}\"));
                    string pathToRevert = Path.Combine(Path.Combine(pathBackupFolder, $@"{nameDir}\"), dateTimeOfRevert);

                    DirectoryInfo dir = new DirectoryInfo(path);
                    dir.Delete(true);

                    DirectoryCopy(pathToRevert, path, true);

                    Console.WriteLine("\nComplete!");
                }
            }

            Console.WriteLine("\nGo to the main menu in 3 seconds");
            Thread.Sleep(3000);

            Program.Beginning();
        }

        private static string SelectRecoil(string path)
        {
            int id = 0;

            Console.WriteLine("\nInput Id of DateTime to recoil for this DateTime");

            Dictionary<int, string> dict = new Dictionary<int, string>();

            foreach (var item in Directory.GetDirectories(path))
            {
                dict.Add(id, item.Substring(item.LastIndexOf('\\') + 1));
                Console.WriteLine($"ID: {id}, DateTime: {item.Substring(item.LastIndexOf('\\') + 1)}");
                id++;
            }
            int select = Сhecking.RangeInsert(0, dict.Keys.Count - 1);

            return dict[select];
        }
    }
}
