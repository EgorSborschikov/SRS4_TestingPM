using System;
using SRS4;
using Xunit;
using Assert = Xunit.Assert;

namespace SRS4Tests;

/// <summary>
/// Тестирование программных модулей
/// </summary>

public class StringTrimmerTests
{
    // Удаление начальных и конечных пробелов
    [Fact]
    public void Trim_LeadingAndTrailingSpaces()
    {
        string result = StringTrimmer.NewStr("   Hello World   ");
        Assert.Equal("Hello World", result);
    }

    // Удаление только начальных пробелов
    [Fact]
    public void Trim_OnlyLeadingSpaces()
    {
        string result = StringTrimmer.NewStr("  HelloWorld");
        Assert.Equal("HelloWorld", result);
    }

    // Удаление только конечных пробелов
    [Fact]
    public void Trim_OnlyTrailingSpaces()
    {
        string result = StringTrimmer.NewStr("HelloWorld  ");
        Assert.Equal("HelloWorld", result);
    }

    // Проверка строки без пробелов
    [Fact]
    public void Trim_NoSpaces()
    {
        string result = StringTrimmer.NewStr("HelloWorld");
        Assert.Equal("HelloWorld", result);
    }

    // Проверка пустой строки
    [Fact]
    public void Trim_EmptyString()
    {
        string result = StringTrimmer.NewStr("");
        Assert.Equal("", result);
    }

    // Проверка обработки строки со значением NULL
    [Fact]
    public void Trim_NullString_ThrowsException()
    {
        Assert.Throws<ArgumentNullException>(() => StringTrimmer.NewStr(null));
    }
}