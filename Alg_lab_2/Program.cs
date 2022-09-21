using System;

namespace Alg_lab_2
{
    class Program
    {
        static double Function(double t)
        {
            return (t / Math.Log(1 + t));

        }


        static void UsingFunction_plus_UsingFunctionRunge(double[] forFunction, double[] forFunction_Runge, double a_max, double h, double h_runge)
        {
            int k = 0;
            //double round4 = 0;
            double summ = 0;
            for (double x = h; x <= a_max; x += h, k++)
            {
                forFunction[k] = Function(x);

                double round4 = Math.Round(forFunction[k], 4);
                summ = summ + round4;

            }
            double final_suma_1 = Math.Round(summ * h, 4);

            Console.WriteLine("Integral1: {0}",final_suma_1);



            int k2 = 0;
            //double round4_2 = 0;
            double summ_2 = 0;
            for (double x = h_runge; x <= a_max; x += h_runge, k2++)
            {
                forFunction_Runge[k2] = Function(x);

                double round4_2 = Math.Round(forFunction_Runge[k2], 4);
                summ_2 = summ_2 + round4_2;

            }
            double final_suma_2 = Math.Round(summ_2 * h_runge, 4);
            Console.WriteLine("Integral2: {0}",final_suma_2);

            Console.WriteLine("Fault: {0}", final_suma_1-final_suma_2);
        }


        /*static void UsingFunction_Runge(double[] forFunction_Runge, double a_max, double h_runge, double h)
        {
            int k = 0;
            double round4 = 0;
            double summ = 0;
            for (double x = h_runge; x <= a_max; x += h_runge, k++)
            {
                forFunction_Runge[k] = Function(x);

                round4 = Math.Round(forFunction_Runge[k], 4);
                summ = summ + round4;

            }
            double final_suma_2 = Math.Round(summ * h_runge, 4);
            Console.WriteLine(final_suma_2);
        }*/

        static void Main(string[] args)
        {
            int a_min = 0;
            int a_max = 1;
            double h = 0.1;
            double h_runge = h * 2;
            int sizearray = Convert.ToInt32(((a_max - a_min) / h));//10
            int sizearray_runge = Convert.ToInt32(((a_max - a_min) / h));//5
            double[] forFunction = new double[sizearray];
            double[] forFunction_Runge = new double[sizearray_runge];
            Console.WriteLine(sizearray);

            UsingFunction_plus_UsingFunctionRunge(forFunction, forFunction_Runge, a_max, h, h_runge);
            // UsingFunction_Runge(forFunction_Runge, a_max, h_runge, h);
            //Console.WriteLine("Fault:");
           
        }
    }
}






