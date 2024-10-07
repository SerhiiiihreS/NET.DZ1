using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DZ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            Console.WriteLine("It's easy\r\nto win forgiveness for being wrong; being right is what gets you\r\ninto real trouble.");
            Console.WriteLine("_____________________________________________________________________________________");

            //Задание 2
            Console.WriteLine("Enter.");
            int a=Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int f = Convert.ToInt32(Console.ReadLine());
            int summ1 = Convert.ToInt32(a+b+c+d+f);
            Console.WriteLine("Summ-> "); Console.WriteLine(summ1);
            Console.WriteLine("-------");
            int derv = Convert.ToInt32(a * b * c * d * f);
            Console.WriteLine("derv->"); Console.WriteLine(derv);
            Console.WriteLine("-------");
            int min = a;
            if (min > b)
            { min = b;
            };
            if (min > c) 
            {
                min = c;
            };
            if (min > d)
            {
                min = d;
            };
            if (min > f)
            {
                min = f;
            };
            Console.WriteLine("min->"); Console.WriteLine(min);
            Console.WriteLine("-------");
            int max = a;
            if (max < b)
            {
                max = b;
            };
            if (max < c)
            {
                max = c;
            };
            if (max < d)
            {
                max = d;
            };      
            if (max < f)
            {
                max = f;
            };
            Console.WriteLine("max->"); Console.WriteLine(max);
            Console.WriteLine("_____________________________________________________________________________________");
            //Задание 3
            Console.WriteLine("Enter.");
            double s=Convert.ToDouble(Console.ReadLine());
            int s1=Convert.ToInt32(s%10); int s2 = Convert.ToInt32(((s - s1) / 10) % 10);
            int s3 = Convert.ToInt32(((s - s%100) / 100) % 10); int s4 = Convert.ToInt32(((s - s%1000) / 1000) % 10); int s5 = Convert.ToInt32(((s - s%10000) / 10000) % 10);
            int s6 = Convert.ToInt32(s/100000);
            Console.WriteLine(s1); Console.WriteLine(s2); Console.WriteLine(s3); Console.WriteLine(s4); Console.WriteLine(s5); Console.WriteLine(s6);
            Console.WriteLine("_____________________________________________________________________________________");
            //Задание 4
            Console.WriteLine("Enter end of range ->"); int df = Convert.ToInt32(Console.ReadLine());int df1 =Convert.ToInt32(0); int df2 = Convert.ToInt32(0); int df3 = Convert.ToInt32(0);
            for (int i = 0; i < df; i++) { df1 = i;df2 = df1 + i;if (df2 < df) { Console.WriteLine(df2); i = df2; } }
        }
    }
}
