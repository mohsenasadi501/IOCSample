using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Service
{
    public class WalletRepository : IWalletRepository
    {
        private double _balance;
        public double Balance { get => _balance; set => _balance = value; }


        public double GetBalance() => Balance;

        public void DecreaseAmount(double amount) => Balance -= amount;

        public void IncreaseAmount(double amount) => Balance += amount;
    }
}
