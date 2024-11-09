using Abstraction;

Shape circle = new Circle(5);
Shape rectangle = new Rectangle(4, 6);
Console.WriteLine($"Площадь круга: {circle.GetArea()}");
Console.WriteLine($"Площадь прямоугольника: {rectangle.GetArea()}");