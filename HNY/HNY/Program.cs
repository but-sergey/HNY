using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HNY
{
    class Program
    {
        static void Main(string[] args)
        {
            // ==================
            int Randomizer = 111;
            // ==================

            Random rnd = new Random(Randomizer);

            List<string> Deers = new List<string>();
            Deers.Add("Сергей");
            Deers.Add("Andrey Kadomsky");
            Deers.Add("Кирилл Князев");
            Deers.Add("Андрей WU");
            Deers.Add("Римма Квитко");
            Deers.Add("Рыжий лис");
            Deers.Add("Nick Iceman");
            Deers.Add("Olga Ivonina");
            Deers.Add("Zubov Evgenij");
            Deers.Add("Михаил Пислигин");
            Deers.Add("Андрей Пилипенко");

            int CurrentDeer = 0;
            int j = 0;
            int k = rnd.Next(100, 200);

            Console.CursorVisible = false;


            do
            {
                Console.SetCursorPosition(0, CurrentDeer);
                Console.Write($"{Deers[j]}              ");

                if (k > 50)
                    Thread.Sleep(10);
                else
                    Thread.Sleep(10 + 5 * (50 - k));

                k--;

                if (k == 0)
                {
                    Deers.Remove(Deers[j]);
                    k = rnd.Next(100, 200);
                    CurrentDeer++;
                }

                j++;
                if (j >= Deers.Count) j = 0;

            } while (Deers.Count > 0);

            Console.ReadLine();
        }
    }
}