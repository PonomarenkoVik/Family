using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Family.Interfaces;

namespace Family
{
    public delegate void State(object sender, StateEventArgs args);
    public abstract class Human
    {
        protected Human(string name, Sex sex, byte age)
        {
            Name = name;
            PersonSex = sex;
            Age = age;
        }
        public  string Name { get; set; }
        public  Sex PersonSex { get; set; } 
        public  byte Age { get; set; }

        public event State ChangeState;


        protected virtual void ChangeStateInvoke(string mess)
        {
            if (ChangeState != null)
            {
                string message = String.Format("State of {0} just has changed : {1}", Name, mess);
                ChangeState(this, new StateEventArgs(message));
            }
        }
        // Association
        //public Father Father { get; private set; }
        //public Mother Mother { get; private set; }

    }
}
