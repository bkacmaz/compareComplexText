using System;
using System.IO;

namespace ReadableTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string textSimple = "";
            string text = File.ReadAllText("..\\..\\..\\complicated.txt");
            string[] array = text.Split(' ');
            for (int i=0; i<array.Length;i++)
            {
                if (i%2==0)
                {
                    for(int j=array[i].Length-1; j>=0; j--)
                    {
                        textSimple += array[i].Substring(j, 1);
                    }                   
                }
                else
                {
                    textSimple += " " + array[i].Substring(1, array[i].Length - 2) + " " ;
                }
            }        
            Console.WriteLine(textSimple);
        }
    }
}
