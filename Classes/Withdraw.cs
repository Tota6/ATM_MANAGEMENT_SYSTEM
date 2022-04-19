using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_MANGEMENT_SYSYEM.Classes
{
    class Withdraw : Transaction
    {
        private long withdrawing;
        public void withdrawTransaction(int withdrawing)
        {
            Console.WriteLine("The withdraw process is done .... ");
        }
    }
}
