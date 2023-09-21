using System;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная 2 главы\nУпражнение 2.1\nПрограмма приветствует пользователя по имени\nВведите ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, {0}\n",name);

            Console.WriteLine("Упражнение 2.2\nНеобходимо поделить одно число на другое\nВведите 2 числа:");
            
            double numb1 = Convert.ToDouble(Console.ReadLine());
            double numb2 = Convert.ToDouble(Console.ReadLine());
            if (numb2==0)
            {
                Console.WriteLine("Вы неправильно ввели данные\n");
            }
            else 
            {
                double div1 = numb1 / numb2;
                Console.WriteLine("Частное = {0}\n", div1);
            }

            Console.WriteLine("Домашняя работа 2.1\nПользователь вводит букву, программа выводит следующую по алфавиту\nВведите букву:");
            char letter = Convert.ToChar(Console.ReadLine());
            if (letter == 'z')
            {
                Console.WriteLine("Следующая буква по алфавиту: a\n");    
            }
            else if (letter == 'я')
            {
                Console.WriteLine("Следующая буква по алфавиту: а\n");
            }
            else
            {
                Console.WriteLine("Следующая буква по алфавиту: {0}\n", (char)(letter + 1));
            }

            Console.WriteLine("Домашняя работа 2.2\nНеобходимо найти корни квадратного уравнения\nВведите первый коэффинцент:");
            double a = Convert.ToDouble(Console.ReadLine());  
            Console.WriteLine("Введите второй коэффинцент:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третий коэффицент:");
            double c = Convert.ToDouble(Console.ReadLine());;
            double D = b*b - 4 * a * c; // находит дискриминант
            Console.WriteLine("Дискриминант = {0}", D);
            if (D == 0) // если дискриминант > 0
            {
                double X1 = -b / 2;
                Console.WriteLine("x1 = {0}", X1);
            }
            else if (D > 0)
            {
                double x1 = (-b - Math.Sqrt(D) / 2 * a);
                double x2 = (-b + Math.Sqrt(D) / 2 * a);
                Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
            }
            else // если дискриминант < 0
            {
                Console.WriteLine("Уравнение не имеет корней");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}