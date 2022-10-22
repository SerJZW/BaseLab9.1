using System;

namespace VerySimpleAuth
{
    class Program
    {

        private static void Main()
        {
            while (true)
            {
                Console.WriteLine("Пройдите регистрацию");
                Console.Write("Введите логин: ");
                String login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                String pass = Console.ReadLine();


                if (login.Length > 9)
                {
                    Console.WriteLine("Недопустимое количество символов в логине - нужно менее 9!");
                }
                if (login.Length < 3)
                {
                    Console.WriteLine("Недопустимое количество символов в логине - нужно больше 3!");
                }
                if (pass.Length <3)
                {
                    Console.WriteLine("Недопустимое количество символов в пароле - нужно больше 3!");
                }
                if (pass.Length > 9)
                {
                    Console.WriteLine("Недопустимое количество символов в пароле - нужно меньше 9!");
                }
                
                if (login == pass)
                {
                    Console.WriteLine("Логин и пароль совпадают, измените данные");
                    continue;
                }
                else
                {
                    Console.WriteLine("Регистрация прошла успешно!");

                }
                break;

            }
        }
    }

}

