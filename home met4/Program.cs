using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_met4
{
    class Program
    {
        static long GetFibonacci(long n)
        {
            if (n==1 || n == 2)
            {
                return 1;
            }
            else
            {
                return GetFibonacci(n - 1) + GetFibonacci(n - 2);
            }
        }//домашнее задание 5.2
        static int GetNOD(int number1, int number2,int number3)
        {
            if ((GetNOD(number1, number2) == GetNOD(number1, number3)) && (GetNOD(number2, number3) == GetNOD(number1, number2) )&& (GetNOD(number2, number3) == GetNOD(number1, number3)))
            {
                return GetNOD(number1, number2);
            }
            else
            {
                return 1;
            }        
        }//домашнее задание 5.1 для трехзначных чисел
        static int GetNOD(int number1, int number2)
        {
            while (number1!=0&&number2!=0)
            {
                if (number1>number2)
                {
                    number1 %= number2;
                }
                else
                {
                    number2 %= number1;
                }               
            }
            return Math.Max(number1, number2);
        }//домашнее задание 5.1
        static long GetFactorialRecoursion(long number)
        {
            try
            {
                if (number == 0 || number == 1)
                {
                    return 1;
                }
                else
                {
                    return checked(number * GetFactorialRecoursion(number - 1));
                }
            }
            catch (OverflowException)
            {
                return 0;
            }           
        }//Упражнение 5.4
        static bool GetFactorial(long number, ref long factorial)
        {
            
            try
            {
                for (int i = 1; i <= number; i++)
                {
                    factorial = checked(factorial * i);
                }
                return true;
            }
            catch (OverflowException)
            {
                return false;
            }                      
        }//упражнение 5.3
        static void Swap(ref double number1, ref double number2)
        {
            double temp = number1;
            number1 = number2;
            number2 = temp;
        }//упражнение 5.2
        static double GetMax(double number1, double number2)
        {
            if (number1>number2)
            {
                return number1;
            }
            else 
            {
                return number2;
            }
        }//упражнение 5.1
        static void Main(string[] args)
        {
            Console.WriteLine("home 1");
            Console.WriteLine("Введите 2 числа");
            double number1 = Convert.ToDouble(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());           
            Console.WriteLine("Максимум = "+GetMax(number1,number2));

            Console.WriteLine("hometask 2");
            Console.WriteLine("Введите 2 числа");
            Console.Write("Первое = ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Второе = ");
            number2 = Convert.ToDouble(Console.ReadLine());
            Swap(ref number1, ref number2);
            Console.WriteLine($"Теперь первое число = {number1}, а второе = {number2}");

            Console.WriteLine("hometask 3");
            Console.WriteLine("Напишите число до какого посчитать факториал");
            long number = Convert.ToInt64(Console.ReadLine());
            long factorial=1;
            if (GetFactorial(number,ref factorial))
            {
                Console.WriteLine(factorial);
            }
            else
            {
                Console.WriteLine("Произошло переполнение!");
            }
            Console.WriteLine("hometask 4");
            Console.WriteLine(GetFactorialRecoursion(number));

            Console.WriteLine("hometask 2.1");
            Console.WriteLine("Введите два числа");
            int number3 = Convert.ToInt32(Console.ReadLine());
            int number4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Их нод = "+GetNOD(number3,number4));

            Console.WriteLine("hometask 2.2");
            Console.WriteLine("Введите 3 числа");
            number3 = Convert.ToInt32(Console.ReadLine());
            number4 = Convert.ToInt32(Console.ReadLine());
            int number5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Их нод = "+GetNOD(number3,number4,number5));

            Console.WriteLine("hometask 2.3");
            Console.WriteLine("Введите номер числа (индекс)Фибоначчи");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Значение числа Фибоначчи = "+GetFibonacci(number));
        }
    }
}
