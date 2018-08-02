using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Family.Enum;
using Family.Interfaces;

namespace Family
{
    public class Child : Human, IAbleToWalk
    {
        public Child(string name, Sex sex, byte age) : base(name, sex, age)
        {
        }
        public void Walk(Direct direct)
        {
            ChangeStateInvoke(String.Format("start walking {0} - 3 km/h", direct.ToString()));
        }

        public void StopWalking()
        {
            ChangeStateInvoke("stop walking");
        }
    }
}
