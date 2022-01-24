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

    abstract class Figure : IFigure
    {
        public ConsoleColor _color { get; set; }
        public bool _visible { get; set; }

        public Figure(ConsoleColor color, bool visibility)
        {
            _color = color;
            _visible = visibility;
        }

        public void MoveVertical(int step) { }
        public void MoveHorizontal(int step) { }

        public void SetColor(ConsoleColor color) 
        {
            _color = color;
        }
        public void SetVisibility(bool visibility) 
        {
            _visible = visibility;
        }

        public virtual void ShowInfo() 
        {
            Console.WriteLine($"Цвет: {_color}. Видимость: {_visible}.");
        }
        public override string ToString()
        {
            return $"Фигура. Цвет: {_color}. Видимость: {_visible}";
        }
    }
}
