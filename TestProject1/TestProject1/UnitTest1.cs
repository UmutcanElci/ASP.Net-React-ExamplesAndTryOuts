using Bank;

namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        double beginningBalance = 11.99;
        double debitAmount = 4.55;
        double expected = 7.44;
        BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance,new double[] { 000000, 000000, 000000 });

        // Act
        account.Debit(debitAmount);

        // Assert
        double actual = account.Balance;
        Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
    }
    [Test]
    public void Test2()
    {
        double beginningBalance = 10;
        double creditAmount = 4;
        double expected = 14;
        BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance,new double[] { 000000, 000000, 000000 });

        // Act
        account.Credit(creditAmount);

        // Assert
        double actual = account.Balance;
        Assert.AreEqual(expected, actual, 0.001, "Account not credited correctly");
    }
    [Test]
    public void Test3()
    {
      
        double beginningBalance = 10;
        double[] initialPasswords = { 000001, 111111, 222222 };
        BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance, initialPasswords);

      
        account.CheckPassword(123456); 
        account.CheckPassword(654321); 
        account.CheckPassword(789012); 

        
        Assert.Throws<Exception>(() => account.Credit(1), "Account frozen");
        Assert.Throws<Exception>(() => account.Debit(1), "Account frozen");

        
        account.CheckPassword(000000);
        Assert.DoesNotThrow(() => account.Credit(1), "Account should be unfrozen with correct password");
        Assert.DoesNotThrow(() => account.Debit(1), "Account should be unfrozen with correct password");
    }
   
}