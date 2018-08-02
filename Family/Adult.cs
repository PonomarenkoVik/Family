using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Family.Enum;
using Family.Interfaces;

namespace Family
{
    public abstract class Adult : Human, IAbleToWalk, IEmployable
    {
        protected Adult(string name, Sex sex, byte age) : base(name, sex, age)
        {
        }

        public virtual void Walk(Direct direct)
        {
            ChangeStateInvoke(String.Format("start walking {0} - 5 km/h", direct.ToString()));
        }

        public virtual void StopWalking()
        {
            ChangeStateInvoke("stop walking");
        }

        public virtual void Work()
        {
            ChangeStateInvoke("start working");
        }

        public virtual void StopWorking()
        {
            ChangeStateInvoke("stop working");
        }
    }
}
