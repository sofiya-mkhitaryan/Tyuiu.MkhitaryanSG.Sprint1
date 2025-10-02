//Написать программу, которая решает следующую задачу:
//Присвоить целой переменной h третью от конца цифру в записи
//положительного целого числа k (например, если k=130985, то h=9).
using Tyuiu.MkhitaryanSG.Sprint1.Task5.V3.Lib;
    class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнила: Мхитарян С. Г. | РППб-25-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #1                                                                 *");
        Console.WriteLine("* Тема: Преобразование типов и класс Convert                                *");
        Console.WriteLine("* Задание #5                                                                *");
        Console.WriteLine("* Вариант #3                                                                *");
        Console.WriteLine("* Выполнила: Мхитарян София Геворковна | РППб-25-1                          *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("* Написать программу, которая решает следующую задачу: Присвоить целой      *");
        Console.WriteLine("* переменной h третью от конца цифру в записи положительного целого числа k *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                           *");
        Console.WriteLine("*****************************************************************************");

        DataService ds = new DataService();

        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out int input))
        {
            int h = ds.Calculate(input);
            if (h == -1)
            {
                Console.WriteLine("Введённое число не соответствует условиям (меньше 3 цифр или не положительное).");
            }
            else
            {
                Console.WriteLine($"Третья цифра с конца: {h}");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введите целое число.");
        }
        Console.ReadKey();
    }
}
