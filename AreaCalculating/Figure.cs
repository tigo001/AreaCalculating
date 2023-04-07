using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculating
{
    internal class Figure
    {
        public List<double> Parameters { get; set; }

        public Figure(List<double> sides)
        {
            Parameters = sides;
        }

        public Figure(params double[] sides)
        {
            Parameters = sides.ToList();
        }

        public double GetArea()
        {
            if (Parameters.Count == 0)
                throw new Exception("Figure is not recognized.");

            switch(Parameters.Count)
            {
                case 1:
                    return GetAreaOfCircle();

                case 3:
                    return GetAreaOfTriangle();

                default:
                    throw new Exception("Figure is not recognized.");
            }
        }

        public bool IsRectengularTriangle()
        {
            if (Parameters.Count != 3)
                throw new Exception("Figure is not triangle.");

            int indexOfMax = Parameters.IndexOf(Parameters.Max());
            double sum = 0;

            foreach (double side in Parameters.Where(x => x != Parameters[indexOfMax]))
                sum += Math.Pow(side, 2);
            
            return sum == Math.Pow(Parameters.Max(), 2);
        }

        #region Get Area Functions
        private double GetAreaOfCircle()
        {
            return Math.PI * Math.Pow(Parameters[0], 2);
        }

        private double GetAreaOfTriangle()
        {
            double halfPerimeter = Parameters.Sum() / 2;
            var res = halfPerimeter * (halfPerimeter - Parameters[0]) * (halfPerimeter - Parameters[1]) * (halfPerimeter - Parameters[2]);
            return Math.Sqrt(res);
        }
        #endregion
    }
}