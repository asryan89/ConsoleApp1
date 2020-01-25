using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //if all functions are static make class also static 
    // rename to Calculator, make noun
    class Calculate
    {
        public static List<string> result = new List<string>();
        
        //use complete meaning of methods, instead of Calc use Calculator
        public static List<string> Calc(List<string[]> input) {
            // change meaningfull variables, change first and second_value
            float first_value_1;
         
            float second_value_1;
            float second_value_2;
            string [] temp  = new string[3];
            float step;
           
            for (int i = 0; i < input.Count-1; i++)
            {
                // you can remove these variables and direct use into string
                // sample is bellow
                first_value_1 = float.Parse(input[i].First());
              //  first_value_2 = float.Parse(input[i+1].First());
                second_value_1 = float.Parse(input[i].Last());
                second_value_2 = float.Parse(input[i + 1].Last());
                step = (second_value_2 - second_value_1) / 10;
                for (int j = 0; j < 10; j++)
                {
                    // use $ symbol 
                    // for example $"{first_value_1 + j}\t{second_value_1 + j * step}"
                    result.Add((first_value_1 + j).ToString() + "\t" + (second_value_1 + j * step).ToString());
                }
            }

            //same here 
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
