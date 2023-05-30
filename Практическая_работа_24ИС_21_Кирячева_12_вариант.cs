using System;
class HelloWorld {
    static void Main()
    {
    
        int[,] a = { { 0, 1, 2, 3, 4}, { 0, 1, 2, 3, 4}, { 0, 1, 2, 3, 4 }, { 0, 1, 2, 3, 4 }, { 0, 1, 2, 3, 4 }};
        int tmp;
        
        Console.WriteLine("Изначальный массив: ");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }
        
        Console.WriteLine();
        Console.WriteLine();
        
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < i; j++)
            {
                tmp = a[i, j];
                a[i, j] = a[j, i];
                a[j, i] = tmp;
            }
        }

        Console.WriteLine("Транспонированный массив: ");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}