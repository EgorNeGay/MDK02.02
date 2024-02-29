using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK02._02
{
    internal class Program
    {
        //Головной модуль
        static void Main()
        {
            //Подключение класса Random.
            Random random = new Random();
            //Заполнение класса Random числами до 100.
            int zagadannoeChislo = random.Next(0, 101);
            //Изначальное количество попыток, равно 0.
            int attempts = 0;
            //Количество догадок.
            int guess = -1;

            Console.WriteLine("Отгадайте число от 0 до 100. У вас 10 попыток.");

            //Цикл while, в котором устанавливается конкретное количество попыток и происходит их увелечение на один, пока не достигнет 10.
            while (guess != zagadannoeChislo && attempts < 10)
            {
                Console.Write("Попытка №" + (attempts + 1) + ". Введите ваше предположение: ");
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                CheckGuess(guess, zagadannoeChislo);
               
            }


        }
        //Написал метод, который отвечает за проверку условия на загаданное число.
        static void CheckGuess(int guess, int zagadannoeChislo)
        {
            //Цикл с условием, который сравнивает попытку с загаданным числом.
            if (guess < zagadannoeChislo)
            {
                //Вывод на экран пользователя сообщение если он вписывает число меньше загаданного.
                Console.WriteLine("Загаданное число больше.");
            }
            else if (guess > zagadannoeChislo)
            {
                //Вывод на экран пользователя сообщение если он вписывает число больше загаданного.
                Console.WriteLine("Загаданное число меньше.");
            }
        }
    }
}
