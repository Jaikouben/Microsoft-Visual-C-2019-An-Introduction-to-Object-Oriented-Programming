/*
Write an application named MultiplicationTable that prompts the user for an integer value, for example 7. Then display the product of every integer from 1 through 10 when multiplied by the entered value. For example, the first three lines of the table might read 1 x 7 = 7, 2 x 7 = 14, and 3 x 7 = 21.
*/

using System;
using static System.Console;
class MultiplicationTable
{
   static void Main()
   {
       // Prompts user to enter a value
       WriteLine("Enter an integer >>");
       int value = int.Parse(ReadLine());

       // Loop for displaying the multiplication table
       for(int k = 1; k <= 10; k++)
       {
         WriteLine("{0} x {1} = {2}", k, value, k * value);
       }
   }
}
