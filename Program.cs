// See https://aka.ms/new-console-template for more information
using System;

class AreaShape;
{
    static void Main(string[] args)
    {
        int attempts = 0;
        const int maxAttempts = 3;
        bool validChoice = false;

        while (attempts < maxAttempts && !validChoice)
        {
            Console.WriteLine("Please select a shape to calculate the area:");
            Console.WriteLine("1. Triangle");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Circle");
            Console.Write("Enter your choice (1, 2, or 3): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": // Triangle
                    CalculateTriangleArea();
                    validChoice = true;
                    break;

                case "2": // Rectangle
                    CalculateRectangleArea();
                    validChoice = true;
                    break;

                case "3": // Circle
                    CalculateCircleArea();
                    validChoice = true;
                    break;

                default: // Invalid choice
                    attempts++;
                    Console.WriteLine($"Invalid choice. You have {maxAttempts - attempts} attempts left.");
                    if (attempts >= maxAttempts)
                    {
                        Console.WriteLine("You have exceeded the maximum number of attempts. Exiting the program.");
                    }
                    break;
            }
        }
    }

    static void CalculateTriangleArea()
    {
        Console.Write("Enter the base of the triangle: ");
        if (!double.TryParse(Console.ReadLine(), out double baseLength) || baseLength <= 0)
        {
            Console.WriteLine("Invalid input. Base must be a positive number.");
            return;
        }

        Console.Write("Enter the height of the triangle: ");
        if (!double.TryParse(Console.ReadLine(), out double height) || height <= 0)
        {
            Console.WriteLine("Invalid input. Height must be a positive number.");
            return;
        }

        double area = 0.5 * baseLength * height;
        Console.WriteLine($"The area of the triangle is: {area}");
    }

    static void CalculateRectangleArea()
    {
        Console.Write("Enter the length of the rectangle: ");
        if (!double.TryParse(Console.ReadLine(), out double length) || length <= 0)
        {
            Console.WriteLine("Invalid input. Length must be a positive number.");
            return;
        }

        Console.Write("Enter the width of the rectangle: ");
        if (!double.TryParse(Console.ReadLine(), out double width) || width <= 0)
        {
            Console.WriteLine("Invalid input. Width must be a positive number.");
            return;
        }

        double area = length * width;
        Console.WriteLine($"The area of the rectangle is: {area}");
    }

    static void CalculateCircleArea()
    {
        Console.Write("Enter the radius of the circle: ");
        if (!double.TryParse(Console.ReadLine(), out double radius) || radius <= 0)
        {
            Console.WriteLine("Invalid input. Radius must be a positive number.");
            return;
        }

        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine($"The area of the circle is: {area}");
    }
}
