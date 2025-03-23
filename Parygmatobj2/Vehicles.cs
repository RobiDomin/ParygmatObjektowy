using System;

namespace Parygmatobj2
{

    class Vehicles
    {
        protected string name, manufacturer;
        protected int id, mileage, years;

        public void Read()
        {
            Console.Write("Podaj nazwę pojazdu: ");
            name = Console.ReadLine();
            Console.Write("Podaj producenta: ");
            manufacturer = Console.ReadLine();
            Console.Write("Podaj ID pojazdu: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj przebieg pojazdu: ");
            mileage = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj wiek pojazdu: ");
            years = Convert.ToInt32(Console.ReadLine());
        }

        public void Show()
        {
            Console.WriteLine($"Nazwa: {name}");
            Console.WriteLine($"Producent: {manufacturer}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Przebieg: {mileage} km");
            Console.WriteLine($"Wiek: {years} lat");
        }
    }

}
