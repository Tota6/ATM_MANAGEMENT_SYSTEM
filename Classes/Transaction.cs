using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_MANGEMENT_SYSYEM.Classes
{
    class Transaction
    {
        private int id;
        private string date;

        public int getId() { return id; }
        public void setId(int id) { this.id = id; }

        public string getDate() { return date; }
        public void setDate(string date) { this.date = date; }

        public void secureTransaction()
        {
            Console.WriteLine("Transaction is secured");
        }
    }
}
