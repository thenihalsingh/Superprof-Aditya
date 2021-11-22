using System;

namespace Superprof_Aditya_New
{
    public class ConiditionalStatements
    {
        public void IfElse(){
            int a = 5, b = 6;

            // If - Else If - Else 

            if(a == b){
                Console.WriteLine("reached IF block");
            }
            else if(a != b){
                Console.WriteLine("reached ELSE IF block");
            }
            else{
                Console.WriteLine("reached ELSE block");
            }
            
        }

        public void SwitchCases(){
            //break;
            //continue;

            int day = 3;
            switch(day){
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break; 
                case 3:
                    Console.WriteLine("Wednesday");
                    break; 
                case 4:
                    Console.WriteLine("Thursday");
                    break; 
                case 5:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("Number is not a weekday");
                    break;    
            }
        }
    }
}