using System;

namespace lab3
{
    enum account
    {
        текущий,
        сберегательный
    }
    struct bankaccount
    {
        public ulong number;
        public string type;
        public int balance;
    }
    enum VUZ
    {
        KGU,
        KAI,
        KHTI
    }
    struct worker
    {
        public string name;
        public string VUZ;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная 3 главы\nУпражнение 3.1\nНеобходимо создать перечисляемый тип данных, отображающий виды банковского счета");
            account curentaccount = account.текущий;
            account savingaccaunt = account.сберегательный;
            Console.WriteLine("Ваш вид банвоского счета:{0}\n", account.сберегательный);

            Console.WriteLine("Упражнение 3.2\nНеобходимо создать структуру, которая хранит номер, тип, баланс и вывести эту информацию");
            bankaccount bank = new bankaccount();
            bank.number = 12345678912345678900;
            bank.type = "Сберегателельный счет";
            bank.balance = 1234;
            Console.WriteLine("Номер счета = {0}, Вид банковского счета = {1}, Баланс = {2}\n", bank.number, bank.type, bank.balance);

            Console.WriteLine("Домашнее задание 3.1\nНеобходимо создать перечисляемый тип ВУЗ и струкуту работник");
            worker work = new worker();
            work.name = "Tom";
            work.VUZ = "KAI";
            Console.WriteLine("Имя работника = {0}, ВУЗ = {1}", work.name, work.VUZ);
            Console.ReadKey();
        }
    }
}
