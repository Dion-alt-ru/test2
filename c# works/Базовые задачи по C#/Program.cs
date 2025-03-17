using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Базовые_задачи_по_C_
{
    internal class Program
    {

        static void Daubi()
        {
            double num1;
            double num2;
            double total;
            char oper;
            Console.WriteLine("Задание 1 Калькулятор. Доступные операторы: '+', '-', '*', '/'");
            Console.WriteLine("Введите первое число:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите оператор:");
            oper = Convert.ToChar(Console.ReadLine());

            if (oper == '+')
            {
                total = num1 + num2;
                Console.WriteLine("Cумма " + num1 + " и " + num2 + " равна " + total + ".");
            }

            else if (oper == '-')
            {
                total = num1 - num2;
                Console.WriteLine("Разность " + num1 + " и " + num2 + " равна " + total + ".");
            }

            else if (oper == '*')
            {
                total = num1 * num2;
                Console.WriteLine("Умножение " + num1 + " на " + num2 + " равно " + total + ".");
            }

            else if (oper == '/')
            {
                total = num1 / num2;
                Console.WriteLine("Деление " + num1 + " на " + num2 + " равно " + total + ".");
            }
            else
            {
                Console.WriteLine("Неизвестный оператор, повторите попытку");
            }
        }

        


        static void Main(string[] args)
        {

            Random rand = new Random();
            int digit = rand.Next(0, 100);
            Console.WriteLine("Угадай число");
            bool gameRuning = true;
            int number = 0;
            while (gameRuning)
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number > digit) {
                    Console.WriteLine("Ваше число больше загаданного");
                }
                else if (number < digit){
                    Console.WriteLine("Ваше число меньше");
                }
                else
                {
                    Console.WriteLine("Вы угадали!!!");
                }
            }


            try
            {
                Daubi();
            }
            catch (Exception e)
            {
               
                Console.WriteLine("Произошла ошибка, попробуйте перезапустить программу и попробовать снова нажми кнопку");
                Console.ReadKey();
                Daubi();
            }

            
            

                Console.WriteLine("Задания 3 чтобы продолжить напишите слово или предложение");
                string original = Console.ReadLine();
                string reversed = new string(original.Reverse().ToArray());
                Console.WriteLine(reversed);



                Console.WriteLine("Задания 5 подсчет гласных. Чтобы продолжить напишите слово или предложение");
                string str = Console.ReadLine();
                int count = Regex.Matches(str, @"[ауоыиэяюёе]", RegexOptions.IgnoreCase).Count;
                Console.WriteLine($"Кол-во гласных  букв: {count}");
                
            
            

            Console.ReadKey();
        }
    }
}
