using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практичск_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1
            //Person person = new Person();
            //person.name = "Артем";
            //person.surname = "Мутаф";
            //person.age = 22;
            //Person person2 = new Person("Артём", "Мутаф", 25);
            //person2.Giftinfo();
            //Задача 2
            Adress adres = new Adress(5533,"Columbia","Tiraspol");
            adres.Adres();
            Console.ReadKey();
        }

    }
}
