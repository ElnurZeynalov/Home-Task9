using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group();
            group.No = Console.ReadLine();
            group.Student = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(group.No);
            Console.WriteLine(group.Student);
        }
    }
}
