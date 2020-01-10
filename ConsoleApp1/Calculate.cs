using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calculate
    {
        public static List<string> result = new List<string>();
        public static List<string> Calc(List<string[]> input) {
            float first_value_1;
         
            float second_value_1;
            float second_value_2;
            string [] temp  = new string[3];
            float step;
           
            for (int i = 0; i < input.Count-1; i++)
            {
                first_value_1 = float.Parse(input[i].First());
              //  first_value_2 = float.Parse(input[i+1].First());
                second_value_1 = float.Parse(input[i].Last());
                second_value_2 = float.Parse(input[i + 1].Last());
                step = (second_value_2 - second_value_1) / 10;
                for (int j = 0; j < 10; j++)
                {
                  result.Add((first_value_1 + j).ToString() + "\t" + (second_value_1 + j * step).ToString());
                }
            }

            result.Add(input[input.Count-1].First() + "\t"+ input[input.Count - 1].Last());
            Console.WriteLine();
           
            foreach (var item in result)
            {
               
                Console.WriteLine(item);

            }
            return result;
        }
    }
}
