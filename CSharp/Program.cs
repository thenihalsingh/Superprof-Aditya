using System.Numerics;
using System;

namespace Superprof_Aditya_New
{
    class Program
    {
        // single line comment
        /* Multi line Comment */
        static void Main(string[] args)
        {
            ArraysClass ac = new ArraysClass();
            ac.LearnArrays();

            // ConiditionalStatements cs = new ConiditionalStatements();
            // cs.IfElse();
            // cs.SwitchCases();
            // Loops lp = new Loops();
            // lp.WhileLoop();
            // lp.DoWhileLoop();
            // lp.ForLoop();

            //string abc ; //declaration of variable

            //string x = "Nihal"; //Declaration and Initialization

            //abc  = "Nihal"; //We initiated the variable

            //Type of Casting -- casting means converting one data type to another
            //1) Implicit Casting  2)Explicit Casting
            // double a = 666.25; // long stores larger values
            // int b = (int)a; // int stores smaller values as compared to long

            // int c = 666666666;
            // long d = c;
            // Console.WriteLine(b);
            // Console.WriteLine(d);

            // //User Input
            // Console.WriteLine("Enter your age");
            // int age = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Age is: ");
            // Console.WriteLine(age);


            /*
            Todays Topic: Operators
            1) Arithmetic Operators => +, -, *, /, % 
            */

            // int a = 16;
            // int b = 5;
            // int result = a + b;
            // Console.WriteLine("+ operator = {0}", result);
            // result = a * b;
            // Console.WriteLine("* operator = {0}", result);
            // result = a / b;
            // Console.WriteLine("/ operator = {0}", result);
            // result = a - b;
            // Console.WriteLine("- operator = {0}", result);
            // result = a % b;
            // Console.WriteLine("% operator = {0}", result);
            // result = a++; // a+1 //Post Increament

            // /*
            //  a got assigned to result
            //  then a got increamented by one
            // */

            // Console.WriteLine("++ operator = {0}", result);
            // Console.WriteLine("a operator = {0}", a);
            // result = a - 1; // a-1 //Post Decreament
            // Console.WriteLine("-- operator = {0}", result);
            // Console.WriteLine("a operator = {0}", a);
            // result = ++a; // a+1 //Pre Increament

            // /*
            //     a got increamented by one
            //     then got assigned to result
            // */

            // Console.WriteLine("++a operator = {0}", result);
            // Console.WriteLine("a operator = {0}", a);
            // result = --a; // a-1 //Pre Decreament
            // Console.WriteLine("--a operator = {0}", result);
            // Console.WriteLine("a operator = {0}", a);

            // Console.WriteLine("------------");

            // /*
            //     2) Assignment Operators
            // */

            // a += b; // a = a + b;
            // Console.WriteLine("+= => {0}", a);
            // a -= b; // a = a - b;
            // Console.WriteLine("+= => {0}", a);
            // a *= b; // a = a * b;
            // Console.WriteLine("+= => {0}", a);
            // a /= b; // a = a / b;
            // Console.WriteLine("+= => {0}", a);
            // a %= b; // a = a % b;
            // Console.WriteLine("+= => {0}", a);

            // Console.WriteLine("------------");
            
            // /*
            //     3) Comparison Operators
            // */

            // if(a == b){ //Equals To
            //     Console.WriteLine("true");
            // }
            // else {
            //     Console.WriteLine("false");
            // }

            // if(a != b){ //Not Equals To
            //     Console.WriteLine("true");
            // }
            // else {
            //     Console.WriteLine("false");
            // }

            // if(a > b){ //Greater Than
            //     Console.WriteLine("true");
            // }
            // else {
            //     Console.WriteLine("false");
            // }

            // if(a < b){ //Less Than
            //     Console.WriteLine("true");
            // }
            // else {
            //     Console.WriteLine("false");
            // }

            // if(a >= b){ //Greater Than Equal To
            //     Console.WriteLine("true");
            // }
            // else {
            //     Console.WriteLine("false");
            // }

            // if(a <= b){ //Less Than Equal To
            //     Console.WriteLine("true");
            // }
            // else {
            //     Console.WriteLine("false");
            // }

            // Console.WriteLine("------------");
            
            // /*
            //     3) Logical Operators
            // */

            // if(a == b && a == 5){ // AND Operator
            //     Console.WriteLine("true");
            // }
            // else {
            //     Console.WriteLine("false");
            // } 

            // if(a == b || a == 5){ // OR Operator
            //     Console.WriteLine("true");
            // }
            // else {
            //     Console.WriteLine("false");
            // }

            // Console.WriteLine("-----------");
            // /*
            //     3) Logical Operators
            // */            

            // result = 6 >> 1;

            // /*
            //     6 in binary => 1 1 0
            //     to shift each bit to the right by 1

            //     after shifting => 0 1 1 => and this is binary of 3
            // */
            // Console.WriteLine(">> => {0}", result);

            // result = 6 << 1;

            // /*
            //     6 in binary => 1 1 0
            //     to shift each bit to the left by 1

            //     after shifting =>1 1 0 0 => and this is binary of 12
            // */
            // Console.WriteLine("<< => {0}", result);
        }
    }
}
