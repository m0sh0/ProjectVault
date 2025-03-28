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
                    List<int> billsToRemove = new();
                    bills.Add(20);

                    for (int i = 0; i < bills.Count; i++)
                    {
                        for (int j = 1; j < bills.Count; j++)
                        {
                            if (bills[i] + bills[j] == 15)
                            {
                                billsToRemove.Add(bills[i]);
                                billsToRemove.Add(bills[j]);

                                break;
                            }

                            for (int k = 3; k < bills.Count; k++)
                            {
                                if (bills[i] + bills[j] + bills[k] == 15)
                                {
                                    billsToRemove.Add(bills[i]);
                                    billsToRemove.Add(bills[j]);
                                    billsToRemove.Add(bills[k]);

                                    break;
                                }

                            }
                        }

                        break;
                    }

                    foreach (int bill in billsToRemove)
                    {
                        bills.Remove(bill);
                    }
                    break;
                }
            }
        }
    }
}
