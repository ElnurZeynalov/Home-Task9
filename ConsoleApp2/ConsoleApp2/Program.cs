using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yaradilacaq qruplarin sayini daxil edin");
            int Length;
            string Str;
            do
            {
                Console.Write("Deyer daxil edin: ");
                Str = Console.ReadLine();
                if (!int.TryParse(Str, out Length))
                {
                    Console.WriteLine("\n\tYalnizca reqem daxil edin\n");
                }
            } while (!int.TryParse(Str, out Length));
            Length = Convert.ToInt32(Str);
            Group[] Students = new Group[Length];
            string groupNo = Checker("Qrup Adini daxil edin: ");
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine($"\n========Telebe {i + 1}========\n");
                string name = Checker("Telebenin adini daxil edin: ",2);
                string lastName = Checker("Telebenin soyadini daxil edin: ",5);
                int age = AgeChecker("Telebenin yasini daxil edin: ");
                Group Student = new Group()
                {
                    No = groupNo,
                    Name = name,
                    LastName = lastName,
                    Age = age
                };
                Students[i] = Student;
            }
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine($"\n======{i+1}.Telebe======");
                Console.WriteLine(Students[i].GetInfo());
            }
        }
        static int AgeChecker(string value)
        {
            int Age = 0;
            string Str;
            while (!(Age > 15))
            { 
            do
            {
                Console.Write(value);
                Str = Console.ReadLine();
                    if (!int.TryParse(Str, out Age))
                        Console.WriteLine("Yasi yalnizca reqemle daxil edin");
                    if(!(Age>15))
                        Console.WriteLine("Telebenin yasi 15 den boyuk olmalidir");
            } while (!int.TryParse(Str, out Age));
            Age = Convert.ToInt32(Str);
            }
            return Age;
        }
        static string Checker(string value, int min)
        {
            string test;
            do
            {
                Console.Write(value);
                test = Console.ReadLine();
                if(!StrChecker(test, min))
                    Console.WriteLine($"\nDaxil olunan deyer boyuk herfle Baslamali ve yalniz herflerden ibaret olmalidir.Deyerin uzunlugu {min} cox olamlidir\n");
            } while (!StrChecker(test,min));
            return test;
        }
        static string Checker(string value) //ozum bilerek eyni yazdim tekrar meqsedli yoxsa BestPractice olmadigini bilirem :D
        {
            string test;
            do
            {
                Console.Write(value);
                test = Console.ReadLine();
                if (!NoChecker(test))
                    Console.WriteLine("\nQrup adi 2 Boyuk herf ve 3 reqem ,Toplam 5 simvoldan ibaret olmalidir\n");
            } while (!NoChecker(test));
            return test;
        }
        static bool NoChecker(string value)
        {
            if (value.Length == 5 && char.IsUpper(value[0]) && char.IsUpper(value[1]) && char.IsDigit(value[2]) && char.IsDigit(value[3]) && char.IsDigit(value[4]))
                return true;
            return false;
        }
        static bool StrChecker(string value,int min)
        {
            int count = 0;
            if (value.Length > min)
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsLetter(value[i]))
                    {
                        count++;
                    }
                }
                if (count == value.Length && char.IsUpper(value[0]))
                    return true;
            }
            return false;
        }
    }
}
