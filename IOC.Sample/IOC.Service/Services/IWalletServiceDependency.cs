using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Service.Services
{
    public interface IWalletServiceDependency
    {
        void SetDependency(IWalletRepository walletRepository);
    }
}
