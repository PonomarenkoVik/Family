using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Family.Enum;
using Family.Interfaces;

namespace Family
{
    public class Father : Adult
    {
        public Father(string name, Sex sex, byte age) : base(name, sex, age)
        {
        }

        public override void Work()
        {
            ChangeStateInvoke("start working with performance 100 %");
        }
    }
}
