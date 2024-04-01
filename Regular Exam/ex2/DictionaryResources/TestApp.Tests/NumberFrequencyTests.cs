using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class NumberFrequencyTests
{
    [Test]
    public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
    {
        // Arrange
        int input = 0;

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(input);

        // Assert
        Assert.AreEqual(0, result.Count);
    }

    [Test]
    public void Test_CountDigits_SingleDigitNumber_ReturnsDictionaryWithSingleEntry()
    {
        // Arrange
        int input = 5;


        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(input);
        Dictionary<int, int> expected = new Dictionary<int, int>
        {
            [5] = 1,
        };


        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_CountDigits_MultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int input = 35353532;


        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(input);
        Dictionary<int, int> expected = new Dictionary<int, int>
        {
            [3] = 4,
            [5] = 3,
            [2] = 1,
        };

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_CountDigits_NegativeNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int input = -2323233;


        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(input);
        Dictionary<int, int> expected = new Dictionary<int, int>
        {
            [2] = 3,
            [3] = 4,
        };

        // Assert
        Assert.AreEqual(expected, result);
    }
}
