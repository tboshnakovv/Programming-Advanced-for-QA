using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CamelCaseConverterTests
{
    [Test]
    public void Test_ConvertToCamelCase_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string word = "";

        // Act
        string result = CamelCaseConverter.ConvertToCamelCase(word);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ConvertToCamelCase_SingleWord_ReturnsLowercaseWord()
    {
        // Arrange
        string word = "test";

        // Act
        string result = CamelCaseConverter.ConvertToCamelCase(word);

        // Assert
        Assert.That(result, Is.EqualTo("test"));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWords_ReturnsCamelCase()
    {
        // Arrange
        string word = "softuni rocks";

        // Act
        string result = CamelCaseConverter.ConvertToCamelCase(word);

        // Assert
        Assert.That(result, Is.EqualTo("softuniRocks"));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWordsWithMixedCase_ReturnsCamelCase()
    {
        // Arrange
        string word = "SoftUni rocks";

        // Act
        string result = CamelCaseConverter.ConvertToCamelCase(word);

        // Assert
        Assert.That(result, Is.EqualTo("softuniRocks"));
    }
}
