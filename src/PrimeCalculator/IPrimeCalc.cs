// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPrimeCalc.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   An interface to calculate whether the given number is prime or not.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PrimeCalculator
{
    /// <summary>
    /// An interface to calculate whether the given number is prime or not.
    /// </summary>
    public interface IPrimeCalc
    {
        /// <summary>
        /// Checks whether the given number is prime or not.
        /// </summary>
        /// <param name="n">The number.</param>
        /// <returns><c>true</c> if the number is prime, <c>false</c> else.</returns>
        bool Calc(int n);
    }
}