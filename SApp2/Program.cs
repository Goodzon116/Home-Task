using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region (Методы вывода)
            /*Console.WriteLine("Здравствуйте,это программа анкета");

            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();

            Console.WriteLine("Введите Фамилию");
            string name2 = Console.ReadLine();

            Console.WriteLine("Введите свой возраст");
            string age = Console.ReadLine();

            Console.WriteLine("Введите свой рост");
            string len = Console.ReadLine();

            Console.WriteLine("Введите свой вес");
            string wgt = Console.ReadLine();

            Console.WriteLine("Опрос завершен,благодарю за уделенное время");

            Console.ReadLine();

            //Метод склеивания.
            Console.WriteLine("Ознакомление с результатами  " + name + " " + name2 + " " + age + " " + len + " " + wgt);

            //Метод форматирования
            Console.WriteLine("{0} {1} {2} {3} {4}", name, name2, age, len, wgt);

            //Метод со знаком $
            Console.WriteLine($"результат : {name},{name2},{age},{len},{wgt}");*/


            #endregion

            #region(вывод текста по центру консоли)
            /*Console.WriteLine("Введите имя");
              string na = Console.ReadLine();

              Console.WriteLine("Введите фамилию");
              string fm = Console.ReadLine();

              Console.WriteLine("Введите город проживания");
              string st = Console.ReadLine();

              Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
              Console.WriteLine("{0} {1} {2}", na, fm, st);
              Console.ReadLine();*/
            #endregion

            #region(подсчет количества цифр в числе)
            /*Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Count(number)}");
            Console.ReadKey();
        }

            public static int Count(int a)
        {
            int countNumber = (int)Math.Log10(a) + 1;
            return countNumber;*/
            #endregion

            #region С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.)
            /*int sum = 0;
            int num = 0;

            do
            {
                num = int.Parse(Console.ReadLine());
                if (num > 0 && num % 2 == 1)
                    sum += num;

            }   while (num != 0);

            Console.WriteLine("Sum: " + sum);*/
            #endregion

            #region(проверка пароля и логина)
            /*int i = 1;
            Console.WriteLine($"Попытка №: {i}"); // Вывод номера попытки ввода данных

            Console.Write("Введите логин: ");
            string userName = Console.ReadLine(); // Вводим логин

            Console.Write("Введите пароль: ");
            string userPassword = Console.ReadLine(); // Вводим пароль

            // начинаем цикл do while
                do
            {
                Console.Clear(); // Чистка консоли

                if  (userChec(userName, userPassword) == false) // Проверка логина и пароля
                {
                    if (i > 2) // Лимит попыток
                    {
                        Console.WriteLine("Доступ заблокирован: Превышен лимит попыток!");
                        break; // выход из цикла
                    }
                    else
                    {
                        Console.WriteLine($"Попытка №: {i + 1}"); // Вывод номера попытки ввода данных
                        Console.WriteLine("Ошибка: Данные не верные!"); // Вывод ошибки

                        Console.Write("Введите логин: ");
                        userName = Console.ReadLine(); // Вводим логин

                        Console.Write("Введите пароль: ");
                        userPassword = Console.ReadLine(); // Вводим пароль
                        i++; // операция инкремента
                    }
                }

                else
                {
                    Console.WriteLine("Доступ открыт!");
                    break; // выход из цикла
                }

            } while (true); // вечный цикл



            Console.ReadKey();*/
            #endregion

            #region(программа расчета веса плюс советы)

            /*Console.WriteLine("Введите свой рост");
            string len = Console.ReadLine();

            Console.WriteLine("Введите свой вес");
            string wgt = Console.ReadLine();

            double m;
            double h;
            double i;


            Console.WriteLine("Привествую,это программа по расчету массы тела");
            m = int.Parse(wgt);
            h = (double)Double.Parse(len) / 100;

            i = m / (h * h);

            if (i <= 16 ) 
            {
                Console.WriteLine($"Результат {i} Дефицит массы тела. Необходимо поправиться.");
                Console.ReadKey();
             }
            else if (i <= 25)
            {
                Console.WriteLine($"Результат {i} Ваш вес в пределах нормы.");
                Console.ReadKey();
            }
            else if (i <= 30)
            {
                Console.WriteLine($"Результат {i} Избыточная масса тела. Нужно худеть.");
                Console.ReadKey();
            }
            else if (i <= 35)
            {
                Console.WriteLine($"Результат {i} Ожирение 1-й степени. Необходимо похудеть.");
                Console.ReadKey();

            }
            else if (i <= 45)
            {
                Console.WriteLine($"Результат {i} Ожирение 2-й степени. Необходимо похудеть.");
                Console.ReadKey();
            }
            else if (i > 45)
            {
                Console.WriteLine($"Результат {i} Ожирение 3-й степени. Немедленно начинайте худеть!");
                
                Console.ReadKey();*/
            #endregion

            Complex complex01 = new Complex(3, 2);

            Complex complex02 = new Complex();
            complex02.Re = 0;
            complex02.Im = -2;

            var complex03 = complex01.Plus(complex02);

            Console.WriteLine($"({complex01}) + ({complex02}) = {complex03}");

            Console.ReadKey();


        }
        class Complex
        {

            #region Поля

            /// <summary>
            /// Мнимая часть комплексного числа
            /// </summary>
            private double _im;

            /// <summary>
            /// Действительная часть комплексного числа
            /// </summary>
            private double re;

            #endregion

            #region Свойства

            public double Im
            {
                get { return _im; }
                set
                {
                    if (value == 0)
                        throw new Exception("Мнимая часть комплексного числа не может быть равна нулю.");
                    _im = value;
                }
            }

            public double Re
            {
                get { return re; }
                set { re = value; }
            }

            #endregion

            #region Конструкторы

            public Complex()
            {

            }

            /// <summary>
            /// Конструктор создает новое комплексное число с параметрами
            /// </summary>
            /// <param name="im">Мнимая часть комплексного числа</param>
            /// <param name="re">Действительная часть комплексного числа</param>
            public Complex(double im, double re)
            {
                if (im == 0)
                    throw new Exception("Мнимая часть комплексного числа не может быть равна нулю.");

                _im = im;
                this.re = re;
            }

            #endregion

            #region Публичные методы

            public Complex Plus(Complex x)
            {
                // Пример 1
                Complex y = new Complex(_im + x.Im, re + x.Re);

                // Пример 2
                Complex y1 = new Complex();
                y1.Im = _im + x.Im;
                y1.Re = re + x.Re;

                return y1;
            }

            public override string ToString()
            {
                return $"{re} + {_im}i";
            }
   


        }





























    }





}
      




