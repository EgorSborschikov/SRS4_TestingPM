using System;

namespace SRS4;

/// <summary>
/// Запуск последовательности выполнения программных модулей
/// </summary>

public class Program
{
    /// <summary>
    /// Главная точка входа в программу
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        // Вводяться значения строкового типа данных
        Console.WriteLine("Введите строку:");
        string? input = Console.ReadLine();
        
        // Обработка ошибок
        try
        {
            // Если в метод переданы данные строкового типа, то вывести результат в соответствии с методом NewStr класса StringTrimmer
            string result = StringTrimmer.NewStr(input);
            
            // Вывод результата
            Console.WriteLine("Результат: " + result);
        }
        
        // Сообщение об ошибке в иных случаях
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
}