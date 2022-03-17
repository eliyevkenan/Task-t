using System;

namespace ConsoleApp40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded daxil edin");
            string counts=Console.ReadLine();
            int count;
            Group[] arr=new Group[counts.Length];
            for (int i=0; i<counts.Length; i++)
            {
                string No;
                string Studentlimit;
                int studentlimit;
                Console.WriteLine(i+1+"Qrupun nomresini daxil edin");
                No = Console.ReadLine();

                Console.WriteLine(i + 1 + "Telebe limitini daxil edin");
                Studentlimit = Console.ReadLine();
                while (!int.TryParse(Studentlimit,out Studentlimit))
                {
                    Console.WriteLine(i + 1 + "Telebe limitini daxil edin");
                    Studentlimit = Console.ReadLine();
                }
            } 
        }
        static bool CheckNo(string No)
        {
            if (!string.IsNullOrEmpty(No)&& No.Length==3 && char.IsUpper(No[0]) && char.IsUpper(No[1]))
            {
                for (int i = 0; i < No.Length; i++)
                {
                    if (char.IsDigit(No[i]))
                    {
                        return false;

                    } 
                }
                return true;
            }
            return false;
        }
    }
}
