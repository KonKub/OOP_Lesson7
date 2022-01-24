using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson7_2
{
    class Point : Figure
    {
        public int _x { get; set; }
        public int _y { get; set; }

        public Point(int x, int y) : base(ConsoleColor.Green, true)
        {
            _x = x;
            _y = y;
        }

        public new void MoveVertical(int step)
        {
            _y = _y + step;
        }

        public new void MoveHorizontal(int step)
        {
            _x = _x + step;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Точка.  X={_x}. Y={_y}. Цвет: {_color}. Видимость: {_visible}.");
        }

        public override string ToString()
        {
            return $"Объект точка. X={_x}. Y={_y}. Цвет: {base._color}. Видимость: {_visible}";
        }
    }
}
