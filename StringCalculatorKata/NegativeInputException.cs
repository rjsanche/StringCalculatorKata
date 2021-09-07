using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class NegativeInputException : Exception
    {
        private string _invalidInput;

        public NegativeInputException(string invalidInput)
        {
            _invalidInput = invalidInput;
        }

        public override string Message => $"negatives not allowed {_invalidInput}";
    }
}
