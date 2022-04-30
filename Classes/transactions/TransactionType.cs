using ATM_MANGEMENT_SYSYEM.Classes;
using System;

namespace ATM_MANAGEMENT_SYSTEM.Classes.transactions
{
    public class TransactionType : ATMTransactionManager
    {
        public override void applyTransaction(ITransaction transaction, BankMember member)
        {
            transaction.apply(this, member);
        }
      
    }
}