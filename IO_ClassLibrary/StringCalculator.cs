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
                string[] input_numbers = number.Split(',','\n');
                int sum = 0;
                foreach(var nr in input_numbers)
                {
                    int value = int.Parse(nr);
                    if (value < 0) throw new ArgumentOutOfRangeException();
                    sum += value;
                }
                return sum;
            }
        }
    }
}
