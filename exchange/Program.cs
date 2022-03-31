using System;

namespace exchange
{
    internal class Program
    {
      static void Main(string[] args)
        {
            int choice;
            double val, azn;
            Console.WriteLine("Enter your Choice :\n 1- Dollar to azn \n 2- Euro to azn \n 3- Tyl to azn ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Double dollar;
                    Console.Write("Enter the Dollar Amount :");
                    dollar = Double.Parse(Console.ReadLine());
                    Console.Write("Enter the Dollar Value :");
                    val = double.Parse(Console.ReadLine());
                    azn = dollar * val;
                    Console.WriteLine("{0} Dollar Equals {1} azn", dollar, azn);
                    break;
                case 2:
                    Double Euro;
                    Console.Write("Enter the Euro Amount :");
                    Euro = Double.Parse(Console.ReadLine());
                    Console.Write("Enter the Euro Value :");
                    val = double.Parse(Console.ReadLine());
                    azn = Euro * val;
                    Console.WriteLine("{0} Euro Equals {1} azn", Euro, azn);
                    break;
                case 3:
                    Double tyl;
                    Console.Write("Enter the tyl Amount :");
                    tyl = Double.Parse(Console.ReadLine());
                    Console.Write("Enter the tyl Value :");
                    val = double.Parse(Console.ReadLine());
                    azn = tyl * val;
                    Console.WriteLine("{0} Sterling Equals {1} azn", tyl, azn);
                    break;
            }


        }
    }
}
