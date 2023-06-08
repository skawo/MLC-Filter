using System;
using System.Linq;

namespace MLC_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                string CurDirTxt = System.IO.Path.Combine(Environment.CurrentDirectory, "mlc_checker.txt");

                if (System.IO.File.Exists(CurDirTxt))
                    args = new string[] { CurDirTxt };
                else
                {
                    Console.WriteLine("Usage: mlcfilter.exe mlc_checker.txt");
                    return;
                }
            }

            string[] Lines = System.IO.File.ReadAllLines(args[0]);
            System.IO.File.WriteAllLines(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(args[0]), "out.txt"), Lines.Where(x => !x.EndsWith("-00000000")));
        }
    }
}
