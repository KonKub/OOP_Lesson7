using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson7
{
    //   Создать класс ACoder, реализующий интерфейс ICoder.
    //   Класс шифрует строку посредством сдвига каждого символа на одну «алфавитную» позицию выше.
    //   (В результате такого сдвига буква А становится буквой Б).

    class ACoder : ICoder
    {
        public string Decode(string str)
        {
            string StrResult = "";
            for (int i = 0; i < str.Length; i++)
                StrResult = StrResult + (char)(str[i] - 1);
            return StrResult;
        }

        public string Encode(string str)
        {
            string StrResult = ""; 
            for (int i = 0; i < str.Length; i++)
                StrResult = StrResult + (char)(str[i] + 1); 
            return StrResult;
        }
    }
}
