using DP.Composite.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DP.Composite.Composites
{
    class Employee : Employed, IEnumerable<Employed>
    {
        private List<IEmployed> _subordinates = new List<IEmployed>();

        public Employee(string name)
            : base(name)
        {
        }


        public void AddSubordinate(IEmployed subordinate)
        {
            _subordinates.Add(subordinate);
        }

        public void RemoveSubordinate(IEmployed subordinate)
        {
            _subordinates.Remove(subordinate);
        }


        public IEnumerator<Employed> GetEnumerator()
        {
            foreach (Employed subordinate in _subordinates)
            {
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
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
