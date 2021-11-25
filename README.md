PrimeCalculator and PrimeCalcExample
====================================

PrimeCalculator is a software to to calculate prime numbers.

PrimeCalcExample is a kind of 'library' to calculate prime numbers in C#.

[![Build status](https://ci.appveyor.com/api/projects/status/f171s7bi5k9qwi5x?svg=true)](https://ci.appveyor.com/project/SeppPenner/primecalculator)
[![GitHub issues](https://img.shields.io/github/issues/SeppPenner/PrimeCalculator.svg)](https://github.com/SeppPenner/PrimeCalculator/issues)
[![GitHub forks](https://img.shields.io/github/forks/SeppPenner/PrimeCalculator.svg)](https://github.com/SeppPenner/PrimeCalculator/network)
[![GitHub stars](https://img.shields.io/github/stars/SeppPenner/PrimeCalculator.svg)](https://github.com/SeppPenner/PrimeCalculator/stargazers)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://raw.githubusercontent.com/SeppPenner/PrimeCalculator/master/License.txt)
[![Known Vulnerabilities](https://snyk.io/test/github/SeppPenner/PrimeCalculator/badge.svg)](https://snyk.io/test/github/SeppPenner/PrimeCalculator)


## Basic usage
```csharp
public void Test()
{
    IPrimeCalc calculator = new PrimeCalc();
    bool isPrime = calculator.Calc(7);
}
```

## Screenshot from the executable
![Screenshot from the executable](https://github.com/SeppPenner/PrimeCalculator/blob/master/Screenshot.PNG "Screenshot from the executable")

Change history
--------------

See the [Changelog](https://github.com/SeppPenner/PrimeCalculator/blob/master/Changelog.md).