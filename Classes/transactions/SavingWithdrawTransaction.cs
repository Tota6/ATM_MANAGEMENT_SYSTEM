using ATM_MANGEMENT_SYSYEM.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_MANAGEMENT_SYSTEM.Classes.transactions
{
    class SavingWithdrawTransaction : ITransaction
    {
        long saving;

        public SavingWithdrawTransaction(long saving)
        {
            this.saving = saving;
        }

        public void apply(TransactionType transaction, BankMember member)
        {
            if (member.getSave() >= saving)
            {
                member.setBalance(member.getBalance() + saving);
                member.setSave(member.getSave() - saving);
                Console.WriteLine("Your Saving Withdraw process is done by: " + saving);
            }
            else
            {
                Console.WriteLine("Your save Banlance is not enough ");
            }
        }
    }
}
