using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeMaster
{
    public enum ShapeType
    {
        /// <summary>
        /// Круг
        /// </summary>
        circle,
        /// <summary>
        /// Треугольник
        /// </summary>
        triangle
    }

    public class Shape
    {
        #region Constructor

        /// <summary>
        /// Фигура
        /// </summary>
        public Shape(ShapeType type)
        {
            _type = type;
        }

        #endregion

        #region Fields

        private double _s;
        private ShapeType _type;

        #endregion

        #region Properties

        /// <summary>
        /// Площадь
        /// </summary>
        public double S { get => _s; }
        /// <summary>
        /// Тип фигуры
        /// </summary>
        public ShapeType Type { get => _type; }
        public delegate double CalculateAreaDelegate();

        #endregion

        #region Methods

        /// <summary>
        /// Вычислить площадь
        /// </summary>
        public void CalculateArea(CalculateAreaDelegate calculateAreaMethod)
        {
            _s = calculateAreaMethod();
        }

        #endregion
    }
}
