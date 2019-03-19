using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        private string name;
        private Function func;
        private double val;

        public SingleMission(Function func, string name)
        {
            this.name = name;
            this.func = func;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public string Type
        {
            get
            {
                return "Single";
            }
        }

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            this.val = this.func(value);
            OnCalculate?.Invoke(this, this.val);
            return this.val;
        }
    }
}
