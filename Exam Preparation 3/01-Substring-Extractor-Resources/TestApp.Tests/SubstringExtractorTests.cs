using System;
using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class SubstringExtractorTests
{
    [Test]
    public void Test_ExtractSubstringBetweenMarkers_SubstringFound_ReturnsExtractedSubstring()
    {
        //Arrange
        string input = "aaa bbb ccc";
        string startMarker = "aaa";
        string endMarker = "ccc";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.That(result, Is.EqualTo(" bbb "));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartMarkerNotFound_ReturnsNotFoundMessage()
    {
        //Arrange
        string input = "aaa bbb ccc";
        string startMarker = "dd";
        string endMarker = "ccc";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EndMarkerNotFound_ReturnsNotFoundMessage()
    {
        //Arrange
        string input = "aaa bbb ccc";
        string startMarker = "aaa";
        string endMarker = "dd";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.That(result, Is.EqualTo("Substring not found"));

    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersNotFound_ReturnsNotFoundMessage()
    {
        //Arrange
        string input = "aaa bbb ccc";
        string startMarker = "ee";
        string endMarker = "dd";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EmptyInput_ReturnsNotFoundMessage()
    {
        //Arrange
        string input = "";
        string startMarker = "dd";
        string endMarker = "ccc";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersOverlapping_ReturnsNotFoundMessage()
    {
        //Arrange
        string input = "eedd";
        string startMarker = "ee";
        string endMarker = "ed";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }
}






//using System;
//using NUnit.Framework;

//namespace TestApp.Tests;

//[TestFixture]
//public class SubstringExtractorTests
//{
//    [Test]
//    public void Test_ExtractSubstringBetweenMarkers_SubstringFound_ReturnsExtractedSubstring()
//    {
//        // Arrange
//        string input = "HelloStefi";
//        string startMarker = "H";
//        string endMarker = "i";
//        string expected = "elloStef";

//        // Act
//        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

//        // Assert
//        Assert.AreEqual(result, expected);
//    }

//    [Test]
//    public void Test_ExtractSubstringBetweenMarkers_StartMarkerNotFound_ReturnsNotFoundMessage()
//    {
//        // Arrange
//        string input = "HelloStefi";
//        string startMarker = "Q";
//        string endMarker = "i";
//        string expected = "Substring not found";

//        // Act
//        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

//        // Assert
//        Assert.AreEqual(result, expected);
//    }

//    [Test]
//    public void Test_ExtractSubstringBetweenMarkers_EndMarkerNotFound_ReturnsNotFoundMessage()
//    {
//        // Arrange
//        string input = "HelloStefi";
//        string startMarker = "H";
//        string endMarker = "B";
//        string expected = "Substring not found";

//        // Act
//        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

//        // Assert
//        Assert.AreEqual(result, expected);
//    }

//    [Test]
//    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersNotFound_ReturnsNotFoundMessage()
//    {
//        // Arrange
//        string input = "HelloStefi";
//        string startMarker = "Q";
//        string endMarker = "B";
//        string expected = "Substring not found";

//        // Act
//        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

//        // Assert
//        Assert.AreEqual(result, expected);
//    }

//    [Test]
//    public void Test_ExtractSubstringBetweenMarkers_EmptyInput_ReturnsNotFoundMessage()
//    {
//        // Arrange
//        string input = string.Empty;
//        string startMarker = "Q";
//        string endMarker = "B";
//        string expected = "Substring not found";

//        // Act
//        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

//        // Assert
//        Assert.AreEqual(result, expected);
//    }

//    [Test]
//    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersOverlapping_ReturnsNotFoundMessage()
//    {
//        // Arrange
//        string input = "Stefi";
//        string startMarker = "t";
//        string endMarker = "t";
//        string expected = "Substring not found";

//        // Act
//        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

//        // Assert
//        Assert.AreEqual(result, expected);
//    }
//}
