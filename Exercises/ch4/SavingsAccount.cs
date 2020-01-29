using System;

namespace eu.sig.training.ch04.v1
{
    public class SavingsAccount : Accounts
    {
        public CheckingAccount RegisteredCounterAccount { get; set; }

        public Transfer makeTransfer(string counterAccount, Money amount)
        {
            if (IsValid(counterAccount))
            {
                Transfer result = GenerateTransferObject(this, counterAccount, amount);
                if (result.CounterAccount.Equals(this.RegisteredCounterAccount))
                {
                    return result;
                }
                else
                {
                    throw new BusinessException("Counter-account not registered!");
                }
            }
            else
            {
                throw new BusinessException("Invalid account number!!");
            }
        }
    }
}
