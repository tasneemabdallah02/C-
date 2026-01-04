using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dnum = 3.3;
            float fnum = 5.6f;
            char ch = 'T';
            bool b = true;
            const int num= 0;
            string str1 = "string text";

            string str;
            Console.WriteLine("Please insert string");
            str= Console.ReadLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("double num : "+dnum);
            Console.WriteLine("float num : " + fnum);
            Console.WriteLine("char  : " + ch);
            Console.WriteLine("bool type : " + b);
            Console.WriteLine("const num : " + num);
            Console.WriteLine("string  : " + str1);
            Console.WriteLine("--------------------------------------------");
            string[] Cars = { "Audi", "BMW", "Range Rover" };
            Console.Write("The length of array = 3 : ");
            Console.Write("\t"+Cars[0]);
            Console.Write("\t"+Cars[1]);
            Console.Write("\t" +Cars[2]+"\n");
            Console.WriteLine("--------------------------------------------");
            string firstname;
            string lastname;
            string birthdate;
            Console.WriteLine("Enter your First Name : ");
            firstname= Console.ReadLine();
            Console.WriteLine("Enter your last Name : ");
            lastname= Console.ReadLine();
            Console.WriteLine("Enter your birthdatde : ");
            birthdate = Console.ReadLine();
            Console.WriteLine(firstname + lastname + birthdate);
            Console.WriteLine("--------------------------------------------");
            int[] array ={1,2,3,4,5,6,7,8,9,10};
           for(int i = 0; i <= array.Length; i++)
            {
                Console.WriteLine(array[i]);

            }


        }
    }
}
