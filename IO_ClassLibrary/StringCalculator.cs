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
                string[] input_numbers = number.Split(',');
                int sum = 0;
                foreach(var nr in input_numbers)
                {
                    sum += int.Parse(nr);
                }
                return sum;
            }
        }
    }
}
