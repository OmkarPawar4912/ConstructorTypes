using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpConsole
{
    public static class IntExtensions
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
}