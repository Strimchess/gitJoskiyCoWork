﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Substract(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int? Divide(int x, int y)
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                return null;
            }
        }
    }
}
