using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
/*
5
5
5
20

5
5
5
10
20
 */
namespace lemonadeStand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> bills = new();

            while (true)
            {
                int order = int.Parse(Console.ReadLine());

                if (order == 5)
                {
                    bills.Add(5);
                }

                else if (order == 10)
                {
                    bills.Add(10);

                    for (int i = 0; i < bills.Count; i++)
                    {
                        if (bills[i] == 5)
                        {
                            bills.RemoveAt(i);
                            break;
                        }
                    }
                }

                else if (order == 20)
                {
                    bills.Add(20);

                    foreach (int bill1 in bills)
                    {
                        foreach (int bill2 in bills)
                        {
                            if (bill1 + bill2 == 15)
                            {
                                bills.Remove(bill1);
                                bills.Remove(bill2);
                                break; 
                            }

                            foreach (int bill3 in bills)
                            {
                                if (bill1 + bill2 + bill3 == 15)
                                {
                                    bills.Remove(bill1);
                                    bills.Remove(bill2);
                                    bills.Remove(bill3);
                                    break;
                                }
                            }
                        }
                    } 
                    break;
                }
            }
        }
    }
}
