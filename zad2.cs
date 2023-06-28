using System;
namespace cwicz_7
{
	public class zad2
	{
		public zad2()
		{
            double x1 = 1.5;
            double y1 = 2.5;
            double x2 = 4.2;
            double y2 = 7.8;

            double dlugosc = ObliczDlugoscOdcinka(x1, y1, x2, y2);
            Console.WriteLine("Długość odcinka: " + dlugosc);

            Console.ReadLine();

        }

        static double ObliczDlugoscOdcinka(double x1, double y1, double x2, double y2)
        {
            double deltaX = x2 - x1;
            double deltaY = y2 - y1;

            double dlugosc = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return dlugosc;
        }
    }
}

