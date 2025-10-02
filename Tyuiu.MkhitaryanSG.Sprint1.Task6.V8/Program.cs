//Написать программу: пользователь вводит текст. Напечатать все слова, перенеся их первую букву в конец.
using Tyuiu.MkhitaryanSG.Sprint1.Task6.V8.Lib;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнила: Мхитарян С. Г. | РППб-25-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #1                                                                 *");
        Console.WriteLine("* Тема: Работа со строками класс String                                     *");
        Console.WriteLine("* Задание #6                                                                *");
        Console.WriteLine("* Вариант #8                                                                *");
        Console.WriteLine("* Выполнила: Мхитарян София Геворковна | РППб-25-1                          *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("* Написать программу: пользователь вводит текст.                            *");
        Console.WriteLine("* Напечатать все слова, перенеся их первую букву в конец.                   *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                           *");
        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();

        DataService ds = new DataService();
        string result = ds.MoveLetterToEnd(input);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(result);
    }
}