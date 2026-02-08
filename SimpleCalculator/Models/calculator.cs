using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleCalculator.Models
{
    public class calculator
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public string Operation { get; set; }
        public double Result { get; set; }
    }
}