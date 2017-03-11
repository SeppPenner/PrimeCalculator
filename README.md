PrimeCalculator and PrimeCalcExample
====================================

PrimeCalculator is a software to to calculate prime numbers.

PrimeCalcExample is a kind of 'library' to calculate prime numbers in C#.

Both were writted and tested in .Net 4.6.2.

[![Build status](https://ci.appveyor.com/api/projects/status/f171s7bi5k9qwi5x?svg=true)](https://ci.appveyor.com/project/SeppPenner/primecalculator)


## Basic usage:
```csharp
public void Test()
{
    IPrimeCalc calculator = new PrimeCalc();
    bool isPrime = calculator.Calc(7);
}
```

Change history
--------------

* **Version 1.0.0.1 (2017-03-11)** : Refactored code, switched to .Net 4.6.2.
* **Version 1.0.0.0 (2016-12-03)** : Added basic usage to Readme.
* **Version 1.0.0.0 (2016-08-13)** : 1.0 release.
