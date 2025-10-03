using Tyuiu.MkhitaryanSG.Sprint1.Task7.V14.Lib;
//Написать программу, которая вычисляет математическое выражение по исходным значениям данных, вводимых пользователем.
//Ответ округлите до 3 знаков после запятой.
//z = 2^-x + 5x^2/3x^3 - cosx^2 +sin(2xy)
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнила: Мхитарян С. Г. | РППб-25-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #1                                                                 *");
        Console.WriteLine("* Тема: Работа со строками класс String                                     *");
        Console.WriteLine("* Задание #7                                                                *");
        Console.WriteLine("* Вариант #14                                                               *");
        Console.WriteLine("* Выполнила: Мхитарян София Геворковна | РППб-25-1                          *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение            *");
        Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                     *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                           *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* z = 2^-x + 5x^2/3x^3 - cosx^2 +sin(2xy)                                   *");
        double x, y;
        Console.WriteLine("Введите значение Х:");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение Y:");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        DataService ds = new DataService();
        Console.WriteLine(ds.Calculate(x, y));
        Console.ReadLine();
    }
}
    