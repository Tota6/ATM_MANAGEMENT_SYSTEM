using ATM_MANAGEMENT_SYSTEM.Classes.transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_MANGEMENT_SYSYEM.Classes
{
    class LoanTransaction : ITransaction
    {
        private long loan;


        public LoanTransaction(long loan)
        {
            this.loan = loan;
        }

        public void apply(TransactionType transaction, BankMember member)
        {
            if (member.getBalance() <= 10000)
            {
                member.setLoan(member.getLoan() + loan);
                member.setBalance(member.getBalance() + loan);
                Console.WriteLine("Your loan Process is done by: " + loan);
            }
            else
            {
                Console.WriteLine("Your balance is greater than the limited budget ...");
            }
        }

        
         

    }
}
