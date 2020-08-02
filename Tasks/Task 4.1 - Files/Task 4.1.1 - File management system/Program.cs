using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Task_4._1._1___File_management_system
{
    public enum WorkFiles
    {
        None,
        Browsing,
        Recoil
    }

    class Program
    {
        static void Main(string[] args)
        {
            Beginning();
        }

        public static void Beginning()
        {
            Console.Clear();

            Backup.CreateBackupFolder();

            WorkFiles type = SelectTypeOfWorkFiles();
            string path = Backup.GetFolder(type);
            if (type == WorkFiles.Browsing)
            {
                Watch.Watching(path);
            }
            else
            {
                Backup.Recoil(path);
            }
        }

        private static WorkFiles SelectTypeOfWorkFiles()
        {
            Console.WriteLine("Select the type of file management:\n\t1 - Browsing\n\t2 - Recoil");
            
            switch (Сhecking.RangeInsert(1, 2))
            {
                case 1:
                    return WorkFiles.Browsing;
                case 2:
                    return WorkFiles.Recoil;
                default:
                    throw new ArgumentOutOfRangeException("Incorrect input!");
            }
        }
    }
}
