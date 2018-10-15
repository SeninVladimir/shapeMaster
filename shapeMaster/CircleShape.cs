using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeMaster
{
    public class CircleShape : Shape
    {
        #region Constructor

        /// <summary>
        /// Круг
        /// </summary>
        /// <param name="d"></param>
        public CircleShape(double d) : base(ShapeType.circle)
        {
            _d = d;
            CalculateArea(() => { return Math.PI * Math.Pow((_d / 2), 2); });
        }

        #endregion

        #region Fields

        private double _d;

        #endregion

        #region Properties

        /// <summary>
        /// Диаметр
        /// </summary>
        public double D { get => _d; }

        #endregion
    }
}
