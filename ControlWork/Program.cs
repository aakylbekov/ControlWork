using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ControlWork
{
    class Program
    {
        static void Main(string[] args)
        {
            NewFile2();


        }

        static DirectoryInfo CreateNewDir(string path)
        {
            DirectoryInfo dtr = new DirectoryInfo(path);
            dtr.Create();
            return dtr;

        }
        static void NewFile2()
        {
            string path = @"C:\temp";
            CreateNewDir(path);
            #region K1
            var dirK1 = CreateNewDir(@"C:\temp\K1");
            string path1 = Path.Combine(dirK1.FullName, "t1.txt");
            FileInfo filet1 = new FileInfo(path1);
            FileStream fst1 = filet1.Create();
            
            fst1.Close();

            

            StreamWriter strt1 = new StreamWriter(path1);
            strt1.Write("Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов");
            strt1.Close();
            #endregion 

            #region K2
            var dirK2 = CreateNewDir(@"C:\temp\K2");
            string path2 = Path.Combine(dirK2.FullName, "t2.txt");
            FileInfo filet2 = new FileInfo(path2);
            FileStream fst2 = filet2.Create();
            fst2.Close();

            StreamWriter strt2 = new StreamWriter(path2);
            strt2.Write("Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
            strt2.Close();
            #endregion

            #region T3
            string path3 = Path.Combine(dirK2.FullName, "t3.txt");
            FileInfo filet3 = new FileInfo(path3);
            FileStream fst3 = filet3.Create();
            filet3.MoveTo(@"C:\temp\K2\t3.txt");

            fst2.Close();
            #endregion

            #region backup
            Path.GetDirectoryName(path);
            Path.GetDirectoryName(path1);
            Path.GetDirectoryName(path2);
            Path.GetDirectoryName(path3);
            #endregion

            #region 
            Directory.Move(@"C:\temp\K2\t2.txt", @"C:\temp\K1\t1o.txt");
            Directory.Move(@"C:\temp\K1\t1.txt", @"C:\temp\K2\t2o.txt");
            Directory.Move(@"C:\temp\K2", @"C:\temp\ALL");
            Directory.Delete(@"C:\temp\K1");
            #endregion

            Path.GetDirectoryName(@"C:\temp\ALL");

             
        }
    }
}
