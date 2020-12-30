// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeCalc.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   A class to calculate whether the given number is prime or not.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PrimeCalculator
{
    /// <inheritdoc cref="IPrimeCalc"/>
    /// <summary>
    /// A class to calculate whether the given number is prime or not.
    /// </summary>
    /// <seealso cref="IPrimeCalc"/>
    public class PrimeCalc : IPrimeCalc
    {
        /// <inheritdoc cref="IPrimeCalc"/>
        /// <summary>
        /// Checks whether the given number is prime or not.
        /// </summary>
        /// <param name="n">The number.</param>
        /// <returns><c>true</c> if the number is prime, <c>false</c> else.</returns>
        /// <seealso cref="IPrimeCalc"/>
        public bool Calc(int n)
        {
            if (n <= 1)
            {
                return false;
            }

            var i = 2;
            var isPrime = true;

            while (i < n - 1 && isPrime)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }
                else
                {
                    i++;
                }
            }

            return isPrime;
        }
    }
}