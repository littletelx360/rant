﻿using Manhood.Compiler;

namespace Manhood.Arithmetic
{
    internal class NumberExpression : Expression
    {
        private readonly double _number;

        public NumberExpression(double number)
        {
            _number = number;
        }

        public double Value
        {
            get { return _number; }
        }

        public override double Evaluate(Source source, Interpreter ii)
        {
            return _number;
        }
    }
}