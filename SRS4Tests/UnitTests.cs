using System;
using SRS4;
using Xunit;
using Assert = Xunit.Assert;

namespace SRS4Tests
{
    public class StringTrimmerTests
    {
        [Fact]
        public void Trim_LeadingAndTrailingSpaces()
        {
            string result = StringTrimmer.NewStr("   Hello World   ");
            Assert.Equal("Hello World", result);
        }

        [Fact]
        public void Trim_OnlyLeadingSpaces()
        {
            string result = StringTrimmer.NewStr("  HelloWorld");
            Assert.Equal("HelloWorld", result);
        }

        [Fact]
        public void Trim_OnlyTrailingSpaces()
        {
            string result = StringTrimmer.NewStr("HelloWorld  ");
            Assert.Equal("HelloWorld", result);
        }

        [Fact]
        public void Trim_NoSpaces()
        {
            string result = StringTrimmer.NewStr("HelloWorld");
            Assert.Equal("HelloWorld", result);
        }

        [Fact]
        public void Trim_EmptyString()
        {
            string result = StringTrimmer.NewStr("");
            Assert.Equal("", result);
        }

        [Fact]
        public void Trim_NullString_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => StringTrimmer.NewStr(null));
        }
    }
}