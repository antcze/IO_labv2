using System;

namespace IO_ClassLibrary
{
    public class StringCalculator
    {
        public int Add(string number)
        {
            if (number.Length == 0) return 0;
            else
            {
                return Int32.Parse(number);
            }
            return 0;
        }
    }
}
