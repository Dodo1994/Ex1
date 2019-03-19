using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        private string name;
        private List<Function> allFuncs;

        public event EventHandler<double> OnCalculate;

        public ComposedMission(string name)
        {
            this.name = name;
            this.allFuncs = new List<Function>();
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Type
        {
            get
            {
                return "Composed";
            }
        }

        public double Calculate(double value)
        {
            foreach (var function in this.allFuncs)
            {
                value = function(value);
            }
            OnCalculate?.Invoke(this, value);
            return value;
        }

        public ComposedMission Add(Function func)
        {
            this.allFuncs.Add(func);
            return this;
        }
    }
}
