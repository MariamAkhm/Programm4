using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Home_4
{
    class Program
    {
        static void Answer (double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("Корней нет");
            }
            else if (d == 0)
            {
                Console.WriteLine("x = " + (-b / (2*a)));
            }
            else if(a==0)
            {
                Console.WriteLine("x= "+(-c)/b);
            }
            else
            {
                Console.WriteLine("x1 = " + (-b+Math.Sqrt(d))/(2*a)+"x2 = "+(-b-Math.Sqrt(d))/(2*a));
            }
        }// задание 1
        static double[] BubbleSort (double[] massive)
        {
            double rotate = 0;
            for(int i = 0; i < massive.Length; i++)
            {
                for (int j = 0; j < massive.Length; j++)
                {
                    if (massive[i] > massive[j])
                    {
                        rotate = massive[i];
                        massive[i] = massive[j];
                        massive[j] = rotate;
                    }
                }
            }
            return massive;
        }//задание 3
        static double GetSummOfElem (params double[] massOfArguments)
        {
            double summOfElem = 0;
            for (int i = 0; i < massOfArguments.Length; i++)
            {
                summOfElem += massOfArguments[i];
            }
            return summOfElem;
        } 
        static void GetProductOfElem(double product,double[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                product *= mass[i];
            }
        }
        static void GetAverageOfElem(out double average, double[] mass)
        {
            average = mass.Sum() / mass.Length;
        }//задание 4
        static void Main(string[] args)
        {
            Console.WriteLine("class 1");
            Console.WriteLine("Введите кэффициенты уравнения (a, b, c)");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Корни уравнения:");
            Answer(a, b, c);

            Console.WriteLine("class 2");
            double[] numbers = new double[20];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToDouble(Console.ReadLine());

            }
            Console.WriteLine("Введите индексы элементов массива, которые нужно поменять местами (начинается с нулевого элемента)");
            int indexOfElem1 = Convert.ToInt32(Console.ReadLine());
            while (indexOfElem1 > 20 || indexOfElem1 < 0)
            {
                Console.WriteLine("Число должно быть от 0 до 20");
                indexOfElem1 = Convert.ToInt32(Console.ReadLine());
            }
            int indexOfElem2 = Convert.ToInt32(Console.ReadLine());
            while (indexOfElem2 > 20 || indexOfElem2 < 0)
            {
                Console.WriteLine("Число должно быть от 0 до 20");
                indexOfElem2 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Элементы массива:" + numbers[indexOfElem1] + " " + numbers[indexOfElem2]);
            double rotate = numbers[indexOfElem1];
            numbers[indexOfElem1] = numbers[indexOfElem2];
            numbers[indexOfElem2] = rotate;
            Console.WriteLine("Элементы нового массива:" + numbers[indexOfElem1] + " " + numbers[indexOfElem2]);

            Console.WriteLine("class 3");
            Console.WriteLine("Вы ввели количество элементов, теперь введите значения этих элементов");
            int countOfElem = 0;
            try
            {
                countOfElem = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("");
                countOfElem = Convert.ToInt32(Console.ReadLine());
            }
            numbers = new double[countOfElem];
            for (int i = 0; i < countOfElem; i++)
            {
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }
            numbers = BubbleSort(numbers);
            for (int i = 0; i < countOfElem; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("class 4");
            double product = 1;
            double average;
            countOfElem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы ввели количество элементов, теперь введите значения этих элементов");
            numbers = new double[countOfElem];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToDouble(Console.ReadLine());

            }
            double sum = GetSummOfElem(numbers);
            GetAverageOfElem(out average, numbers);
            GetProductOfElem(product, numbers);
            Console.WriteLine($"Сумма значений элементов= {sum}; Произведение значений элементов=  {product}; Среднее арифметическре элементоd {average}") ;
            
            Console.WriteLine("class 5");
            bool flag = true;
            while(flag)
            {
                try
                {
                    Console.WriteLine("Введите число от 0 до 9");
                    string str = Console.ReadLine();
                    if (str == "exit" || str == "выйти")
                    {
                        flag = false;
                        continue;
                    }
                    int number = Convert.ToInt32(str);
                    if (number < 0 || number > 9)
                    {
                        throw new Exception();
                    }
                    switch (number)
                    {
                        case 0:
                            Console.WriteLine("#####\n#   #\n#   #\n#   #\n#####");
                            break;
                        case 1:
                            Console.WriteLine("#\n#\n#\n#\n#");
                            break;
                        case 2:
                            Console.WriteLine("####\n   #\n####\n#   \n####");
                            break;
                        case 3:
                            Console.WriteLine("####\n   #\n####\n   #\n####");
                            break;
                        case 4:
                            Console.WriteLine("#  #\n#  #\n####\n   #\n   #");
                            break;
                        case 5:
                            Console.WriteLine("####\n#   \n####\n   #\n####");
                            break;
                        case 6:
                            Console.WriteLine("####\n#   \n####\n#  #\n####");
                            break;
                        case 7:
                            Console.WriteLine("####\n   #\n  ####\n   #\n   #");
                            break;
                        case 8:
                            Console.WriteLine("####\n#  #\n####\n#  #\n####");
                            break;
                        case 9:
                            Console.WriteLine("####\n#  #\n####\n   #\n####");
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.Clear();
                    for (int i = 0; i < 1008; i++)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("ERROR");                       
                    }
                    Thread.Sleep(3000);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                }
                
            }
        }
    }
}
