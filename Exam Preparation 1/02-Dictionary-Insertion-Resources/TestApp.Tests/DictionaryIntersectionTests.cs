using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> firtsDictionary = new();
        Dictionary<string, int> secondDictionary = new();

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(firtsDictionary, secondDictionary);

        // Assert
        Assert.AreEqual(0, result.Count);
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> firtsDictionary = new()
        {
            {"one", 1},
            {"two", 2},
        };
        Dictionary<string, int> secondDictionary = new();

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(firtsDictionary, secondDictionary);

        // Assert
        Assert.AreEqual(0, result.Count);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> firstDictionary = new()
        {
            { "one", 1},
            { "two", 2},
        };
        Dictionary<string, int> secondDictionary = new()
        {
            {"three", 3},
            {"four", 4},
        };

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictionary, secondDictionary);

        // Assert
        Assert.AreEqual(0, result.Count);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        // Arrange
        Dictionary<string, int> firstDictionary = new()
        {
            { "one", 1 },
            { "two", 2 },
        };
        Dictionary<string, int> secondDictionary = new()
        {
            { "one", 1 },
            { "two", 2 },
            { "four", 4 },
        };

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictionary, secondDictionary);

        // Assert
        Assert.AreEqual(2, result.Count);
        Assert.IsTrue(result.ContainsKey("one"));
        Assert.IsTrue(result.ContainsKey("two"));
        Assert.IsFalse(result.ContainsKey("four"));
        
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        // Arrange
        // Arrange
        Dictionary<string, int> firstDictionary = new()
        {
            { "one", 1 },
            { "two", 2 },
        };
        Dictionary<string, int> secondDictionary = new()
        {
            { "one", 10 },
            { "two", 20 },
            
        };

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictionary, secondDictionary);



        // Assert
        Assert.AreEqual(0, result.Count);
    }
}
