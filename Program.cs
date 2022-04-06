using System;

namespace Formulae
{
    class Program
    {
        double fOne(int d, int t)
        {
            double speed = d / t;
            return speed;
        }

        double fTwo(int b, int h)
        {
            double area = (b*h)/2;
            return area;
        }

        double fThree(double p, int r)
        {
            double volume = (4 * p * r) / 3;
            return volume;
        }

        double fFour(int b1, int b2, int ht)
        {
            double trapzoid = (b1 + b2)/2 * ht;
            return trapzoid;
        }

        double fFive(double p, int rc, int hc)
        {
            double cylinder = 2 * p * rc * (rc + hc);
            return cylinder;
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            const double p = 3.14;
            string restart;

            do
            {
                Console.WriteLine("Do you want to proceed for calculations? (YES/NO): ");
                restart = Console.ReadLine();
                Console.WriteLine("Enter any number between 1 to 5: ");
                int x = Convert.ToInt32(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        Console.WriteLine("Enter distance in km:");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter time in hour:");
                        int t = Convert.ToInt32(Console.ReadLine());
                        double speed = a.fOne(d, t);
                        Console.WriteLine("Speed: " + speed + " km/hr");
                        break;

                    case 2:
                        Console.WriteLine("Enter base(width) of Triangle:");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter height of Triangle:");
                        int h = Convert.ToInt32(Console.ReadLine());
                        double area = a.fTwo(b, h);
                        Console.WriteLine("Area of Triangle: " + area);
                        break;

                    case 3:
                        Console.WriteLine("Enter radius of Sphere:");
                        int r = Convert.ToInt32(Console.ReadLine());
                        double volume = a.fThree(p, r);
                        Console.WriteLine("Volume of Sphere: " + volume);
                        break;

                    case 4:
                        Console.WriteLine("Enter base1 of Trapezoid:");
                        int b1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter base2 of Trapezoid:");
                        int b2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter height of Trapezoid:");
                        int ht = Convert.ToInt32(Console.ReadLine());
                        double trapezoid = a.fFour(b1, b2, ht);
                        Console.WriteLine("Area of Trapezoid: " + trapezoid);
                        break;

                    case 5:
                        Console.WriteLine("Enter radius of Cylinder:");
                        int rc = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enetr height of Cylinder:");
                        int hc = Convert.ToInt32(Console.ReadLine());
                        double cylinder = a.fFive(p, rc, hc);
                        Console.WriteLine("Area of Cylinder: " + cylinder);
                        break;

                    default:
                        Console.WriteLine("You must enter number between 1 to 5 ONLY!");
                        break;

                }
            } while (restart == "YES");
            Console.ReadLine();
        }
    }
}
