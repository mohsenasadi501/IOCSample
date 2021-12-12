using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Service
{
    public interface IWalletRepository
    {
        void IncreaseAmount(double amount);
        void DecreaseAmount(double amount);
        double GetBalance();
    }
}
