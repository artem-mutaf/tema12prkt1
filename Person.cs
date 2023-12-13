using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практичск_1
{
    class Person
    {
        //Задача 1
        /// <summary>
        /// Первое поле <Имя>
        /// </summary>
        public string name;
        /// <summary>
        /// Второе поле <Фамилия>
        /// </summary>
        public string surname;
        /// <summary>
        /// Третье поле <Возраст>
        /// </summary>
        public int age;
        /// <summary>
        /// Конструктор по умлочнаию <без параметров>
        /// </summary>

        public Person()
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        public Person(string name,string surname,int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;

        }
        /// <summary>
        /// Метод <Вывода>
        /// </summary>
        public void Giftinfo()
        {
            Console.WriteLine($"Имя-{name}\nФамилия-{surname}\nВозраст-{age}");
        }
    }
}
