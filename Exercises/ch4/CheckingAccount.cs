using System;
namespace eu.sig.training.ch04.v1
{
    public class CheckingAccount : Accounts
    {
        private int transferLimit = 100;

        public Transfer MakeTransfer(String counterAccount, Money amount)
        {
            if (amount.GreaterThan(this.transferLimit))
            {
                throw new BusinessException("Limit exceeded!");
            }
            if (IsValid(counterAccount))
            {
                return GenerateTransferObject(this, counterAccount, amount);
            }
            else
            {
                throw new BusinessException("Invalid account number!");
            }
        }
    }
}