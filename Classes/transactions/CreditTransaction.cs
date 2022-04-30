using ATM_MANAGEMENT_SYSTEM.Classes.transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_MANGEMENT_SYSYEM.Classes
{
    class CreditTransaction : ITransaction
    {
        private long credit;

        public CreditTransaction(long credit)
        {
            this.credit = credit;
        }

        public void apply(TransactionType transaction, BankMember member)
        {
            if(credit >= 0)
            {
                member.setBalance(member.getBalance() + credit);
                Console.WriteLine("Your credit process is done by: " + credit);
            }
            else
            {
                Console.WriteLine("Your credit is less than zero ...");
            }
         
        }

    }
}
