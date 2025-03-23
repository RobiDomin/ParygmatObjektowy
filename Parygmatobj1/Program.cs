using System;

namespace Paradygmatobj1
{
    class Program
    {
        static void Main()
        {
            Trapez trapezoid = new Trapez();
            trapezoid.ReadData();
            trapezoid.ProcessData();
            trapezoid.ShowResults();
        }
    }
}
