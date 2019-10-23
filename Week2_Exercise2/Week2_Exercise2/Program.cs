using System;

namespace Film
{
    class Program
    {
        static void Main(string[] args)
        {
            string Film = Console.ReadLine();
            string Type = Console.ReadLine();
            int TicketsCount = int.Parse(Console.ReadLine());

            if (Type == "Drink")
            {
                if (Film == "John Wick")
                {
                    int TicketPrice = 12;
                    int Cost = TicketPrice * TicketsCount;
                    Console.WriteLine("Your bill is {0:f2} leva.", Cost);
                }
                else if (Film == "Star Wars")
                {
                    int TicketPrice = 18;
                    int Cost = TicketPrice * TicketsCount;
                    if (TicketsCount >= 4)
                    {
                        double NewCost = Cost - (Cost * 0.3);
                        Console.WriteLine("Your bill is {0:f2} leva.", NewCost);
                    }
                    else
                    {
                        Console.WriteLine("Your bill is {0:f2} leva.", Cost);
                    }
                }
                else if (Film == "Jumanji")
                {
                    int TicketPrice = 9;
                    int Cost = TicketPrice * TicketsCount;
                    if (TicketsCount == 2)
                    {
                        double NewCost = Cost - (Cost * 0.15);
                        Console.WriteLine("Your bill is {0:f2} leva.", NewCost);
                    }
                    else
                    {
                        Console.WriteLine("Your bill is {0:f2} leva.", Cost);
                    }
                }
            }
            else if (Type == "Popcorn")
            {
                if (Film == "John Wick")
                {
                    int TicketPrice = 15;
                    int Cost = TicketPrice * TicketsCount;
                    Console.WriteLine("Your bill is {0:f2} leva.", Cost);
                }
                else if (Film == "Star Wars")
                {
                    int TicketPrice = 25;
                    int Cost = TicketPrice * TicketsCount;
                    if (TicketsCount >= 4)
                    {
                        double NewCost = Cost - (Cost * 0.3);
                        Console.WriteLine("Your bill is {0:f2} leva.", NewCost);
                    }
                    else
                    {
                        Console.WriteLine("Your bill is {0:f2} leva.", Cost);
                    }
                }
                else if (Film == "Jumanji")
                {
                    int TicketPrice = 11;
                    int Cost = TicketPrice * TicketsCount;
                    if (TicketsCount == 2)
                    {
                        double NewCost = Cost - (Cost * 0.15);
                        Console.WriteLine("Your bill is {0:f2} leva.", NewCost);
                    }
                    else
                    {
                        Console.WriteLine("Your bill is {0:f2} leva.", Cost);
                    }
                }
            }
            else if (Type == "Menu")
            {
                if (Film == "John Wick")
                {
                    int TicketPrice = 19;
                    int Cost = TicketPrice * TicketsCount;
                    Console.WriteLine("Your bill is {0:f2} leva.", Cost);
                }
                else if (Film == "Star Wars")
                {
                    int TicketPrice = 30;
                    int Cost = TicketPrice * TicketsCount;
                    if (TicketsCount >= 4)
                    {
                        double NewCost = Cost - (Cost * 0.3);
                        Console.WriteLine("Your bill is {0:f2} leva.", NewCost);
                    }
                    else
                    {
                        Console.WriteLine("Your bill is {0:f2} leva.", Cost);
                    }
                }
                else if (Film == "Jumanji")
                {
                    int TicketPrice = 14;
                    int Cost = TicketPrice * TicketsCount;
                    if (TicketsCount == 2)
                    {
                        double NewCost = Cost - (Cost * 0.15);
                        Console.WriteLine("Your bill is {0:f2} leva.", NewCost);
                    }
                    else
                    {
                        Console.WriteLine("Your bill is {0:f2} leva.", Cost);
                    }

                }
            }
        }
    }
}