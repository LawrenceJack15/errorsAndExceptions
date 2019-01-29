using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace errorsAndExceptions
{
    class areaOfTriangle
    {
        public void AreaOfTriangle()
        {
            int sidea = 0, sideb = 0, sidec = 0;
            try
            {
                Console.WriteLine("Now lets find the area of your triangle with all sides greater then 0!!!");
                Console.Write("Enter side a:");
                sidea = checked (Convert.ToInt32(Console.ReadLine()));
                if (sidea <= 0) throw new Exception();
                Console.Write("Enter side b:");
                sideb = checked (Convert.ToInt32(Console.ReadLine()));
                if (sideb <= 0) throw new Exception();
                Console.Write("Enter side c:");
                sidec = checked(Convert.ToInt32(Console.ReadLine()));
                if (sidec <= 0) throw new Exception();
                double p = (sidea + sideb + sidec) / 2;
                double N = p * (p - sidea) * (p - sideb) * (p - sidec);
                double AOT = Math.Sqrt(N);
                Console.WriteLine("The area of your triangle is: {0}", AOT);
            }
            catch (FormatException Error)
            {
                Console.WriteLine(Error.Message.ToString());
                 AreaOfTriangle();
            }
            catch (OverflowException Error)
            {
                Console.WriteLine(Error.Message.ToString());
                AreaOfTriangle();
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a number between 1-100");
                AreaOfTriangle();
            }
        }
    }
}
