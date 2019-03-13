using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            DoMathDivision();
            MassiveTest();
            Console.ReadLine();
        }

        public static void DoMathDivision()
        {
            try
            {
                int x;
                int y;
                Console.WriteLine("Введите два числа");
                if (Int32.TryParse(Console.ReadLine(), out x) && Int32.TryParse(Console.ReadLine(), out y))
                {
                    var z = x / y;
                    Console.WriteLine(z);
                }
                else
                {
                    throw new ArgumentNullException("Null");
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);                
            }

        }
        
        public static void MassiveTest()
        {
            try
            {
                int count = 5;
                int[] numbers = new int[count];
                for(int i = 0; i < count + 1; i++)
                {
                    numbers[i] = i;
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Массив обработан");
            }
        }
    }

}
