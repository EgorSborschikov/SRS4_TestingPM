using System;

namespace SRS4;

public class StringTrimmer
{
    public static string NewStr(string str)
    {
        if (str == null)
        {
            throw new ArgumentNullException(nameof(str));
        }
        return str.Trim();
    }
}