namespace Services
{
    public static class MathUtil
    {
         /// <summary>
        /// Checks if a number is even.
        /// </summary>
        /// <param name="number">The number to check.</param>
        /// <returns>True if the number is even, otherwise false.</returns>
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        /// <summary>
        /// Checks if a number is prime.
        /// A prime number is a natural number greater than 1 that is not a product of two smaller natural numbers.
        /// </summary>
        /// <param name="number">The number to check.</param>
        /// <returns>True if the number is prime, otherwise false.</returns>
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        
        /// <summary>
        /// Checks if a number is a perfect number.
        /// A perfect number is a positive integer that is equal to the sum of its proper divisors.
        /// </summary>
        /// <param name="number">The number to check.</param>
        /// <returns>True if the number is perfect, otherwise false.</returns>
        public static bool IsPerfect(int number)
        {
            int sum = 1; // 1 is a proper divisor of any number
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum == number;
        }

        /// <summary>
        /// Calculates the sum of the digits of a number.
        /// </summary>
        /// <param name="number">The number whose digits are to be summed.</param>
        /// <returns>The sum of the digits of the number.</returns>
        public static int DigitSum(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        /// <summary>
        /// Checks if a number is an Armstrong number.
        /// An Armstrong number is a number that is equal to the sum of its own digits each raised to the power of the number of digits.
        /// </summary>
        /// <param name="number">The number to check.</param>
        /// <returns>True if the number is an Armstrong number, otherwise false.</returns>
        public static bool IsArmstrong(int number)
        {
            int sum = 0;
            int temp = number;
            int digits = number.ToString().Length;
            while (temp != 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, digits);
                temp /= 10;
            }
            return sum == number;
        }

       
    }
}