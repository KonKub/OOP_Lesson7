using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson7_2
{
    class Circle : Point
    {
        private int _radius { get; set; }

        public Circle(int x, int y, int radius) : base(x, y)
        {
            _radius = radius;
        }

        public double Square()
        {
            return Math.PI * _radius * _radius;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Окружность. Центр: X={_x}. Y={_y}.  Радиус= {_radius}. Цвет: {_color}. Видимость: {_visible}.");
        }

        public override string ToString()
        {
            return $"Объект окружность. X={_x}. Y={_y}. Радиус= {_radius}. Цвет: {_color}. Видимость: {_visible}";
        }
    }
}
