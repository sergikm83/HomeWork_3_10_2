using System;

namespace HomeWork_3_10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько карт у Вас на руках? ");
            int count = int.Parse(Console.ReadLine());
            int result=0;
            for (int i=1;i<=count;i++)
            {
                Console.Write($"Укажите номинал {i}-ой карты: ");
                switch(Console.ReadLine() )
                {
                    case "J" or "j" or "Q" or "q" or "K" or "k" or "T" or "t" or "10":
                        result += 10;
                        break;
                    case "3":
                        result += 3;
                        break;
                    case "4":
                        result += 4;
                        break;
                    case "5":
                        result += 5;
                        break;
                    case "6":
                        result += 6;
                        break;
                    case "7":
                        result += 7;
                        break;
                    case "8":
                        result += 8;
                        break;
                    case "9":
                        result += 9;
                        break;
                    default:
                        break;
                };
            }
            Console.WriteLine($"Сумма карт равна {result}");
        }
    }
}
