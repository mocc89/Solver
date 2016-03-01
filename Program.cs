using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solver
{
    class Program
    {
        static void Main(string[] args)
        {


            Solver.Pyhegoreantriple solver = new Pyhegoreantriple();
            solver.solve();
            //Genetics dummy = new Genetics();
            //Genetics.xsxs = 4;
            //dummy.xsxs = 4;
            //Genetics.GetOffspring("AaXxxxXdD", "AaXxxxXdD", "DDDRDRDDR");

            Console.Write(solver.solve());
            while (true)
            {

            }
        }
    }


    public class Genetics
    {
        public int xsxs;


        public static string GetOffspring(string q1, string q2, string dom)
        {

            //char[] domArray = dom.ToArray();
            //char[] domArray = q1.ToArray();
            //char[] domArray = q2.ToArray();
            //foreach (var item in domArray)
            //{
            //    if (item == 'D')
            //    {

            //    }
            //    else
            //    {

            //    }


            //}


            return "";
        }

    }

    public class Pyhegoreantriple
    {
        public double solve()
        {
            double result = 0;
            for (int i = 0; i < 300; i++)
            {
                for (int j = i + 1; j < 500; j++)
                {
                    int productOfEdges = i * i + j * j;
                    double hypotenuse = Math.Sqrt(productOfEdges);

                    if (hypotenuse > j)
                    {
                        if (i + j + hypotenuse == 1000)
                        {
                            result = i *j * hypotenuse;
                        }
                    }

                }
            }

            return result;
        }

    }
}
