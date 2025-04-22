using System;

namespace SRS4;

/// <summary>
/// Вспомогательный класс обработчика удаления лишниих пробелов
/// </summary>

public class StringTrimmer
{
    /// <summary>
    /// Метод обработки удаления лишних пробелов переданной строке
    /// </summary>
    /// <param name="str"></param>
    /// <returns>
    /// Строка с удаленными пробелами
    /// </returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static string NewStr(string str)
    {
        if (str == null)
        {
            throw new ArgumentNullException(nameof(str));
        }
        return str.Trim();
    }
}