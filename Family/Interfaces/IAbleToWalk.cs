using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Family.Enum;

namespace Family.Interfaces
{

    public interface IAbleToWalk
    {
        void Walk(Direct direct);
        void StopWalking();

    }
}
