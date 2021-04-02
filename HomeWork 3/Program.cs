using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3 (Исполнитель Илья Владимиров)
{
    class Program
    {
        static void Main(string[] args)
        {
            #region(1 Задание)
            // Много много структорок
            Complex a1 = new Complex(5, 5);
            Complex a2 = new Complex(2, 2);
            // в данный комплекс мы добовляем значения после вычитания из a1 и a2;
            Complex a3 = a1.Minus(a2);
            Complex a4 = a1.Multi(a2);

            // Просто выводим данные из a1 и a2
            Console.WriteLine(a1.ToString());
            Console.WriteLine(a2.ToString());

            // Задание 1.а: Выводим на экран разность при вычитании a2 из a1:
            Console.WriteLine(a3.ToString());
            // Задание 1.б:
            Console.WriteLine(a4.ToString());

            // Всё как обычно :D
            Console.ReadKey();
            #endregion
            #region(Задание 2)
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
        }
           // Комлекс
        struct Complex
        {
            // Инкапсуляция:
            double im;
            double re;

            public Complex(double IM, double RE)
            {
                this.im = IM;
                this.re = RE;
            }

            // Метод сложения
            public Complex Plus(Complex comp)
            {
                Complex param;
                param.im = this.im + comp.im;
                param.re = this.re + comp.re;
                return param;
            }

            // Домашнее задание 1.а: Метод вычитания комлексного числа.
            public Complex Minus(Complex comp)
            {
                Complex param;
                param.im = this.im - comp.im;
                param.re = this.re - comp.re;
                return param;
            }

            // Задание 1.б:
            // загуглил как писать формулу умножения комплексных чисел:
            // формулу брал тут: http://www.webmath.ru/poleznoe/formules_16_9.php
            public Complex Multi(Complex comp)
            {
                Complex param;
                param.im = this.re * comp.im + this.im * comp.re;
                param.re = this.re * comp.re - this.im * comp.im;
                return param;
            }

            // Возвращаем строчку для вывода:
            public string  ToString()
            {
                return $"{re} + {im}i";
            }
        }
    }


        
    


    










