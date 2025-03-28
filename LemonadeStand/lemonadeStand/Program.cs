using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace lemonadeStand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my lemonade stand! Please insert 5$, 10$, or 20$ bills.");
            List<int> bills = new();

            while (true)
            {
                // Get user order
                Console.Write("=> ");
                int order;
                if (!int.TryParse(Console.ReadLine(), out order))
                {
                    break;
                }

                // Check if order is valid
                if (order != 5 && order != 10 && order != 20)
                {
                    Console.WriteLine("Please insert 5$, 10$, or 20$ bills.");
                    continue;
                }

                // Check if we have enough change
                if (!CanProvideChange(order, bills))
                {
                    Console.WriteLine("Sorry we don't have enough change :(");
                    break;
                }

                UpdateBills(order, bills);

            }
        }

        // Method for checking if we have enough change
        static bool CanProvideChange(int payment, List<int> bills)
        {
            if (payment == 5)
            {
                return true;
            }

            else if (payment == 10)
            {
                return bills.Contains(5);
            }

            else if (payment == 20)
            {
                if (bills.Contains(5) && bills.Contains(10))
                {
                    return true;
                }
                else if (bills.Count(b => b == 5) >= 3)
                {
                    return true;
                }
            }

            return false;
        }

        // Method for updating the bills list
        static void UpdateBills(int payment, List<int> bills)
        {
            if (payment == 5)
            {
                bills.Add(5);
            }

            else if (payment == 10)
            {
                bills.Add(10);
                bills.Remove(5);
            }

            else if (payment == 20)
            {
                bills.Add(20);
                if (bills.Contains(10) && bills.Contains(5))
                {
                    bills.Remove(10);
                    bills.Remove(5);
                }
                else if (bills.Count(b => b == 5) >= 3)
                {
                    bills.Remove(5);
                    bills.Remove(5);
                    bills.Remove(5);
                }
            }
        }
    }
}
