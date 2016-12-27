using DP.Composite.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Composite.Composites
{
    class Employee : Employed
    {
        private List<IEmployed> _subordinates = new List<IEmployed>();

        public Employee(string name)
            : base(name)
        {
        }


        public override void AddSubordinate(IEmployed subordinate)
        {
            _subordinates.Add(subordinate);
        }

        public override void RemoveSubordinate(IEmployed subordinate)
        {
            _subordinates.Remove(subordinate);
        }

        public override void Display(int indentation)
        {
            base.Display(indentation);

            foreach (var subordinate in _subordinates)
            {
                subordinate.Display(indentation + 2);
            }
        }
    }
}
