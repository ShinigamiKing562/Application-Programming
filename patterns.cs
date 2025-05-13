class Pattern
{
    static void Main()
    {
        int rows = 6;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                if (i == 0 || i == rows - 1)
                {
                    Console.Write("& ");
                }
                else if (j == i-1)
                {
                    Console.Write("& ");
                }
                else
                {
                    Console.Write("* ");
                }
            }
            Console.WriteLine(); // New line after each row
        }
    }
}
