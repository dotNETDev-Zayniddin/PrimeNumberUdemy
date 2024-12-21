using System;
using System.Data;
namespace Name
{
    public class Program
    {
        static void Main(string[] args)
        {
            int value1;
            int value2;
            int primeCount = 0;
            int tempCount = 0; // For not adding comma to last number 

            System.Console.Write("Enter the starting number: ");
            while (!int.TryParse(Console.ReadLine(), out value1))
            {
                Console.WriteLine("Wrong input!");
            }

            System.Console.Write("Enter the ending number: ");
            while (!int.TryParse(Console.ReadLine(), out value2))
            {
                Console.WriteLine("Wrong input!");
            }
             
             //iteration for counting prime number
              for (int i = value1; i <= value2; i++)
                 {
                    if(isPrime(i))
                    {
                        primeCount++;
                    }
                 }
             //

             if(primeCount == 0)
             {
                System.Console.WriteLine("No prime numbers found in the given range.");
             }
             else
             {
                 System.Console.Write("Prime numbers between 10 and 20 are: ");    
                 for (int i = value1; i <= value2; i++)
                 {
                    if(isPrime(i))
                    {
                        tempCount++; // counting for last if last do not print comma
                        if(primeCount == tempCount)
                        {
                            System.Console.Write(i);
                        }
                        else{
                            System.Console.Write(i + ", ");
                        }
                    }
                 }
             }
        }
      
      //Method for checking isPrime
        static bool isPrime(int value)
        {
            if(value <= 1)
            {
                return false;
            }
            else 
            {
                for(int i = 2; i <= Math.Sqrt(value); i++)
                {
                    if(value % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        
        }
    }
    
}
