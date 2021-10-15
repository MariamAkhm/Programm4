using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class4
{
    class Program
    {
        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        static int Partion(int[] array, int start, int end)
        {
            int supportPoint = array[start];
            int swapIndex = start;
            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < supportPoint)
                {
                    swapIndex++;
                    Swap(array, i, swapIndex);
                }
            }
            Swap(array, start, swapIndex);
            return swapIndex;
        }
        static int[] QuickSort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int supportPoint = Partion(array, start, end);
                QuickSort(array, start, supportPoint);
                QuickSort(array, supportPoint + 1, end);
            }
            return array;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("home1");
            int[] unSortedArray = new int[10];
            Random r = new Random();
            for (int i = 0; i < unSortedArray.Length; i++)
            {
                unSortedArray[i] = r.Next(100);
            }

            for (int i = 0; i < unSortedArray.Length; i++)
            {
                Console.WriteLine(unSortedArray[i]);
            }
            int[] sortedArray = QuickSort(unSortedArray, 0, unSortedArray.Length);
            Console.WriteLine();
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.WriteLine(sortedArray[i]);
            }

            Console.WriteLine("home2");
            int countPoints = r.Next(3, 100);
            Console.WriteLine("Количество точек в графе = " + countPoints);
            int[,] tableGraph = new int[countPoints, countPoints];
            Console.WriteLine(countPoints);
            //Таблица смежности рандомного графа
            for (int i = 0; i < countPoints; i++)
            {

                for (int j = 0; j < countPoints; j++)
                {
                    if (i == j)
                    {
                        tableGraph[i, j] = 0;
                        continue;
                    }
                    if (r.Next(0, 3) == 1)
                    {
                        tableGraph[i, j] = 1;
                        tableGraph[j, i] = 1;
                    }
                    if (tableGraph[i, j] == tableGraph[j, i])
                    {
                        continue;
                    }
                    else
                    {
                        tableGraph[i, j] = 0;
                    }
                }
            }
            int way = 0;
            int shortWay = countPoints;
            Console.WriteLine("Максимально возможный путь в данном графе(не учитывая,что граф замкнутый или <легкий>) = " + (countPoints - 1));
            bool isEasyGraph = false; //граф в котором из начальной точки можно попасть в любую за одно перемещение
            int temp = 0;

            for (int j = 1; j < countPoints - 1; j++)
            {
                if (tableGraph[0, j] == tableGraph[0, j + 1])
                {
                    temp += 1;
                }
            }
            if (temp == (countPoints - 1) - 1)
            {
                isEasyGraph = true;
            }
            //проверка графа на простоту ^
            for (int i = 0; i < countPoints; i++)
            {
                for (int j = 0; j < countPoints; j++)
                {
                    if (tableGraph[i, j] == 1)
                    {
                        temp = i;
                        for (int k = 0; k < countPoints; k++)
                        {
                            way += tableGraph[temp, k];
                        }
                        shortWay = Math.Min(way, shortWay);
                    }
                }
            }
            //поиск вглубь ^
            if (isEasyGraph && countPoints != 1)
            {

                shortWay = 1;
            }
            Console.WriteLine("Самый короткий путь в графе = " + shortWay);
        }
    }
}
