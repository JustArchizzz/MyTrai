using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trai
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Calculator + - * / \n\n");

            int temp1 = 0;
            string temp2 = "";
            string a;
            while(true)
            {
                a = Console.ReadLine();
                a = a.Trim();

                string[] numsAndOperators = a.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int answ = Convert.ToInt32(numsAndOperators[0]);

                for (int i = 1; i < numsAndOperators.Length - 1; i += 2)
                {
                    if (i + 1 >= numsAndOperators.Length)
                    {
                        Console.WriteLine("Error");
                        return;
                    }

                    if (numsAndOperators[i] == "*" || numsAndOperators[i] == "/" || numsAndOperators[i] == "+" || numsAndOperators[i] == "-")
                    {
                        temp2 = numsAndOperators[i];
                        temp1 = Convert.ToInt32(numsAndOperators[i + 1]);
                        switch (temp2)
                        {
                            case "*":
                                answ *= temp1;
                                break;
                            case "/":
                                if (temp1 == 0)
                                {
                                    Console.WriteLine("Ошибка: деление на ноль");
                                    return;
                                }
                                answ /= temp1;
                                break;
                            case "+":
                                answ += temp1;
                                break;
                            case "-":
                                answ -= temp1;
                                break;
                        }
                    }
                }
                Console.WriteLine($" = {answ}");
            }
        }
    }
}
