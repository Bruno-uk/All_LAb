using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*LAB1
Написати програму, що виконує наступні функції 
 1.	Виводить на екран введене число з клавіатури в зворотному порядку(1234->4321)
 2.	Виводить будь-яку строку в зворотному порядку(АБВ->ВБА)
 3.	Дробові числа виводяться в зворотному порядку і ціла частина і дробова(123.456->321.654)
 4.	Реалізувати метод, що буде масив повертати задом навпаки(Використання Array.Reverse() заборонено!)
 5.	Виконати пункт 4 з використанням ключових слів ref i out
*/

//zav 3 
/*
using System;
namespace Lab_1_zav1to4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            Console.WriteLine("Enter digit");
            text = Console.ReadLine();
            string[] words = text.Split(new char[] { '.' });
            int a;
            int b;


            a = Convert.ToInt32(words[0]);
            b = Convert.ToInt32(words[1]);

            int reverseda = 0;
            int reversedb = 0;

            while (a > 0)
            {
                reverseda = reverseda * 10 + a % 10;
                a /= 10;
            }

            while (b > 0)
            {
                reversedb = reversedb * 10 + b % 10;
                b /= 10;
            }
            Console.WriteLine("Your reversed digit: " + reverseda + "." + reversedb);
        }
    }
}
*/

// zav 2 
/*
namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str,reverse="";
            int Length;
            Console.WriteLine("Enter a Word");  
            str = Console.ReadLine();
            Length = str.Length - 1;
            while (Length >= 0)
            {
                reverse = reverse + str[Length];
                Length--;
            }  
            Console.WriteLine("Reverse word is {0}", reverse);
            Console.ReadLine();
        }
    }
}*/

// zav 1
/*
  public class ReverseExample
{
    public static void Main(string[] args)
    {
        int n, reverse = 0, rem;
        Console.Write("Enter a number: ");
        n = int.Parse(Console.ReadLine());
        while (n != 0)
        {
            rem = n % 10;
            reverse = reverse * 10 + rem;
            n /= 10;
        }
        Console.Write("Reversed Number: " + reverse);
        Console.ReadLine();
    }
}*/


//zav 4 
/*
class program
{
     
    static void rvereseArray(int[] arr, int start,int end)
    {
        int temp;
        if (start >= end)
            return;

        temp = arr[start];
        arr[start] = arr[end];
        arr[end] = temp;

        rvereseArray(arr, start + 1, end - 1);
    }

    static void printArray(int[] arr, int elementCounts)
    {
        for (int i = 0; i < elementCounts; i++)
            Console.Write(arr[i] + " ");

        Console.WriteLine("");
    }

    
    public static void Main()
    {
        Console.WriteLine("How many elements in arr:\t");
        int elementCounts = int.Parse(Console.ReadLine());

        int[] arr = new int[elementCounts];
        for(int i = 0; i < arr.Length; i++) 
        {
            Console.Write($"\nWrite element of arr {i}: \t");
            arr[i] = int.Parse(Console.ReadLine());

        }

        printArray(arr, elementCounts);
        rvereseArray(arr, 0, elementCounts-1);

        Console.WriteLine("Reversed array is ");
        printArray(arr, elementCounts);
    }
}   */

