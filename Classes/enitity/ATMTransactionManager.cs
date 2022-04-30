using ATM_MANAGEMENT_SYSTEM.Classes.transactions;

namespace ATM_MANGEMENT_SYSYEM.Classes
{
    public abstract class ATMTransactionManager
    {
        public abstract void applyTransaction(ITransaction transaction, BankMember member);
    }
}