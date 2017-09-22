﻿// Импортированные пространства имен и класс
// По аналалогии с С - импортированные библиотеки функций
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Пространство имён
namespace C_Sharp_Lec_1
{
    // Класс
    class Program
    {
        // Главный метод программы, с которого начинается выполнения .Net приложения
        static void Main(string[] args)
        {
            // Метод для вывода на экран
            // Console.WriteLine("Hello world!"); // вывод на экран с переносом строки
            // Console.Write("Hello, AT :)\n");   // вывод на экран без переноса строки

            // Метод для ввода с клавиатуры
            // По-умолчанию, всё, что введете в консоль, является строкой (String)
            //   string str1 = Console.ReadLine(); // Считываем строку до нажатия кнопки Enter
            //   Console.WriteLine("Введенная строка : " + str1);


            Example_3();


            // Задержку времени выполнения
            Console.ReadKey();
        }

        public static void Example_1()
        {
            // a^2 + (b / c) 
            // Объявляем переменные
            double a = 0;
            double b = 0;
            double c = 0;
            double res = 0;

            Console.Write("Введите a : ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите b : ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите c : ");
            c = Convert.ToDouble(Console.ReadLine());

            res = Math.Pow(a, 2) + (b / c);

            // Console.WriteLine(a + " ^ " + "2" + "(" + b + " / " + c + ") = " + res);
            Console.WriteLine("{0}^2 + ({1} / {2}) = {3}", a, b, c, res);
        }

        public static void Example_2()
        {
            // Создали объект, с использование конструктора по-умолчанию
            // Все поля объекта равны значениям по-умолчанию
            Catv1 cat1 = new Catv1();
            cat1.age = 5;
            cat1.color = "Grey";
            cat1.countOfLifes = 9;
            cat1.gender = "Средний";
            cat1.name = "Оно";

            Console.WriteLine("Имя cat1 - {0}", cat1.name);
        }

        public static void Example_3()
        {
            // Создали объект, с использование конструктора пользовательского
            // Все поля объекта равны значениям, которые мы описали при создании объекта
            Catv2 cat1 = new Catv2("Мужской", "Барсик", "Темный", 10, 9);
            Console.WriteLine("Имя - {0}", cat1.name);
            Console.WriteLine("Пол - {0}", cat1.gender);
            Console.WriteLine("Цвет - {0}", cat1.color);
            Console.WriteLine("Возраст - {0}", cat1.age);
            Console.WriteLine("Количество жизней - {0}", cat1.countOfLifes);
        }

        #region Конструкторы 
        // Конструкторы класса позволяет создавать объекты класса
        // Есть два вида конструкторов : 
        //  1. Конструктор по-умолчанию. Инициализирует поля класса значениями по умолчанию.
        //     для byte, short, int. long = 0 
        //     для float, double - 0.0
        //     для char - '\0'
        //     для bool - false
        //     для объектных типов - null
        //     Конструктор по-умолчанию существует неявно, до тех пор, пока не был описан пользовательский конструктор.
        //  2. Пользовательский конструктор позволяет создавать объект таким образом, как описал программист
        //     Т.е. можно явно присваивать значения полям класса, во время создание объекта.
        //     Как только был описан пользовательский конструктор, конструктор по-муолчанию, следует описывать вручную
        #endregion

        #region Модификаторы доступа
        // Модифиикаторы доступа позволяют скрывать члены класса (поля, методы, делегаты, события).
        // Три модификатора доступа :
        //  private - член класса является закрытым, и недоступен за пределами класса, и не доспупен наследникам
        //  protected - член класса является закрытым, и недоступен за пределами класса, доспупен наследникам
        //  public - член класса явлется открытым, достпуен за пределами класса, доступен наследникам
        //  По-умолчанию в C#, если не указан МД у члена класса, то МД - private
        //  С помощью МД мы реализиуем парадигму Инкапсуляцию, т.е. сокрытие реализации членов класса
        #endregion

        #region Горячие клавиши
        // Ctrl + K + F - форматирование кода
        // Alt + LKM + Mouse Up or Mouse Down - выделение нескольких строк для редактирования
        #endregion
    }
}