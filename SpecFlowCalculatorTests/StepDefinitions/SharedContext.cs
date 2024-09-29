using Lab1_SetupUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    public class SharedContext
    {
        public Calculator Calculator { get; set; } = new Calculator();
        public double Result { get; set; }
        public string ExceptionMessage { get; set; }
    }
}
