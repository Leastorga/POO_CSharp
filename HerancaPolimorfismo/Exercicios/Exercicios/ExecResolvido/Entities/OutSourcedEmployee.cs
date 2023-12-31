using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ExecResolvido.Entities
{
    public class OutSourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }
        public OutSourcedEmployee()
        {
        }

        public OutSourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + AdditionalCharge * 1.1;

        }

    }
}