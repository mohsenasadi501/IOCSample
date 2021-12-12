using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Service.Services
{
    public class PropInjectionWalletService : IWalletService
    {
        /// <summary>
        /// Property Injection
        /// </summary>
        public IWalletRepository _walletRepository { get; set; }

        public PropInjectionWalletService()
        {
        }

        public void DecreaseAmount(double amount) => _walletRepository.DecreaseAmount(amount);
        public double GetBalance() => _walletRepository.GetBalance();
        public void IncreaseAmount(double amount) => _walletRepository.IncreaseAmount(amount);
    }
}
