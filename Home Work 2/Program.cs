using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_2 
{
    class Program
    {       
        static void Main(string[] args)
        {
           
            



            //Исполнитель Илья Владимиров.
            #region( Задача 1 Метод возвращающий минимальное из трех чисел)
            
                int a;
                int b;
                int c;
                int d;
                Console.WriteLine("Метод возвращающий минимальное из трех чисел");

                Console.WriteLine("Введите первое число");

                string num1 = Console.ReadLine();
                a = int.Parse(num1);

                Console.WriteLine("Введите Второе число");

                string num2 = Console.ReadLine();
                b = int.Parse(num2);

                Console.WriteLine("Введите Третье число");

                string num3 = Console.ReadLine();
                c = int.Parse(num3);

                d = a;

                if (b < d) d = b;
                if (c < d) d = c;

            Console.WriteLine($"Наименьшее из трех введенных чисел равно {d}");
            Console.ReadLine();

            #endregion

            Console.Clear();

            #region( Задача 2  Метод подсчета количества цифр числа)
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{Count(number)}");
            Console.ReadKey();
        }

            public static int Count(int a)
        {
            int countNumber = (int)Math.Log10(a) + 1;
            return countNumber;
            #endregion

            Console.Clear();

            #region(Задача 3 С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел).
            int sum = 0;
            int num = 0;

            do
            {
                num = int.Parse(Console.ReadLine());
                if (num > 0 && num % 2 == 1)
                    sum += num;

            } while (num != 0);

            Console.WriteLine("Sum: " + sum);
            #endregion

            Console.Clear();

            #region(Задача 4 Реализовать метод проверки логина и пароля.)

            int i = 1;
            Console.WriteLine($"Попытка №: {i}"); // Вывод номера попытки ввода данных

            Console.Write("Введите логин: ");
            string userName = Console.ReadLine(); 

            Console.Write("Введите пароль: ");
            string userPassword = Console.ReadLine(); 

            // начинаем цикл do while
            do
            {
                Console.Clear(); 

                if (userChec(userName, userPassword) == false) 
                {
                    if (i > 2) // Лимит попыток
                    {
                        Console.WriteLine("Доступ заблокирован: Превышен лимит попыток!");
                        break; 
                    }
                    else
                    {
                        Console.WriteLine($"Попытка №: {i + 1}"); // Вывод номера попытки ввода данных
                        Console.WriteLine("Ошибка: Данные не верные!"); // Вывод ошибки

                        Console.Write("Введите логин: ");
                        userName = Console.ReadLine(); 

                        Console.Write("Введите пароль: ");
                        userPassword = Console.ReadLine(); 
                        i++; 
                    }
                }

                else
                {
                    Console.WriteLine("Доступ открыт!");
                    break; // выход из цикла
                }

            } while (true); // вечный цикл



            Console.ReadKey();
            #endregion

            Console.Clear();

            #region(Задача 5 программа, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.)
            Console.WriteLine("Введите свой рост");
            string len = Console.ReadLine();

            Console.WriteLine("Введите свой вес");
            string wgt = Console.ReadLine();

            double m;
            double h;
            double t;


            Console.WriteLine("Привествую,это программа по расчету массы тела");
            m = int.Parse(wgt);
            h = (double)Double.Parse(len) / 100;

            t = m / (h * h);

            if (t <= 16)
            {
                Console.WriteLine($"Результат {t} Дефицит массы тела. Необходимо поправиться.");
                Console.ReadKey();
            }
            else if (t <= 25)
            {
                Console.WriteLine($"Результат {t} Ваш вес в пределах нормы.");
                Console.ReadKey();
            }
            else if (t <= 30)
            {
                Console.WriteLine($"Результат {t} Избыточная масса тела. Нужно худеть.");
                Console.ReadKey();
            }
            else if (t <= 35)
            {
                Console.WriteLine($"Результат {t} Ожирение 1-й степени. Необходимо похудеть.");
                Console.ReadKey();

            }
            else if (t <= 45)
            {
                Console.WriteLine($"Результат {t} Ожирение 2-й степени. Необходимо похудеть.");
                Console.ReadKey();
            }
            else if (t > 45)
            {
                Console.WriteLine($"Результат {t} Ожирение 3-й степени. Немедленно начинайте худеть!");

                Console.ReadKey();
            }









            #endregion


        }
        static bool userChec(string userName, string userPassword)
        {
            if (userName == "root" && userPassword == "GeekBrains") 
            {
                return true;
            }

            return false;                            
        }
        
    }
}
