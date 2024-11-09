using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class BankAccount
    {
        private double balance;

        public BankAccount(double _balance)
        {
            if (_balance < 0)
            {
                throw new ArgumentOutOfRangeException("Счет не может быть инициализирован отрицательным балансом.");
            }
            balance = _balance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Сумма для пополнения должна быть положительной.");
            }
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Сумма для снятия должна быть положительной.");
            }
            if (amount > balance)
            {
                throw new InvalidOperationException("Недостаточно средств для снятия.");
            }
            balance -= amount;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
