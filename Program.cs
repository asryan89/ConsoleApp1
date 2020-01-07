
using System;
using System.IO;
using System.Linq;

// Rename to meanningfull word 
namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {   

            // 1. create folder input
            // 2. include in.text file
            int Lines_count = File.ReadLines("in.txt").Count();
            int Start = 0;

            // All variables should start lowercase 
            string Line;
            string[] Temp_to_File = new string[11];
            for (int i = 0; i <= Lines_count; i++)
            {
                // Use File.ReadLines("in.txt") one time on top, 
                // you read file in for, this is performance issue
                Temp_to_File[0] = File.ReadLines("in.txt").Skip(Start).Take(1).First();
                if (Start < Lines_count - 1)
                {
                    // use var instead type string
                    // 
                    string First_Line = File.ReadLines("in.txt").Skip(Start).Take(1).First();
                    string Second_Line = File.ReadLines("in.txt").Skip<string>(Start + 1).Take<string>(1).First<string>();
                    string[] First_line_Splited = First_Line.Split(new char[] { ' ', ',', '.', ':', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    string[] Second_Line_Splited = Second_Line.Split(new char[] { ' ', ',', '.', ':', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    // What about if [0] and [1] not exists ? catch that case
                    float First_value1 = float.Parse(First_line_Splited[0]);
                    float Second_value1 = float.Parse(Second_Line_Splited[0]);
                    float First_value2 = float.Parse(First_line_Splited[1]);
                    float Second_value2 = float.Parse(Second_Line_Splited[1]);
                    float Step = (Second_value2 - First_value2) / 10;
                    for (int h = 1; h < 10; h++)
                    {
                        Temp_to_File[h] = (First_value1 + h).ToString() + "\t\t" + (First_value2 + Step * h).ToString();
                    }

                    // Create folder output and write result.txt into folder
                    // what about if result.txt has already exist 
                    using (StreamWriter streamWriter = new StreamWriter("result.txt", true))
                    {
                        for (int i1 = 0; i1 < 10; i1++)
                            streamWriter.WriteLine(Temp_to_File[i1]);
                    }
                    Start++;
                }
            }

            using (StreamWriter streamWriter = new StreamWriter("result.txt", true))
                streamWriter.WriteLine(File.ReadLines("in.txt").Skip(Lines_count - 1).Take(1).First());
            
            Console.WriteLine("Enter the value for search or exit to end program");
            
            string Srch = Console.ReadLine();
            int Lines_count1 = File.ReadLines("result.txt").Count();
            
            while (Srch != "Exit" && Srch != "exit")
            {
                if (float.Parse(Srch) >= float.Parse(File.ReadLines("result.txt").Skip(0).Take(1).First().Split(new char[] { ' ', ',', '.', ':', '\t' }, StringSplitOptions.RemoveEmptyEntries)[0])
                    && (float.Parse(Srch) <= float.Parse(File.ReadLines("result.txt").Skip(Lines_count1 - 1).Take(1).First().Split(new char[] { ' ', ',', '.', ':', '\t' }, StringSplitOptions.RemoveEmptyEntries)[0])))
                {
                    for (int i = 0; i < Lines_count1; i++)
                    {
                        Line = File.ReadLines("result.txt").Skip(i).Take(1).First();
                        if (Line.Contains(Srch))
                        {
                            Console.WriteLine(Line);
                            break;
                        }
                    }
                    Console.WriteLine("Enter the value for search or exit to end program");

                    Srch = Console.ReadLine();

                }
                else
                {
                    // use $ for string concatination
                    Console.WriteLine("Plesae enter value from \t" +
                        float.Parse(File.ReadLines("result.txt").Skip(0).Take(1).First().Split(new char[] { ' ', ',', '.', ':', '\t' }, StringSplitOptions.RemoveEmptyEntries)[0]) + "\tto \t" +
                        float.Parse(File.ReadLines("result.txt").Skip(Lines_count1 - 1).Take(1).First().Split(new char[] { ' ', ',', '.', ':', '\t' }, StringSplitOptions.RemoveEmptyEntries)[0]));
                    Srch = Console.ReadLine();
                }



            }
        }
    }
}
