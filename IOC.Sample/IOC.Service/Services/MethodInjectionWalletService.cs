using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Service.Services
{
    public class MethodInjectionWalletService : IWalletService, IWalletServiceDependency
    {
        /// <summary>
        /// Method Injection
        /// </summary>
        IWalletRepository _walletRepository;
        public MethodInjectionWalletService(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }

        public void DecreaseAmount(double amount) => _walletRepository.DecreaseAmount(amount);
        public double GetBalance() => _walletRepository.GetBalance();
        public void IncreaseAmount(double amount) => _walletRepository.IncreaseAmount(amount);
        public void SetDependency(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }
    }
}
