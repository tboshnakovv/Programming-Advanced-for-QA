using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    
    [TestCase("ivan_ivanov@softuni.bg")]
    [TestCase("petar.petrov@abv.bg")]
    [TestCase("angel+123@yahoo.com")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    
    [TestCase("invalid mail@valid.domein")]
    [TestCase("valid%mail@in_valid.domain")]
    [TestCase("invalid/mail.invalid.d")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
