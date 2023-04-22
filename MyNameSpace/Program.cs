using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNameSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, a, b, c,d;
            int choice = 0;
            while (choice != 3)
            {

                Console.WriteLine("Hello...Choose option from below");
                Console.WriteLine("1.perform Arithmetic operation ");
                Console.WriteLine("2.perform String operation ");
                Console.WriteLine("3.Exit ");
                choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the values of x and y");
                        x = Convert.ToInt32(Console.ReadLine());
                        y = Convert.ToInt32(Console.ReadLine());

                        MyMaths obj1 = new MyMaths();
                        a = obj1.Add(x, y);
                        Console.WriteLine("sum of x and y is : " + a);
                        b = obj1.Subs(x, y);
                        Console.WriteLine("subs of x and y is : " + b);
                        c = obj1.Mul(x, y);
                        Console.WriteLine("Mul of x and y is : " + c);
                        Console.WriteLine();

                        break;

                        

                    case 2:
                        Console.WriteLine("Enter the string:");
                        string input = Console.ReadLine();
                        Console.WriteLine("Input string: " + input);

                        string reversedString = MyString.ReverseString(input);
                        Console.WriteLine("Reversed string: " + reversedString);

                        Console.WriteLine("Splited string:");
                        string[] s2 = input.Split(' ');
                        foreach (string s3 in s2)
                        {
                            Console.WriteLine(s3);

                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Exiting program.");
                        Console.ReadKey();
                        break;


                    default:
                        Console.WriteLine("choosen wrong option");
                        Console.ReadKey();
                        break;
                        

                }
            }
            
                
        }
    }
}
