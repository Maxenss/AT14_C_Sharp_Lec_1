using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lec_1
{
    class Catv2
    {
        // Поля класса
        public string gender;
        public string name;
        public string color;
        public int age;
        public int countOfLifes;

        // Пользовательский конструктор
        public Catv2(string _gender, 
            string _name, 
            string _color, 
            int _age, 
            int _countOfLifes) {

            gender = _gender;
            name = _name;
            age = _age;
            color = _color;
            countOfLifes = _countOfLifes;
        }

        // Конструктор по-умолчанию
        public Catv2() {

        }
    }
}
