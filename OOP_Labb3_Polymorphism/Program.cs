namespace OOP_Labb3_Polymorphism
{
    internal class Program
    {
        static List<Geometry> shapes = new List<Geometry>(); // Store all objects for future sorting/presentation

        static void Main(string[] args)
        {
            // These ints are used to create ID numbers for the objects created later on
            int circleCount = 0;
            int triangleCount = 0;
            int squareCount = 0;
            int rectangleCount = 0;

            ShowMenu();

            void ShowMenu()
            {
                Console.WriteLine("Welcome to the Shape-Creator\nWhat shape would you like to create?");

                while (true)
                {
                    Console.WriteLine("\n1. Circle\n2. Triangle\n3. Square\n4. Rectangle\n5. A presentation of all shape areas in size order\n6. A presentation of all shape perimeters in size order\n7. Exit program");

                    string input = Console.ReadLine();
                    if (Int32.TryParse(input, out int choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                CreateCircle();
                                break;
                            case 2:
                                CreateTriangle();
                                break;
                            case 3:
                                CreateSquare();
                                break;
                            case 4:
                                CreateRectangle();
                                break;
                            case 5:
                                SortAndDisplayArea();
                                break;
                            case 6:
                                SortAndDisplayPerimeter();
                                break;
                            case 7:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Choose a valid option.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Choose a valid option.");
                    }
                }
            }

            void CreateCircle()
            {
                Console.WriteLine("Enter radius: ");
                while (true) // Loop to secure correct input
                {
                    string input = Console.ReadLine();
                    if (double.TryParse(input, out double radius))
                    {
                        if (radius < 0)
                        {
                            Console.WriteLine("Please enter a valid number.");
                        }
                        else
                        {
                            circleCount++; // To identify the different circles
                            Console.Clear();
                            Console.WriteLine($"Circle nr. {circleCount} created with radius: {radius} cm");
                            // Create new instance of circle in geometry class 'polymorphism'
                            Geometry circle = new Circle(circleCount, radius);
                            shapes.Add(circle); // Add the circle object to the geometry list 'polymorphism'
                            break; // Exit the loop after a valid radius is entered
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }
            }

            void CreateTriangle()
            {
                Console.WriteLine("Enter base: ");
                double _base = 0;
                while (true)
                {
                    string input = Console.ReadLine();
                    if (double.TryParse(input, out _base))
                    {
                        if (_base < 0)
                        {
                            Console.WriteLine("Please enter a valid number.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }
                Console.WriteLine("Enter height: ");
                while (true)
                {
                    string input = Console.ReadLine();
                    if (double.TryParse(input, out double height))
                    {
                        if (height < 0)
                        {
                            Console.WriteLine("Please enter a number greater than or equal to 0.");
                        }
                        else
                        {
                            triangleCount++;
                            Console.Clear();
                            Console.WriteLine($"Triangle nr. {triangleCount} created with base: {_base} cm and height: {height} cm");
                            Geometry triangle = new Triangle(triangleCount, _base, height);
                            shapes.Add(triangle);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }
            }

            void CreateSquare()
            {
                Console.WriteLine("Enter side: ");
                while (true)
                {
                    string input = Console.ReadLine();
                    if (double.TryParse(input, out double side))
                    {
                        if (side < 0)
                        {
                            Console.WriteLine("Please enter a valid number.");
                        }
                        else
                        {
                            squareCount++;
                            Console.Clear();
                            Console.WriteLine($"Square nr. {squareCount} created with sides: {side} cm");
                            Geometry square = new Square(squareCount, side);
                            shapes.Add(square);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }
            }

            void CreateRectangle()
            {
                Console.WriteLine("Enter base: ");
                double _base = 0;
                while (true)
                {
                    string input = Console.ReadLine();
                    if (double.TryParse(input, out _base))
                    {
                        if (_base < 0)
                        {
                            Console.WriteLine("Please enter a valid number.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }
                Console.WriteLine("Enter height: ");
                while (true)
                {
                    string input = Console.ReadLine();
                    if (double.TryParse(input, out double height))
                    {
                        if (height < 0)
                        {
                            Console.WriteLine("Please enter a number greater than or equal to 0.");
                        }
                        else
                        {
                            rectangleCount++;
                            Console.Clear();
                            Console.WriteLine($"Rectangle nr. {rectangleCount} created with base: {_base} cm and height: {height} cm\n");
                            Geometry rectangle = new Triangle(rectangleCount, _base, height);
                            shapes.Add(rectangle);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }
            }

            void SortAndDisplayArea()
            {
                List<Geometry> sortedByArea = shapes.OrderBy(shape => shape.Area()).ToList();
                Console.Clear();
                Console.WriteLine("Shapes sorted by area:");
                foreach (Geometry shape in sortedByArea)
                {
                    // Running one single method on all objects, because they have "Geometry Class" in common.
                    Console.WriteLine($"{shape.Present()} has an area of {shape.Area():F2} cm²");
                }
            }

            void SortAndDisplayPerimeter()
            {
                List<Geometry> sortedByPerimeter = shapes.OrderBy(shape => shape.Perimeter()).ToList();
                Console.Clear();
                Console.WriteLine("Shapes sorted by perimeter:");
                foreach (Geometry shape in sortedByPerimeter)
                {
                    // Running one single method on all objects, because they have "Geometry Class" in common.
                    Console.WriteLine($"{shape.Present()} has a perimeter of {shape.Perimeter():F2} cm");
                }
            }

        }
    }
}

