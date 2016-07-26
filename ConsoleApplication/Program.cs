using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApplication
{
    class Program
    {



        static string path=@"G:\C#\KeyLogger\KeyLogger\bin\Debug\log.txt";
        static List<String> data = new List<String>(File.ReadAllLines(path));
        static void Main(string[] args)
        {
            Captialize();
            BackSpacing();
            
           
            
                       
        }
        static void Captialize()
        {
            int count = NumberofTimesThisStringComes("Capital");
            for(int i = 0; i < data.Count; i++)
            {
                if (data[i] == "Capital")
                {
                    for(int j = i; j < data.Count; j++)
                    {
                       
                    }
                }
            }
            
        }
        static int NumberofTimesThisStringComes(string str)
        {
            int count = 0;
            foreach(string st in data)
            {
                if (string.Equals(str, st))
                {
                    count += 1;
                }
            }
            return count;
        }
        static void ReplaceStuff()
        {
            Replace("Comma", ",");
            Replace("OemMinus", "-");
            Replace("OemPlus", "+");
        }
        static void BackSpacing()
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i] == "Return" && i != 0)
                {
                    data.RemoveAt(i - 1);
                }

            }
        }
        static void Replace(string thisString,string thatString)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i] == thisString)
                {
                    data[i]=thatString;
                }

            }
        }
       
        static Int32 CountString(string orig, string find)
        {
            var s2 = orig.Replace(find, "");
            return (orig.Length - s2.Length) / find.Length;
        }

    }
}
