using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace errorsAndExceptions
{
    class areaCircumferenceVOH
    {
        public void AreaCircumferenceVOH()
        {
            int radiusInt = 0;
            int J = 2, L = 6, M = 4;
            try
            {
                Console.Write("Enter radius value:");
                radiusInt = checked (Convert.ToInt32(Console.ReadLine()));
                if (radiusInt <= 0) throw new Exception();
                double C = Calculation(J, radiusInt);
                double A = Calculation(radiusInt);
                double VOH = Calculation(M, radiusInt, L);
                Console.WriteLine("Circumference: {0}", C);
                Console.WriteLine("Area: {0}", A);
                Console.WriteLine("Volume Of Hemisphere: {0}", VOH);

            }
            catch (FormatException Error)
            {
                Console.WriteLine(Error.Message.ToString());
                AreaCircumferenceVOH();
            }
           catch (OverflowException Error)
            {
                Console.WriteLine(Error.Message.ToString());
                AreaCircumferenceVOH();
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a number between 1-100");
                AreaCircumferenceVOH();
            }
        }
        public static double Calculation (int J, int radiusInt)
        {
            return J * Math.PI * radiusInt;
        }
        public static double Calculation(int radiusInt)
        {
            return Math.PI * radiusInt * radiusInt;
        }
        public static double Calculation(int M, int radiusInt, int L)
        {
            return (M * Math.PI * radiusInt * radiusInt * radiusInt) / L;
        }
    }
}
