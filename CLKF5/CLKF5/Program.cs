using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace CLKF5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a writer and open a file with following name
            TextWriter grafattiWriter = new StreamWriter("CouchProg.txt");

            // for as log as this condition is true
            for (int i = 0; i < 942; i++)
            {
                grafattiWriter.WriteLine(DateTime.Now + "S factor is showing booty...d[db]b"); // do this work
            }

            // closes the stream
            grafattiWriter.Close();
            
            TextReader elLibrarianReader = new StreamReader("CouchProg.txt");
            Console.WriteLine(elLibrarianReader.ReadLine());
            elLibrarianReader.Close();

            string[] nichiText = File.ReadAllLines(@"C:\Users\Developer\Documents\Visual Studio 2013\Projects\CLKF\GitExercise\GitExercise5.CouchProg\CLKF5\CLKF5\bin\Debug\CouchProg.txt");
            
            Console.WriteLine(nichiText.ToString());
            
            Console.ReadLine();
        }

    }
}
