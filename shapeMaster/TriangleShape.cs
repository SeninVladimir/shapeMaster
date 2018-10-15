using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeMaster
{
    public class TriangleShape : Shape
    {
        #region Constructor

        /// <summary>
        /// Треугольник
        /// </summary>
        /// <param name="a">Длина стороны a</param>
        /// <param name="b">Длина стороеы b</param>
        /// <param name="c">Длина стороны c</param>
        public TriangleShape(double a, double b, double c) : base(ShapeType.triangle)
        {
            _a = a;
            _b = b;
            _c = c;
            _pp = ((a + b + c) / 2);
            CalculateArea(() => { return Math.Sqrt(_pp * (_pp - _a) * (_pp - b) * (_pp - c)); });
        }

        #endregion

        #region Fields

        private double _a, _b, _c, _pp;

        #endregion

        #region Properties

        /// <summary>
        /// Длина стороны а
        /// </summary>
        public double A { get => _a; }
        /// <summary>
        /// Длина стороны b
        /// </summary>
        public double B { get => _b; }
        /// <summary>
        /// Длина стороны с
        /// </summary>
        public double C { get => _c; }
        /// <summary>
        /// Полупериметр
        /// </summary>
        public double PP { get => _pp; }

        #endregion
    }
}
