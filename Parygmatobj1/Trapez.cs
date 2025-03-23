using System;
namespace Paradygmatobj1
{

    public class Trapez
    {
        private double a, b, h, surfaceArea;

        public void ReadData()
        {
            Console.Write("Podaj długość podstawy a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj długość podstawy b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj wysokość h: ");
            h = Convert.ToDouble(Console.ReadLine());
        }

        public void ProcessData()
        {
            surfaceArea = ((a + b) * h) / 2;
        }

        public void ShowResults()
        {
            Console.WriteLine($"Podstawa a: {a:F1}");
            Console.WriteLine($"Podstawa b: {b:F1}");
            Console.WriteLine($"Wysokość h: {h:F1}");
            Console.WriteLine($"Pole trapezu: {surfaceArea:F1}");
        }
    }
}