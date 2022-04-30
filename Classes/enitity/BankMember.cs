using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_MANGEMENT_SYSYEM.Classes
{
    public class BankMember
    {
        private int id;
        private string name;
        private string password;
        private long balance = 0;
        private long save = 0;
        private long loan = 0;
        
        public long getBalance() { return balance; }
        public void setBalance(long balance) { this.balance = balance; }

        public int getId() { return id; }
        public void setId(int id) { this.id = id; }

        public string getName() { return name; }
        public void setName(string name) { this.name = name; }

        public string getPassword() { return password; }
        public void setPassword(string password) { this.password = password; }

        public long getSave() { return save; }
        public void setSave(long save) { this.save = save; }

        public long getLoan() { return loan; }
        public void setLoan(long loan) { this.loan = loan; }
       
        public void processRequest()
        {
            Console.WriteLine("The request Process is done ....");
        }
        public void validateTransaction()
        {
            Console.WriteLine("The Validate transaction is done ....");

        }
    }
}
