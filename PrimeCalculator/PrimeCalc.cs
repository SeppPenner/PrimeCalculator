﻿namespace PrimeCalculator
{
    public class PrimeCalc : IPrimeCalc
    {
        public bool Calc(int n)
        {
            if (n <= 1)
                return false;
            var i = 2;
            var primzahl = true;
            while (i < n - 1 && primzahl)
                if (n % i == 0)
                    primzahl = false;
                else
                    i++;
            return primzahl;
        }
    }
}