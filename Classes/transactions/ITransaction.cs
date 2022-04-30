using ATM_MANGEMENT_SYSYEM.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_MANAGEMENT_SYSTEM.Classes.transactions
{
    public interface ITransaction 
    {
        public void apply(TransactionType transaction, BankMember member);
    }
}
