using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Search
    {
        public static void Search_In_Result()
        {
           
            
            // read path from configuration appsettings.json
            var lines = File.ReadAllLines("Output/result.txt");
            Console.WriteLine("Enter the value for search or exit to end program");
            // use full naming search instead srch, it is more readable
            var srch_value = Console.ReadLine();
            while (srch_value != "Exit" && srch_value != "exit")
            {
                if (float.Parse(lines.First().Split(new char[] { ' ', ',', '.', ':', '\t' }, StringSplitOptions.RemoveEmptyEntries).First()) < float.Parse(srch_value) && float.Parse(lines.Last().Split(new char[] { ' ', ',', '.', ':', '\t' }, StringSplitOptions.RemoveEmptyEntries).First()) > float.Parse(srch_value))
                {
                    foreach (var item in lines)
                    {


                        if (srch_value == item.Split(new char[] { ' ', ',', '.', ':', '\t' }, StringSplitOptions.RemoveEmptyEntries).First())
                        {
                            Console.WriteLine(item);
                        }
                    }
                    Console.WriteLine("Enter the value for search or exit to end program");

                    srch_value = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Wrong value");
                    srch_value = Console.ReadLine();
                }

            }

          
           

        }
    }
}
