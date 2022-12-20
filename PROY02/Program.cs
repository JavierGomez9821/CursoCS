using System.Drawing;
using Geometry;
internal class Program
{
    private static void Main(string[] args)
    {
        Square Cuadrado = new Square();
        Cuadrado.Lado = 10;
        Cuadrado.Name = "Primer Cuadrado";
        Cuadrado.LineColor = "#008080";
        // Console.WriteLine($"Nombre     :\t{Cuadrado.Name}");
        // Console.WriteLine($"ID         :\t{Cuadrado.Id}");
        // Console.WriteLine($"Lado       :\t{Cuadrado.Lado}");
        // Console.WriteLine($"Area       :\t{Cuadrado.getSize()}");
        // Console.WriteLine($"Perimetro  :\t{Cuadrado.getPerimeter()}");
        // Console.WriteLine("------------------------------");
        Triangle Triangulo = new Triangle();
        Triangulo.Lado1 = 4;
        Triangulo.Lado2 = 5;
        Triangulo.Lado3 = 8;
        Triangulo.Name = "Primer Triangulo";
        Triangulo.LineColor = "#008080";
        Triangulo.getPerimeter();
        // Console.WriteLine($"Nombre     :\t{Triangulo.Name}");
        // Console.WriteLine($"ID         :\t{Triangulo.Id}");
        // Console.WriteLine($"Lado 1     :\t{Triangulo.Lado1}");
        // Console.WriteLine($"Lado 2     :\t{Triangulo.Lado2}");
        // Console.WriteLine($"Lado 3     :\t{Triangulo.Lado3}");
        // Console.WriteLine($"Area       :\t{Triangulo.getSize()}");
        // Console.WriteLine($"Perimetro  :\t{Triangulo.getPerimeter()}");
        Circle Circulo = new Circle();
        Circulo.Radio = 5;
        Circulo.Name = "Primer Circulo";
        Circulo.LineColor = "#008080";
        // Console.WriteLine($"ID         :\t{Circulo.Id}");
        // Console.WriteLine($"Lado 1     :\t{Circulo.Radio}");
        // Console.WriteLine($"Area       :\t{Circulo.getSize()}");
        // Console.WriteLine($"Perimetro  :\t{Circulo.getPerimeter()}");
        // Console.WriteLine($"Nombre     :\t{Circulo.Name}");

        List<Figure> myList = new List<Figure>();
        myList.Add(Cuadrado);
        myList.Add(Triangulo);
        myList.Add(Circulo);

        foreach (var item in myList)
        {
            Console.WriteLine($"Nombre\t:\t{item.Name}");
            Console.WriteLine($"Tamaño\t:\t{item.getSize()}");
            Console.WriteLine($" ");
        } 
    }
}
