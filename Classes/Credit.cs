using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_MANGEMENT_SYSYEM.Classes
{
    class Credit : Transaction
    {
        private long credit;
        public void creditTransaction(long credit)
        {
            Console.WriteLine("Your credit process is done ....");
        }
    }
}
