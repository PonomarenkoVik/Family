using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    public class StateEventArgs : EventArgs
    {
        public StateEventArgs(string mess)
        {
            Message = mess;
        }

        public string Message { get; private set; }
    }
}
