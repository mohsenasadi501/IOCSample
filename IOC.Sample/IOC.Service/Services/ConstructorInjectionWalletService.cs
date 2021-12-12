using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Service.Services
{
    public class ConstructorInjectionWalletService : IWalletService
    {
        /// <summary>
        /// Constructor Injection
        /// </summary>
        private readonly IWalletRepository _walletRepository;
        public ConstructorInjectionWalletService(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }

        public void DecreaseAmount(double amount) => _walletRepository.DecreaseAmount(amount);
        public double GetBalance() => _walletRepository.GetBalance();
        public void IncreaseAmount(double amount) => _walletRepository.IncreaseAmount(amount);
    }
}
