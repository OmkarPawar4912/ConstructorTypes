using CalculatorFn;

namespace CsharpConsole
{
    public static class IntExtensions
    {
        public static int Reminder(this FnClassLibrary fnClassLibrary, int i, int value)
        {
            return (i%value);
        }
    }
}