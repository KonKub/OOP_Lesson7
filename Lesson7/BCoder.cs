using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson7
{
    //   Создать класс BCoder, реализующий интерфейс ICoder.
    //   Класс шифрует строку, выполняя замену каждой буквы, стоящей в алфавите на i-й позиции, на букву того же регистра,
    //   расположенную в алфавите на i-й позиции с конца алфавита. Например, буква В заменяется на букву Э.
    //   Написать программу, демонстрирующую функционирование классов.
    class BCoder : ICoder
    {
        private const int HighRegMin = 1040;
        private const int HighRegMax = 1071;
        private const int LowRegMin = 1072;
        private const int LowRegMax = 1103;

        public string Decode(string str)
        {
            string StrResult = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= HighRegMin && str[i] <= HighRegMax) //А - Я
                    StrResult = StrResult + (char)(HighRegMin + (HighRegMax - str[i]));
                if (str[i] >= LowRegMin && str[i] <= LowRegMax) //а - я
                    StrResult = StrResult + (char)(LowRegMin + (LowRegMax - str[i]));
            }
            return StrResult;
        }

        public string Encode(string str)
        {
            string StrResult = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= HighRegMin && str[i] <= HighRegMax) //А - Я
                    StrResult = StrResult + (char)(HighRegMax - (str[i] - HighRegMin));
                if (str[i] >= LowRegMin && str[i] <= LowRegMax) //а - я
                    StrResult = StrResult + (char)(LowRegMax - (str[i] - LowRegMin));
            }
            return StrResult;
        }
    }
}
