namespace Bank;

public class BankAccount
    {
        public const string DebitAmountExceedsBalanceMessage = "Debit amount exceeds balance";
        public const string DebitAmountLessThanZeroMessage = "Debit amount is less than zero";
        private readonly string m_customerName;
        private double m_balance;

        private bool m_frozen = false;
        private int remainingEntryCount = 3;
        private readonly double[] m_passwords;

        private BankAccount() { }

        public BankAccount(string customerName, double balance, double[] passwords)
        {
            m_customerName = customerName;
            m_balance = balance;
            m_passwords = passwords;
        }

        public string CustomerName
        {
            get { return m_customerName; }
        }

        public double Balance
        {
            get { return m_balance; }
        }

        public double[] Passwords
        {
            get { return m_passwords; }
        }

        public void Debit(double amount)
        {
            if (m_frozen)
            {
                throw new Exception("Account frozen");
            }
            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount", amount, DebitAmountExceedsBalanceMessage);
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount", amount, DebitAmountLessThanZeroMessage);
            }

            m_balance -= amount; // Corrected the operation to deduct the amount
        }

        public void Credit(double amount)
        {
            if (m_frozen)
            {
                throw new Exception("Account frozen");
            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount; // Corrected the operation to add the amount
        }

        private void FreezeAccount()
        {
            m_frozen = true;
        }

        private void UnfreezeAccount()
        {
            m_frozen = false;
            remainingEntryCount = 3; // Reset the counter when unfreezing
        }

        public void CheckPassword(double password)
        {
            if (m_passwords.Contains(password))
            {
                remainingEntryCount--;
                if (remainingEntryCount == 0)
                {
                    FreezeAccount();
                }
                else
                {
                    Console.WriteLine($"Incorrect password. You have {remainingEntryCount} attempts left.");
                }
            }
            else
            {
                Console.WriteLine("Password correct. Account unfrozen if it was frozen.");
                UnfreezeAccount(); // Unfreeze the account if the correct password is entered
            }
        }

        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99, new double[3] { 000001, 111111, 222222 });

            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);

            ba.CheckPassword(123456); 
            ba.CheckPassword(654321); 
            ba.CheckPassword(111111); 
            ba.CheckPassword(000001); 
        }
    }