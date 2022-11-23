// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Hello Mono World\n");
        
        bool state = false;
        int first_index = -1;
        int last_index = -1;
        int global_index = 0;
        int global_index_list = 0;
        char[] liste = new char[]{'T','F','F','F','T','F','T','F','T','T','T','F','F','F'};
        
        int[,] dizi = new int[liste.Length,2];

        int i=0;
        while(i < liste.Length -1){
            
            if(liste[i]=='T' && !state){
                first_index = i;
                state = true;
            }
            if(liste[i]=='T'){
                last_index = i;

            }

            if(liste[i] != liste[i+1] && state){
                dizi[global_index, 0] = first_index;
                dizi[global_index, 1] = last_index;
                global_index +=1;
                state = false;
                first_index = last_index = -1;
            }
            i++;
        }
        
        i=0;
        while(i < global_index){
            if(dizi[i,0] != -1 )
            Console.WriteLine(dizi[i,0] + " -- " + dizi[i,1] + "\n");
            i++;
        }

        }
}
