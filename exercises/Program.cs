using System;
using System.Threading;

namespace exercises
{
    struct student
    {
        public string surname;
        public string name;
        public int ID;
        public string birthday;
        public char alcogolizmcategory;
        public double volume;
    }
    struct user
    {
        public string name;
        public string city;
        public int age;
        public int PIN;
    }
internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Задача 1\nНеобходимо вывести на экран тип данных, его максимальное и минимальное значение\nbyte  -  {byte.MaxValue}  -  {byte.MinValue}\nSByte  -  {sbyte.MaxValue}  -  {sbyte.MinValue}\nShort - {short.MaxValue} - {short.MinValue}\nushort  -  {ushort.MaxValue}  -  {ushort.MinValue} \nint  -  {int.MaxValue}  -  {int.MinValue} \nuint  -  {uint.MaxValue}  -  {uint.MinValue} \nlong  -  {long.MaxValue} - {long.MinValue} \nulong  -  {ulong.MaxValue}  -  {ulong.MinValue} \nfloat  -  {float.MaxValue}  -  {float.MinValue} \ndouble  -  {double.MaxValue}  -  {double.MinValue}\ndecimal  -  {decimal.MaxValue}  -  {decimal.MinValue}\nchar  -   нет  -  нет\nstring  -  нет  -  нет\nbool  -  true  -  false\nobject  -  нет  -  нет\ndynamic  -  нет  -  нет\n");

            Console.WriteLine("Задача 2\nНеобходимо получить от пользователя данные, сохранить их в перменной и вывести");
            user us = new user();
            Console.WriteLine("Введите ваше имя:");
            us.name = Console.ReadLine();
            Console.WriteLine("Введите ваш город:");
            us.city = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст:");
            us.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш пин:");
            us.PIN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Имя пользователя:{us.name}\nГород пользователя:{us.city}\nВозраст пользователя:{us.age}\nПин пользователя:{us.PIN}\n");

            Console.WriteLine("Задача 3\nНеобходимо заменить строчные буквы на заглавные, загалвные на строчные\nВведите строку:");
            string str = Console.ReadLine();
            string finallystr = "";
            for (int i = 0; i < str.Length; i++)
            {
                string letter = str[i].ToString().ToLower();
                if (str[i].ToString() == letter)
                {
                    letter = letter.ToUpper();
                }
                finallystr = finallystr + letter;
            }
            Console.WriteLine($"Получилась следующая строка: {finallystr}\n");

            Console.WriteLine("Задача 5\nНеобходимо определить, сколько бутылок виски нужно купить, чтобы накопить на отпуск");
            Console.WriteLine("Введите стандартную цену:");
            double normPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите скидку в процентах:");
            double salePrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стоимость отпуска:");
            double holidayPrice = Convert.ToDouble(Console.ReadLine());
            double eco = salePrice/100*normPrice;
            double quan = Math.Floor(holidayPrice / eco);
            Console.WriteLine($"Количество бутылок = {quan}\n");
            
            Console.WriteLine("Задача 6\nВоспроизвести разговор Гарри Поттера и дневника Тома Реддла.");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ReadLine();
            Console.WriteLine("Как тебя зовут?");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Привет,{name}");
            Console.ReadLine();
            Console.WriteLine("Да");
            Console.ReadLine();
            Console.WriteLine("Нет");
            Thread.Sleep(5000);
            Console.WriteLine("Но могу показать\n");
            Console.ResetColor();

            Console.WriteLine("Задача 7\nНеобходимо вычислить контрольную цифру штрихкода\nСлучайные цифры");
            string value = "";
            Random rnd = new Random();
            for (int i = 0 ; i <= 11; i++)
            {
                value = value + rnd.Next(9);
            }
            Console.WriteLine($"{value}");
            uint oddnumbers = 0;
            uint evernumbers = 0;
            for (int i = 1; i < value.Length; i += 2)
            {
                evernumbers = evernumbers + Convert.ToUInt32(value[i].ToString());
            }
            for (int i = 0; i < value.Length; i += 2)
            {
                oddnumbers = oddnumbers + Convert.ToUInt32(value[i].ToString());
            }
            uint fin = 10 - ((evernumbers * 3 + oddnumbers) % 10);
            Console.WriteLine("Контрольная цифра = {0}",fin);

            Console.WriteLine("Пользователь вводит числа");
            Console.WriteLine("Введите 12 цифр без пробелов:");
            string value1 = Console.ReadLine();
            uint oddnumbers1 = 0;
            uint evernumbers1 = 0;
            for (int i = 1; i < value1.Length; i += 2)
            {
                evernumbers1 = evernumbers1 + Convert.ToUInt32(value1[i].ToString());
            }
            for (int i = 0; i < value1.Length; i += 2)
            {
                oddnumbers1 = oddnumbers1  + Convert.ToUInt32(value1[i].ToString());
            }
            uint fin1 = 10 - ((evernumbers1 * 3 + oddnumbers1) % 10);
            Console.WriteLine("Контрольная цифра = {0}\n", fin1);

            Console.WriteLine("Задача 9\nНеобходимо посчитать общий объем алкоголя и сколько процентов выпил каждый студент");
            student student1 = new student();
            student1.surname = "Иванов";
            student1.name = "Иван";
            student1.ID = 01;
            student1.birthday = "01.01.2001";
            student1.alcogolizmcategory = 'a';
            student1.volume = 7;
            student student2 = new student();
            student2.surname = "Васильев";
            student2.name = "Василий";
            student2.ID = 02;
            student2.birthday = "02.02.2002";
            student2.alcogolizmcategory = 'b';
            student2.volume = 4;
            student student3 = new student();
            student3.surname = "Сергеев";
            student3.name = "Сергей";
            student3.ID = 03;
            student3.birthday = "03.03.2003";
            student3.alcogolizmcategory = 'b';
            student3.volume = 3;
            student student4 = new student();
            student4.surname = "Андреев";
            student4.name = "Андрей";
            student4.ID = 04;
            student4.birthday = "04.04.2004";
            student4.alcogolizmcategory = 'c';
            student4.volume = 1;
            student student5 = new student();
            student5.surname = "Егоров";
            student5.name = "Егор";
            student5.ID = 05;
            student5.birthday = "05.05.2005";
            student5.alcogolizmcategory = 'd';
            student5.volume = 0;
            double volume6 = student1.volume + student2.volume + student3.volume + student4.volume + student5.volume;
            double percent1 = (student1.volume / volume6) * 100;
            double percent2 = (student2.volume / volume6) * 100;
            double percent3 = (student3.volume / volume6) * 100;
            double percent4 = (student4.volume / volume6) * 100;
            double percent5 = (student5.volume / volume6) * 100;
            Console.WriteLine($"Общий объем алкоголя = {volume6}\nИван выпил {percent1}% алкоголя\nВасилий выпил {percent2}% алкоголя\nИван выпил {percent3}% алкоголя\nАндрей выпил {percent4}% алкоголя\nЕгор выпил {percent5}% алкоголя");
            Console.ReadKey();
        }
    }
}
