using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Facade.Facades
{
    interface IMortgage
    {
        bool IsElegible(decimal amount);
    }
}
