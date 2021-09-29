using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Application
{
    public class BankAccount
    {
        
        public void AddMoney(int  amount, int id, int[] a,int[] b,int len) {

            int c = 0;
            for (int i = 0; i < len ; i++) {
                if (a[i] == id) {
                    b[i] += amount;
                    Console.WriteLine("Deposited " + amount + " to the bank account " + id);
                    c= 1;
                    break;
                }
            }
            this.getInfo(id,a,b,len);
            
        }

        public void SubtractMoney(int  Money, int id,int[] a, int[] b,int len) {
     
            for (int i = 0; i <len; i++)
            {
               
                if (a[i]== id)
                {
                    if (Money> b[i])
                    {
                        Console.WriteLine("Withdrawl Amount Exceeds Balance");
                        break;
                    }
                    else
                    {
                        b[i]=b[i]- Money;
                        Console.WriteLine("Withdrawn " + Money + " from the bank account " + id);
                        break;
                    }
                }
            }
        }

        public void getInfo(int id,int[] a,int[] b,int len) {
            for (int i = 0; i < len; i++)
            {
                if (a[i] == id)
                {
                    Console.WriteLine("Account "+id  + " has amount  " + b[i]);
                    break;
                }
            }
            
        }



    }
}
