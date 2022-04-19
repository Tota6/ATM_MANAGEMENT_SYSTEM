using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_MANGEMENT_SYSYEM.Classes
{
    class Loan : Transaction
    {
        private long loan;
        public void loanTransaction(long loan)
        {
            Console.WriteLine("Your loan Process is done ....");
        }
    }
}
