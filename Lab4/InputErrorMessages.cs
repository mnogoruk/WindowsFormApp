using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Errors
    {
        public class Error
        {
            public int Code { get; }
            public string Messge { get; }
            public Error(int code, string messge)
            {
                Code = code;
                Messge = messge;
            }
        }
        public static Error TooLargeNumber  = new Error(1, "Слишком большое число.");
        public static Error WrongNumberFormat = new Error(2, "Неправильный формат числа.");
        public static Error ToolargeForDisplay = new Error(3, "Фигура не помещается на экране.");
        public static Error NoColorChosen = new Error(4, "Не выбрано ни одного цвета.");
        public static Error InputError = new Error(5, "Исправте ошибки ввода");
        
    }
}
