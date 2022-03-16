using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dll;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Текст";
            Class1.Student.Random(a);
            foreach (var b in Class1.students)
            {
                Console.WriteLine(b.FIO);
                int[] dis = Class1.Student.GetCountDisease(b.mr);
                int[] tr = Class1.Student.GetCountTruancy(b.mr);
                Console.WriteLine("Прогулы:");
                for (int i = 0; i<dis.Length; i++)
                {
                    if (dis[i]!=0)
                    {
                        Console.WriteLine(dis[i]);
                    }
                }
                Console.WriteLine("Пропуски:");
                for (int i = 0; i < tr.Length; i++)
                {
                    if (tr[i] != 0)
                    {
                        Console.WriteLine(tr[i]);
                    }
                }
                foreach (var item in b.mr)
                {
                    Console.WriteLine(item.Estimation +" "+ item.date);
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
