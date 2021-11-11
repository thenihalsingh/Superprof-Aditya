using System;

namespace Superprof_Aditya_New
{

    public class ArraysClass
    {
        public void LearnArrays(){

            //Q: What is Arrays?
            //A: Arrays are the COLLECTION of elements of SIMILAR data types

            //Q: Declare an Array?
            int[] arr;

            //Q: Initialize an Array?
            //A: Types:-
            //arr = new int[]{1,2,3,4};
            arr = new int[1000];

            //Q: Intialize Array Using Loops
            //A: 
             int j = 0;
            // while(i < arr.Length){
            //     arr[i] = i*i*i;
            //     i++;
            // }
            // i = 0;
            for(int i = 0; i < arr.Length; i++){
                arr[i] = i*i;
            }

            //Q: Get an element from specific poistion (position = 1) in array
            int element = arr[1];
            Console.WriteLine("Element at index 1 = {0}", element);

            //Q: Get an element from an array 1st element
            int fourthElement = arr[0];
            Console.WriteLine("Element at 1st position = {0}", fourthElement);

            //Q: Get all elements of an Array
            //A: loops
            // while(j < arr.Length){
            //     Console.Write("{0} ", arr[j]);
            //     j++;
            // }
            // Console.WriteLine(" ");
            // for(int i = 0; i < arr.Length; i++){
            //     Console.Write("{0} ", arr[i]);
            // }
            Console.WriteLine(" ");
            foreach(int k in arr){
                Console.Write("{0} ", k);
            }

            //Q: Replace element 144 with 40 in array

            for(int i = 0; i < arr.Length; i++){
                if(arr[i] == 144){
                    arr[i] = 40;
                }
            }
            Console.WriteLine(" ");
            foreach(int k in arr){
                Console.Write("{0} ", k);
            }
        }   
    }

}