
class URI
{

    static void Main(string[] args)
    {

        double A = Convert.ToDouble(Console.ReadLine());
        double B = Convert.ToDouble(Console.ReadLine());
        double C = Convert.ToDouble(Console.ReadLine());
        const double pi = 3.141;

        double areaTriangulo = A * C;
        double areaCirculo = (C * C) * pi;
        double areaTrapezio = ((A + B) * C) / 2;
        double areaQuadrado = B * B;
        double areaRetangulo = A * B;

        Console.WriteLine("TRIANGULO: " + areaTriangulo);
        Console.WriteLine("CIRCULO: " + areaCirculo);
        Console.WriteLine("TRAPEZIO: " + areaTrapezio);
        Console.WriteLine("QUADRADO: " + areaQuadrado);
        Console.WriteLine("RETANGULO: " + areaRetangulo);
    }

}
