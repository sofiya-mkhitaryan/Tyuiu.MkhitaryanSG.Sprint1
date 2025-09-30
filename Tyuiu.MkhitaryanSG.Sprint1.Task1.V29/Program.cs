//Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат
//по формуле a*b*c/(a+b+c) и печатает его на экране.
using Tyuiu.MkhitaryanSG.Sprint1.Task1.V29.Lib;
{
    DataService ds = new DataService();
    Console.Title = "Спринт #1 | Выполнила: Мхитарян С. Г. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #1                                                               *");
    Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                *");
    Console.WriteLine("* Задание #1                                                              *");
    Console.WriteLine("* Вариант #29                                                             *");
    Console.WriteLine("* Выполнила: Мхитарян София Геворковна | РППб-25-1                        *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
    Console.WriteLine("* вычисляет результат по формуле a*b*c/(a+b+c) и печатает его на экране.  *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
    Console.WriteLine("***************************************************************************");

    double x, y, z;

    Console.WriteLine("Введите значение Х:");
    x = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите значение Y:");
    y = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите значение Z:");
    z = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine(ds.Calculate(x, y, z));

    Console.ReadLine();
}
