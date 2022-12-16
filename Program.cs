using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PROJECT 1

            Console.WriteLine("please enter first number : ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter second number : ");
           int n2 = int.Parse(Console.ReadLine());
           
            bool prime=true;
            Console.WriteLine("the prime number are : ");
            
            for(int x=n1;x<=n2;x++) 
            {
                for(int y=2;y<n2;y++)
                {
                    if(x!=y && x%y==0 )
                    {
                        prime= false;
                       break;
                    }
                    if (x == 1)
                        prime = false;
                    
                }
               if(prime)
                    Console.WriteLine(x);
               prime= true;
            }
             
        }
    }
}
