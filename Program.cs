using System;
using ATM_MANAGEMENT_SYSTEM.Classes.transactions;
using ATM_MANGEMENT_SYSYEM.Classes;

namespace ATM_MANGEMENT_SYSYEM
{
    class Program
    {
        static void Main(string[] args)
        {
            BankMember member = new BankMember();
            member.setId(1);
            member.setName("Tina");

            ATMMachine atm = new ATMMachine();
            atm.setId(1);
            atm.setCode(12202);
            atm.setLocation("zamalek");

            atm.setBankMember(member);

            atm.applyTransaction(new WithdrawTransaction(5000));
            Console.WriteLine("Balance: " + atm.getBankMember().getBalance());

            atm.applyTransaction(new CreditTransaction(9000));
            Console.WriteLine("Balance: " + atm.getBankMember().getBalance());

            atm.applyTransaction(new WithdrawTransaction(5000));
            Console.WriteLine("Balance: " + atm.getBankMember().getBalance());

            atm.applyTransaction(new LoanTransaction(1000));
            Console.WriteLine("Loan: " + atm.getBankMember().getLoan());
            Console.WriteLine("Balance: " + atm.getBankMember().getBalance());

            atm.applyTransaction(new SavingTransaction(2000));
            Console.WriteLine("Saving: " + atm.getBankMember().getSave());
            Console.WriteLine("Balance: " + atm.getBankMember().getBalance());

            atm.applyTransaction(new LoanCreditTransaction(1000));
            Console.WriteLine("Balance: " + atm.getBankMember().getBalance());
            Console.WriteLine("loan: " + atm.getBankMember().getLoan());

            atm.applyTransaction(new SavingWithdrawTransaction(2000));
            Console.WriteLine("Balance:" + atm.getBankMember().getBalance());
            Console.WriteLine("Saving: " + atm.getBankMember().getSave());





        }
    }
}
