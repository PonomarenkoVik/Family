using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Family.Enum;
using Family.Interfaces;

namespace Family
{
    public class Mother : Adult
    {
        public Mother(string name, Sex sex, byte age) : base(name, sex, age)
        {
        }

        public override void Walk(Direct direct)
        {
            ChangeStateInvoke(String.Format("start walking {0} - 4 km/h", direct.ToString()));
        }

        public override void Work()
        {
            ChangeStateInvoke("start working with performance 80 %");
        }
    }
}
