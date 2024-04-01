using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CsvParserTests
{
    [Test]
    public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
    {
        // Arrange
        string input = "";  // В Арейндж се подготвят входните данни

        // Act
        string[] result = CsvParser.ParseCsv(input);  // В акт-а изпълнявам командата която ще проверявам
        // string[] expected = { };

        // Assert
        Assert.That(result, Is.Empty);  //В асърт проверявам дали това, което е изпълнено отговаря на това, което очакваме
        // Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
    {
        // Arrange
        string input = "hello";

        // Act
        string[] result = CsvParser.ParseCsv(input);
        string[] expected = { "hello" };

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
    {
        // Arrange
        string input = "hello,how,are,you";

        // Act
        string[] result = CsvParser.ParseCsv(input);
        string[] expected = { "hello", "how", "are", "you" };

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
    {
        // Arrange
        string input = "      hello,  how,   are,     you";

        // Act
        string[] result = CsvParser.ParseCsv(input);
        string[] expected = { "hello", "how", "are", "you" };

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
