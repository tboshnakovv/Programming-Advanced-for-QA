using NUnit.Framework;

using System;
using System.Numerics;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] plants = new string[0];

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.Empty);
    }


    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] plants = new string[]
        {
            "@--\\-"
        };
            

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo("Plants with 5 letters:\r\n@--\\-"));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] plants = new string[]
        {
            "@--\\-",
            "*---",
            "----",
            "*-\\-\\"
        };


        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo("Plants with 4 letters:\r\n*---\r\n----\r\n" +
            "Plants with 5 letters:\r\n@--\\-\r\n*-\\-\\"));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] plants = new string[]
        {
            "rOse",
            "liLy",
            "aBcde",
            "Fdgre"
        };


        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo("Plants with 4 letters:\r\nrOse\r\nliLy\r\n" +
            "Plants with 5 letters:\r\naBcde\r\nFdgre"));
    }
}
