using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson7_2
{
    interface IFigure
    {
        void MoveVertical(int step);
        void MoveHorizontal(int step);
        void SetColor(ConsoleColor color);
        void SetVisibility(bool visibility);
        void ShowInfo();
    }
}
