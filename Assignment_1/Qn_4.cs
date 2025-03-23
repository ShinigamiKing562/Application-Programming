using System;

class Shape
{
    static void Main(string[] args)
    {
        int attempts = 0;
        const int maxAttempts = 3;
        bool validChoice = false;

        while (attempts < maxAttempts && !validChoice)
        {
            Console.Write("Please select a shape to calculate the area:");
            Console.Write("1. Triangle");
            Console.Write("2. Rectangle");
            Console.Write("3. Circle");
            Console.Write("Enter your choice (1, 2, or 3): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": // Triangle
                    Console.Write("Enter the base of the triangle: ");
                    double baseLength = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the height of the triangle: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    double triangleArea = 0.5 * baseLength * height;
                    Console.WriteLine($"The area of the triangle is: {triangleArea}");
                    validChoice = true;
                    break;

                case "2": // Rectangle
                    Console.Write("Enter the length of the rectangle: ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the width of the rectangle: ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    double rectangleArea = length * width;
                    Console.Write($"The area of the rectangle is: {rectangleArea}");
                    validChoice = true;
                    break;

                case "3": // Circle
                    Console.Write("Enter the radius of the circle: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    double circleArea = Math.PI * Math.Pow(radius, 2);
                    Console.Write($"The area of the circle is: {circleArea}");
                    validChoice = true;
                    break;

                default: // Invalid choice
                    attempts++;
                    Console.Write($"Invalid choice. You have {maxAttempts - attempts} attempts left.");
                    if (attempts >= maxAttempts)
                    {
                        Console.Write("You have exceeded the maximum number of attempts. Exiting the program.");
                    }
                    break;
            }
        }
    }
}