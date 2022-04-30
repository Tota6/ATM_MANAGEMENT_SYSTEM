using ATM_MANGEMENT_SYSYEM.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_MANAGEMENT_SYSTEM.Classes.transactions
{
    class LoanCreditTransaction : ITransaction
    {
        private long loanPayment;

        public LoanCreditTransaction(long loanPayment)
        {
            this.loanPayment = loanPayment;
        }

        public void apply(TransactionType transaction, BankMember member)
        {
            if (member.getBalance() > loanPayment)
            {
                member.setLoan(member.getLoan() - loanPayment);
                member.setBalance(member.getBalance() - loanPayment);
                Console.WriteLine("Your loan is paid by: " + loanPayment);
            }
            else
            {
                Console.WriteLine("Your balance is not enought to payback your loan " + loanPayment);
            }

        }
    }
}
