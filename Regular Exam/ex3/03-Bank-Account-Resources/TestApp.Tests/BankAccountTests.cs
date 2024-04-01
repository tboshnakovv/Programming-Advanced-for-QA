using NUnit.Framework;
using System;

namespace TestApp.Tests;

[TestFixture]
public class BankAccountTests
{
    [Test]
    public void Test_Constructor_InitialBalanceIsSet()
    {
        // Arrange
        double initialAmount = 100.00;
        BankAccount bankAccount = new(initialAmount);

        // Act
        double result = bankAccount.Balance;

        // Assert
        Assert.AreEqual(100.00, result);
    }

    [Test]
    public void Test_Deposit_PositiveAmount_IncreasesBalance()
    {
        // Arrange
        double initialAmount = 100.00;
        BankAccount bankAccount = new(initialAmount);
        double deposit = 50.00;
        double expected = initialAmount + deposit;

        // Act
        bankAccount.Deposit(deposit);
        double result = bankAccount.Balance;

        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_Deposit_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        double initialAmount = 100.00;
        BankAccount bankAccount = new(initialAmount);
        double deposit = -50.00;

        // Act and Assert
        Assert.Throws<ArgumentException>(() => bankAccount.Deposit(deposit), "Deposit amount must be greater than zero.");
    }

    [Test]
    public void Test_Withdraw_ValidAmount_DecreasesBalance()
    {
        // Arrange
        double initialAmount = 100.00;
        BankAccount bankAccount = new(initialAmount);
        double withdraw = 50.00;
        double expected = initialAmount - withdraw;

        // Act
        bankAccount.Withdraw(withdraw);
        double result = bankAccount.Balance;

        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_Withdraw_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        double initialAmount = 100.00;
        BankAccount bankAccount = new(initialAmount);
        double withdraw = -50.00;

        // Act and Assert
        Assert.Throws<ArgumentException>(() => bankAccount.Withdraw(withdraw), "Invalid withdrawal amount.");
    }

    [Test]
    public void Test_Withdraw_AmountGreaterThanBalance_ThrowsArgumentException()
    {
        // Arrange
        double initialAmount = 100.00;
        BankAccount bankAccount = new(initialAmount);
        double withdraw = 150.00;

        // Act and Assert
        Assert.Throws<ArgumentException>(() => bankAccount.Withdraw(withdraw), "Invalid withdrawal amount.");
    }
}
