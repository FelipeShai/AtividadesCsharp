using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso.AccountProject
{
    public class SavingsAccount : Account
    {
        public double InterestRate;

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
