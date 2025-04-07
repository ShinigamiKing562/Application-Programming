using System;

class SalesReport
{
    static void Main()
    {
        const int salesmenCount = 10;
        const int itemsCount = 5;
        
        string[] salesmen = new string[salesmenCount];
        int[,] sales = new int[salesmenCount, itemsCount];
        int[] totalSales = new int[salesmenCount];
        int grandTotal = 0;

        for (int i = 0; i < salesmenCount; i++)
        {
            Console.Write($"Enter salesman {i + 1} name: ");
            salesmen[i] = Console.ReadLine();

            for (int j = 0; j < itemsCount; j++)
            {
                Console.Write($"Enter sales for {salesmen[i]} (Item {j + 1}): ");
                sales[i, j] = int.Parse(Console.ReadLine());
                totalSales[i] += sales[i, j];
            }

            grandTotal += totalSales[i];
        }

        Console.WriteLine("\nSales Report:");
        Console.WriteLine("Name    Item1  Item2  Item3  Item4  Item5  TotalSales");
        Console.WriteLine("-----------------------------------------------------");

        for (int i = 0; i < salesmenCount; i++)
        {
            Console.Write($"{salesmen[i],-8}");
            for (int j = 0; j < itemsCount; j++)
            {
                Console.Write($"{sales[i, j],6}");
            }
            Console.WriteLine($"{totalSales[i],10}");
        }

        Console.WriteLine($"\nGrand Total: {grandTotal}");
    }
}