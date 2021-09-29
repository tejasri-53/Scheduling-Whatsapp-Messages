using System;

namespace Bank_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ids = new int[100000];
            int[] amts = new int[100000];
            int i = 0;
            int c = 0;
            while (c == 0)
            {
                Console.WriteLine("Enter your Choice : \n 1. Create New Account \n 2. Perform Transactions on Existing Account \n 3.Bank Accounts Data");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x == 2)
                {
                    Transactions t = new Transactions();
                    t.Solve(ids, amts, i);
                    i += 1;
                }
                else if (x == 1)
                {
                    Console.WriteLine("Enter the Account Id:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Amount:");
                    int amt = Convert.ToInt32(Console.ReadLine());

                    amts[i] = amt;
                    ids[i] = id;
                    Console.WriteLine(id + " has  amount " + ids[0]);
                    i += 1;

                }
                else
                {
                    Console.WriteLine("Account id    Amount");
                    for (int j = 0; j < i; j++)
                    {
                        Console.WriteLine(ids[j] + "            " + amts[j]);
                    }
                }
                Console.WriteLine("Enter 1 if you wish to Continue else enter 2 ");
                int q = Convert.ToInt32(Console.ReadLine());
                if (q == 2) { c = 1; }
            }
        }
    }
}
