using ATM_MANAGEMENT_SYSTEM.Classes.transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_MANGEMENT_SYSYEM.Classes
{
    class WithdrawTransaction : ITransaction
    {
        private int withdraw;

        public WithdrawTransaction(int withdraw)
        {
            this.withdraw = withdraw;
        }

        public void apply(TransactionType transaction, BankMember member)
        {
            if (member.getBalance() > withdraw)
            {
                member.setBalance(member.getBalance() - withdraw);
                Console.WriteLine("Your withdraw process is done by: " + withdraw);
            }
            else 
            {
                Console.WriteLine("Your budget is not enough for your withdraw");
            }
        }
    }
}
