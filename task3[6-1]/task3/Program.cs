using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];

            Console.WriteLine("Enter values for 3x3 array:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Element [{i},{j}]: ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Array in table format:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(arr[i, j] + "\t");
                }
                Console.WriteLine();

            }
            Console.WriteLine("----------------------------------------------------------");
            int[,] matrix = { {1, 2, 3, 4},
                                  {5, 6, 7, 8},
                                  {9, 10, 11, 12},
                                  {13, 14, 15, 16}};

            for (int i = 0; i < 4; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < 4; j++)
                    rowSum += matrix[i, j];

                Console.WriteLine($"Sum of row {i}: {rowSum}");
            }

            for (int j = 0; j < 4; j++)
            {
                int colSum = 0;
                for (int i = 0; i < 4; i++)
                    colSum += matrix[i, j];

                Console.WriteLine($"Sum of column {j}: {colSum}");
            }
            Console.WriteLine("----------------------------------------------------------");
            int[,] arr1 = new int[5, 5];
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr1[i, j] = rnd.Next(1, 51);
                    Console.WriteLine(arr1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 5; i++)
            {
                int max = arr1[i, 0];
                for (int j = 1; j < 5; j++)
                    if (arr1[i, j] > max)
                        max = arr1[i, j];

                Console.WriteLine($"Largest in row {i}: {max}");
            }


            for (int j = 0; j < 5; j++)
            {
                int min = arr1[0, j];
                for (int i = 1; i < 5; i++)
                    if (arr1[i, j] < min)
                        min = arr1[i, j];

                Console.WriteLine($"Smallest in column {j}: {min}");
            }
            Console.WriteLine("----------------------------------------------------------");

            //Jagged array

            int[][] jagged = new int[3][];

            jagged[0] = new int[2];
            jagged[1] = new int[3];
            jagged[2] = new int[4];

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.WriteLine($"Enter element [{i}][{j}]: ");
                    jagged[i][j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Jagged Array:");
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                    Console.Write(jagged[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------------------------");
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            int[][] jagged1 = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                Console.Write($"Enter length of row {i}: ");
                int length = int.Parse(Console.ReadLine());

                jagged1[i] = new int[length];

                for (int j = 0; j < length; j++)
                {
                    Console.Write($"Enter element [{i}][{j}]: ");
                    jagged1[i][j] = int.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine("Jagged Array:");
            for (int i = 0; i < jagged1.Length; i++)
            {
                foreach (int x in jagged1[i])
                    Console.Write(x + " ");
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------------------------");
            int[][] jagged2 = new int[5][];
            Random randomnum = new Random();

            for (int i = 0; i < 5; i++)
            {
                jagged2[i] = new int[i + 1];
                int sum = 0;

                for (int j = 0; j < jagged2[i].Length; j++)
                {
                    jagged2[i][j] = randomnum.Next(1, 100);
                    sum += jagged2[i][j];
                }

                Console.WriteLine($"Sum of row {i + 1}: {sum}");
            }

            Console.WriteLine("-----------------------------------------------------------------");

            List<int> numbers = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter number: ");
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            foreach (int n in numbers)
                Console.WriteLine(n);
            Console.WriteLine("-----------------------------------------------------------------");
            List<string> students = new List<string> { "Ali", "Zaid", "Bana", "Lina", "kareem" };
            students.Sort();
            Console.WriteLine("Sorted Names:");
            foreach (string name in students)
                Console.WriteLine(name);
            Console.WriteLine("-----------------------------------------------------------------");

            List<int> nums = new List<int>();
            Console.WriteLine("If you want to stop please insert -1 ");
            while (true)
            {
                int n = int.Parse(Console.ReadLine());

                if (n == -1)
                    break;

                nums.Add(n);
            }


            Console.WriteLine("Elements : ");
            foreach (int x in nums)
                Console.WriteLine(x);


            double avg = nums.Average();
            Console.WriteLine("Avarage: " + avg);


            Console.WriteLine("Max number : " + nums.Max());
            Console.WriteLine("Min number: " + nums.Min());


            nums.Sort();
            Console.WriteLine("Sorted List : ");
            foreach (int x in nums)
                Console.WriteLine(x);

        }
    }
}