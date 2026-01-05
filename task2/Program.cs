using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int evennum = 0;
            int oddnum = 0;
            int grade;
            Console.WriteLine("Insert Ten Random number : ");
            for (int i = 0; i <= 10; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    continue;
                }
                if (number == 0)
                {
                    break;
                }
                if (number % 2 == 0)
                {
                    evennum++;
                }
                else
                {
                    oddnum++;
                }
            }
            Console.WriteLine("Even Number = " + evennum);
            Console.WriteLine("Odd Number = " + oddnum);
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Insert Student's Grade between 0 and 100\t");
            grade = int.Parse(Console.ReadLine());
            while (grade < 0 || grade > 100)
            {
                Console.WriteLine("\t\tInvalid grade!\nEnter again number between 0 and 100");
                grade = int.Parse(Console.ReadLine());
            }
            if (grade >= 90)
                Console.WriteLine("Grade: A");
            else if (grade >= 80)
                Console.WriteLine("Grade: B");
            else if (grade >= 70)
                Console.WriteLine("Grade: C");
            else if (grade >= 60)
                Console.WriteLine("Grade: D");
            else
                Console.WriteLine("Grade: F");

            while (true)
            {
                Console.WriteLine("Choose operation  (+,_,*,/) ");
                char operation = char.Parse(Console.ReadLine());

                Console.Write("Enter First Number: ");
                double number1 = double.Parse(Console.ReadLine());

                Console.Write("Enter Second Number: ");
                double number2 = double.Parse(Console.ReadLine());

                switch (operation)
                {
                    case '+':
                        Console.WriteLine(number1 + " + " + number2 + " = " + (number1 + number2));
                        break;
                    case '-':
                        Console.WriteLine(number1 + " - " + number2 + " = " + (number1 - number2));
                        break;
                    case '*':
                        Console.WriteLine(number1 + " * " + number2 + " = " + (number1 * number2));
                        break;
                    case '/':
                        if (number2 != 0)
                            Console.WriteLine(number1+" / "+number2 +" = "+ (number1 / number2));
                        else
                            Console.WriteLine("Cannot divide by zero!");
                        break;
                    default:
                        Console.WriteLine("Invalid operation!");
                        break;
                }

                Console.Write("Do you want to continue? (y/n): ");
                char choice = char.Parse(Console.ReadLine());

                if (choice == 'n' || choice == 'N')
                {
                    break;
                }
            }
        }
    }
}