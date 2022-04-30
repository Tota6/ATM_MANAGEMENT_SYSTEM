using ATM_MANAGEMENT_SYSTEM.Classes.transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_MANGEMENT_SYSYEM.Classes
{
    class SavingTransaction : ITransaction
    {
        private int saving;

        public  SavingTransaction(int saving)
        {
            this.saving = saving;
        }

        public void apply(TransactionType transaction, BankMember member)
        {
            if (member.getBalance() > saving)
            {
                member.setSave(member.getSave() + saving);
                member.setBalance(member.getBalance() - saving);
                Console.WriteLine("Your saving process is done: " + saving);
            }
            else
            {
                Console.WriteLine("Your balance is not enough ..." );
            }
          
        }
    }
}
