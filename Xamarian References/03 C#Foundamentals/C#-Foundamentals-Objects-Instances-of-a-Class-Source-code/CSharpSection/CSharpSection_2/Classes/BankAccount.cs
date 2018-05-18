using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSection_2.Classes
{
    public class BankAccount
    {
        private float balance;
        private string owner;

        public BankAccount(float balance, string owner)
        {
            this.balance = balance;
            this.owner = owner;
        }

        public float AddBalance(float blanaceToBeAdded)
        {
            return balance + blanaceToBeAdded;
        }
    }
}
