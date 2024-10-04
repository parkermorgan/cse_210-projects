using System;

public class ShapeCalculator
{
    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\nPlease select a shape:\n1. Square\n2. Rectangle\n3. Circle\n4. Quit");
            string shape = Console.ReadLine();

            if (shape == "1")
            {
                CalculateSquareArea();
            }
            else if (shape == "2")
            {
                CalculateRectangleArea();
            }
            else if (shape == "3")
            {
                CalculateCircleArea();
            }
            else if (shape == "4")
            {
                Console.WriteLine("Thank you for playing.");
                break; // This ends the loop
            }
            else
            {
                Console.WriteLine("Invalid selection. Please choose a valid option.");
            }
        }
    }

    private void CalculateSquareArea()
    {
        Console.Write("What is the length of each side of the square? ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double length))
        {
            double area = length * length;
            Console.WriteLine($"The area of the square is {area}.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    private void CalculateRectangleArea()
    {
        Console.Write("What is the length? ");
        string lengthInput = Console.ReadLine();

        Console.Write("What is the width? ");
        string widthInput = Console.ReadLine();

        if (double.TryParse(lengthInput, out double length) && double.TryParse(widthInput, out double width))
        {
            double area = length * width;
            Console.WriteLine($"The area of the rectangle is {area}.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid numbers.");
        }
    }

    private void CalculateCircleArea()
    {
        Console.Write("What is the radius? ");
        string radiusInput = Console.ReadLine();

        if (double.TryParse(radiusInput, out double radius))
        {
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of the circle is {area:F2}.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
