using System;

namespace Superprof_Aditya_New
{
    public class Loops
    {
        public void WhileLoop()
        {
            //task is to print 1 to n numbers
            int n = 10, a = 1;
            while (a <= n)
            {
                Console.WriteLine(a);
                a++;
            }
        }

        public void DoWhileLoop(){
            int a = 9, n = 10;
            do{
                Console.WriteLine(a);
                a++;
            }
            while(a != n);
        }
    
        public void ForLoop(){
            int n = 10;
            for(int a = 1; a <= n; a++){
                Console.WriteLine(a);
            }
        }
    
        // foreach{

        // }
    }
}