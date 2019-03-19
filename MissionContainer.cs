using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public delegate double Function(double x);


    public class FunctionsContainer
    {
        private Dictionary<string, Function> funcs = new Dictionary<string, Function>();

        public Function this[string index]
        {
            get
            {
                if (!funcs.ContainsKey(index))
                {
                    funcs.Add(index, val => val);
                }

                return this.funcs[index];
            }
            set
            {
                if (funcs.ContainsKey(index))
                {
                    funcs[index] = value;
                }
                else
                {
                    this.funcs.Add(index, value);
                }
            }
        }

        public List<string> getAllMissions()
        {
            return this.funcs.Keys.ToList();
        }
    }
}
