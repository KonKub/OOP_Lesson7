using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson7_2
{
    class Rectangle : Point
    {
        public int _side1 { get; set; }
        public int _side2 { get; set; }

        public Rectangle(int x, int y, int side1, int side2) : base(x, y)
        {
            _side1 = side1;
            _side2 = side2;
        }

        public double Square()
        {
            return _side1 * _side2;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Прямоугольник. Левая верхняя точка: X={_x}. Y={_y}. Сторона1= {_side1}. Сторона2= {_side2}. Цвет: {_color}. Видимость: {_visible}");
        }

        public override string ToString()
        {
            return $"Объект прямоугольник. X={_x}. Y={_y}. Сторона1= {_side1}. Сторона2= {_side2}. Цвет: {_color}. Видимость: {_visible}";
        }
    }
}
