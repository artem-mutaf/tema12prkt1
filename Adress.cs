using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практичск_1
{
    class Adress
    {
        /// <summary>
        /// Перове поле <Индекс>
        /// </summary>
        public int index;
        /// <summary>
        /// Второе поле <Страна>
        /// </summary>
        public string country;
        /// <summary>
        /// Третье поле <Город> 
        /// </summary>
        public string city;
        /// <summary>
        /// Четвертое поле <Улица>
        /// </summary>
        public string street;
        /// <summary>
        /// Пятое поле <Апартаменты номер>
        /// </summary>
        public int apartment;
        public Adress(){ }
        public Adress(int index,string country,string city)
        {
            this.index = index;
            this.country = country;
            this.city = city;
        }
        public void Adres()
        {
            Console.WriteLine($"Введите ваш индекс-{index}\nВведите вашу страну{country}\nВведите ваш город{city}");
        }



    }
}
