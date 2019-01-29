using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace errorsAndExceptions
{
    class quadraticEquation
    {
        public void QuadraticEquation()
        {
            double W = 0;
            try
            {
                Console.WriteLine("Now lets solve the quadratic equation for integers greater then or equal to 0!!!");
                int a, b, c;
                double x1, x2;
                Console.Write("Enter side a:");
                a = checked (Convert.ToInt32(Console.ReadLine()));
                Console.Write("Enter side b:");
                b = checked (Convert.ToInt32(Console.ReadLine()));
                Console.Write("Enter side c:");
                c = checked (Convert.ToInt32(Console.ReadLine()));
                W = (b * b) - (4 * a * c);
                x1 = PosEquation(b, W, a);
                x2 = NegEquation(b, W, a);
                Console.WriteLine("x1 is: {0}", x1);
                Console.WriteLine("x2 is: {0}", x2);
            }
            catch(FormatException Error)
            {
                Console.WriteLine(Error.Message.ToString());
                QuadraticEquation();
            }
            catch (OverflowException Error)
            {
                Console.WriteLine(Error.Message.ToString());
                QuadraticEquation();
            }
            catch (Exception) when (W <= 0)
            {
                Console.WriteLine("Sorry unable to work with imaginary numbers");
                Console.WriteLine("Please try again");
                QuadraticEquation();
            }
            finally
            {
                Console.WriteLine("This program has finally terminated!!!!!!!!!");
            }

        }
        public static double PosEquation( int b, double W, int a)
        {
            return (-b + Math.Sqrt(W)) / (2 * a);
        }
        public static double NegEquation(int b, double W, int a)
        {
            return (-b - Math.Sqrt(W)) / (2 * a);
        }
    }
}
