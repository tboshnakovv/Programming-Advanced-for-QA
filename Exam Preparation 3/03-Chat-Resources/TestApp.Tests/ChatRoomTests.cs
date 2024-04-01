using System;
using NUnit.Framework;
using TestApp.Chat;
namespace TestApp.Tests;

[TestFixture]
public class ChatRoomTests
{
    private ChatRoom _chatRoom = null!;

    [SetUp]
    public void Setup()
    {
        this._chatRoom = new();
    }

    [Test]
    public void Test_SendMessage_MessageSentToChatRoom()
    {
        // Arrange
        string sender = "Todor";
        string message = "Hello, Stefi!";

        // Act
        this._chatRoom.SendMessage(sender, message);
        string result = this._chatRoom.DisplayChat();

        // Assert
        Assert.That(result, Does.Contain("Chat Room Messages:"));
        Assert.That(result, Does.Contain("Todor: Hello, Stefi! - Sent at "));

        //Assert.That(result, Is.EqualTo($"Chat Room Messages:{Environment.NewLine}{sender}: {message} - Sent at 12/14/2023"));
    }

    [Test]
    public void Test_DisplayChat_NoMessages_ReturnsEmptyString()
    {
        // Arrange

        // Act
        string result = this._chatRoom.DisplayChat();

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_DisplayChat_WithMessages_ReturnsFormattedChat()
    {
        // Arrange
        string sender = "Todor";
        // string sender2 = "Stefi";
        string message = "Hello, Stefi!";
        // string message2 = "Hello, Todore!";

        // Act
        this._chatRoom.SendMessage(sender, message);
        // this._chatRoom.SendMessage(sender2, message2);
        string result = this._chatRoom.DisplayChat();

        // Assert
        Assert.That(result, Does.Contain("Chat Room Messages:"));
        Assert.That(result, Does.Contain("Todor: Hello, Stefi! - Sent at "));
        // Assert.That(result, Does.Contain("Stefi: Hello, Todore! - Sent at "));


    }
}
