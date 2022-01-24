using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson7
{
    //   Определить интерфейс IСoder, который полагает методы поддержки шифрования строк.
    //   В интерфейсе объявляются два метода Encode() и Decode(), используемые для шифрования и дешифрования строк.
    interface ICoder
    {
        string Encode(string str);
        string Decode(string str);
    }
}
