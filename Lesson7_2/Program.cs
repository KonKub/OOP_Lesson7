using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson7_2
{
    //2. * Создать класс Figure для работы с геометрическими фигурами.
    //     В качестве полей класса задаются цвет фигуры, состояние «видимое/невидимое».
    //     Реализовать операции: передвижение геометрической фигуры по горизонтали, по вертикали,
    //     изменение цвета, опрос состояния(видимый/невидимый).
    //     Метод вывода на экран должен выводить состояние всех полей объекта.
    //     Создать класс Point (точка) как потомок геометрической фигуры.
    //     Создать класс Circle (окружность) как потомок точки.
    //     В класс Circle добавить метод, который вычисляет площадь окружности.
    //     Создать класс Rectangle (прямоугольник) как потомок точки, реализовать метод вычисления площади прямоугольника.
    //     Точка, окружность, прямоугольник должны поддерживать методы передвижения по горизонтали и вертикали, изменения цвета.
    //     Подумать, какие методы можно объявить в интерфейсе, нужно ли объявлять абстрактный класс,
    //     какие методы и поля будут в абстрактном классе, какие методы будут виртуальными, какие перегруженными.
    class Program
    {
        static void Main(string[] args)
        {
            Point PointObject = new Point(1, 1);

            PointObject.ShowInfo();
            PointObject.SetColor(ConsoleColor.Red);
            PointObject.SetVisibility(true);
            PointObject.MoveVertical(5);
            PointObject.MoveHorizontal(100);
            PointObject.ShowInfo();
            Console.WriteLine();

            Circle CircleObject = new Circle(10, 10, 5);

            CircleObject.ShowInfo();
            CircleObject.SetColor(ConsoleColor.Yellow);
            CircleObject.SetVisibility(false);
            CircleObject.MoveVertical(12);
            CircleObject.MoveHorizontal(-15);
            CircleObject.ShowInfo();
            Console.WriteLine();

            Rectangle RectangleObject = new Rectangle(5, 20, 3, 7);

            RectangleObject.ShowInfo();
            RectangleObject.SetColor(ConsoleColor.Gray);
            RectangleObject.SetVisibility(true);
            RectangleObject.MoveVertical(33);
            RectangleObject.MoveHorizontal(-100);
            RectangleObject.ShowInfo();

            Console.ReadKey();
        }
    }
}
