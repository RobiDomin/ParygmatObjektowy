using System;

namespace Parygmatobj2
{
    class Cars : Vehicles
    {
        private string engine, color;

        public void Read1()
        {
            Read();
            Console.Write("Podaj typ silnika: ");
            engine = Console.ReadLine();
            Console.Write("Podaj kolor samochodu: ");
            color = Console.ReadLine();
        }

        public void Show1()
        {
            Show();
            Console.WriteLine($"Silnik: {engine}");
            Console.WriteLine($"Kolor: {color}");
        }
    }
}
