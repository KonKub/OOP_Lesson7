using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson7
{

    //1. Определить интерфейс IСoder, который полагает методы поддержки шифрования строк.
    //   В интерфейсе объявляются два метода Encode() и Decode(), используемые для шифрования и дешифрования строк.
    //   Создать класс ACoder, реализующий интерфейс ICoder.
    //   Класс шифрует строку посредством сдвига каждого символа на одну «алфавитную» позицию выше.
    //   (В результате такого сдвига буква А становится буквой Б).
    //   Создать класс BCoder, реализующий интерфейс ICoder.
    //   Класс шифрует строку, выполняя замену каждой буквы, стоящей в алфавите на i-й позиции, на букву того же регистра,
    //   расположенную в алфавите на i-й позиции с конца алфавита. Например, буква В заменяется на букву Э.
    //   Написать программу, демонстрирующую функционирование классов.

    class Program
    {
        static void Main(string[] args)
        {
            const string TestString1 = "абвгдеёжзийклмнопрстуфхцчшщьыъэюя";
            const string TestString2 = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЫЪЭЮЯ";

            ACoder aCoder = new ACoder();
            BCoder bCoder = new BCoder();

            string ResultString;
                                                              //тестирование класа aCodeer
            Console.WriteLine($"Строка: {TestString1}");
            ResultString = aCoder.Encode(TestString1);
            Console.WriteLine($"Encode: {ResultString}");
            ResultString = aCoder.Decode(ResultString);
            Console.WriteLine($"Decode: {ResultString}");
            Console.WriteLine();
            
            Console.WriteLine($"Строка: {TestString2}");
            ResultString = aCoder.Encode(TestString2);
            Console.WriteLine($"Encode: {ResultString}");
            ResultString = aCoder.Decode(ResultString);
            Console.WriteLine($"Decode: {ResultString}");
            Console.WriteLine();
                                                              //тестирование класа bCodeer
            Console.WriteLine($"Строка: {TestString1}");
            ResultString = bCoder.Encode(TestString1);
            Console.WriteLine($"Encode: {ResultString}");
            ResultString = bCoder.Decode(ResultString);
            Console.WriteLine($"Decode: {ResultString}");
            Console.WriteLine();

            Console.WriteLine($"Строка: {TestString2}");
            ResultString = bCoder.Encode(TestString2);
            Console.WriteLine($"Encode: {ResultString}");
            ResultString = bCoder.Decode(ResultString);
            Console.WriteLine($"Decode: {ResultString}");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
