using System;

public class TriangleProgram
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());


        for (int i = n; i >= 1; i--)
        {
            for (int j = n; j > i ; j--)
            {
                Console.Write("*");
            }
            for (int z = 0; z >= (i*2); z++)
            {
                Console.Write(" ");
            }
            Console.Write("\n");
        }




    }




}