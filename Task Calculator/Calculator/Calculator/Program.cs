using System;

namespace method_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci ededi daxil edin :");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Goreceyiniz Emeliyyati secin :");
            char opr = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Ikinci ededi daxil edin :");
            int num2 = Convert.ToInt32(Console.ReadLine());


            if (opr=='+' || opr =='-' || opr == '*' || opr == '/' )
            {
                Console.Clear();

                Console.WriteLine("Cavab : " + " " + calculator(num1, num2, opr));
            }
            else
            {
                Console.WriteLine("Duzgun operatoru daxil edin");
            }

            

        }
        static int calculator(int num1, int num2, char opr)
        {
            int result = 0;
            switch (opr)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
            }
            return result;


        }

    }
}
