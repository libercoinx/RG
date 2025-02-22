// See https://aka.ms/new-console-template for more information
using System;

namespace myApp
{
    class Program
    {
        static bool isPrime(int n)
        {
            for (int j = 2; j < n; j++)
                if (n % j == 0) return false;
            return true;
        }

        static void Main()
        {
            int upperBound, lowerBound = 0;
            string ubStr, lbStr = "";

            //确保输入正确
            while (true)
            {
                try
                {
                    ubStr = Console.ReadLine();
                    lbStr = Console.ReadLine();
                    upperBound = int.Parse(ubStr);
                    lowerBound = int.Parse(lbStr);
                    if ((upperBound > lowerBound) && (lowerBound > 1))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("上界必须大于下界，且输入必须大于1，请重新输入！");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("未输入数字:{0}", ex.Message);
                }
            }

            //输出素数
            int count = 0;  //控制十个数字一行
            for (int i = lowerBound; i <= upperBound; i++)
            {
                if (isPrime(i))
                {
                    count++;
                    Console.Write(i.ToString() + '\t');
                    if (count % 10 == 0) Console.WriteLine();
                }
            }
        }
    }
}
