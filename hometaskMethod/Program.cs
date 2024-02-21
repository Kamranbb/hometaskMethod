using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

namespace hometaskMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine(FirsTask(5, 10));
            Console.WriteLine(secondTask(22, 33));
            Console.WriteLine(thirdTask(10, 20));
            Console.WriteLine(fiveTask(64));
        }
        static int FirsTask(int a, int b)
        {
            return a / 2;
        }

      
        
        
        
        static int secondTask(int y, int z)
        {
            int sum = 0;
            for (int i = y; i < z; i++)

            {
                sum += i;

            }

            return sum;
        }

       
        
        
        static int thirdTask(int n, int m)
        {
            int count = 0;
            if (n < m)

            {
                for (int i = n; i < m; i++)
                {
                    if (i % 2 == 0)
                    {
                        count++;

                    }
                }
            }
            return count;
        }
       
        
        
        static bool fiveTask(int n)
        {
            int quvvet = 1;
            while (n > quvvet)
            {
                quvvet *= 2;
            }
            return n == quvvet;






        }



    }
 }
