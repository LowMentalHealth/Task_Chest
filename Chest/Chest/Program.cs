using System;

namespace Chest
{
    internal class Program
    {
         enum posStates
        {
            заблокирован,
            закрыт,
            открыт
        }

        static void Main(string[] args)
        {
            posStates state = posStates.заблокирован;

            string action;

            while (true)
            {
                Console.WriteLine($"Сейчас сундук {state}");
                Console.WriteLine("Что делать?");
                Console.WriteLine("Чтобы разблокировать нажми 1");
                Console.WriteLine("Чтобы открыть нажми 2");
                Console.WriteLine("Чтобы закрыть нажми 3");
                Console.WriteLine("Чтобы заблокировать нажми 4");

                action = Console.ReadLine().ToLower().Replace(" ", "");
                Console.WriteLine();

                switch (action)
                {
                    case "1":
                        разблокирован(ref state);
                        break;
                    case "2":
                        открыт(ref state);
                        break;
                    case "3":
                        закрыт(ref state);
                        break;
                    case "4":
                        заблокирован(ref state);
                        break;
                    default:
                        Console.WriteLine("ну ты сержант печальный");
                        break;
                }
            }
        }

        static void заблокирован(ref posStates state)
        {
            if(state == posStates.закрыт)
            {
                state = posStates.заблокирован;
            }else { Console.WriteLine("И как ты это себе представляешь?"); }
        }

        static void разблокирован(ref posStates state)
        {
            if(state == posStates.заблокирован)
            {
                state = posStates.закрыт;
            }else { Console.WriteLine("И как ты это себе представляешь?"); }
        }

        static void закрыт(ref posStates state)
        {
            if(state == posStates.открыт)
            {
                state = posStates.закрыт;
            } else { Console.WriteLine("И как ты это себе представляешь?"); }
        }

        static void открыт(ref posStates state)
        {
            if(state == posStates.закрыт)
            {
                state = posStates.открыт;
            } else { Console.WriteLine("И как ты это себе представляешь?"); }
        }
    }
}

