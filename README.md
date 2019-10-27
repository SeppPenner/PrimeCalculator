PrimeCalculator and PrimeCalcExample
====================================

PrimeCalculator is a software to to calculate prime numbers.

PrimeCalcExample is a kind of 'library' to calculate prime numbers in C#.

Both were written and tested in .Net 4.8.

[![Build status](https://ci.appveyor.com/api/projects/status/f171s7bi5k9qwi5x?svg=true)](https://ci.appveyor.com/project/SeppPenner/primecalculator)
[![GitHub issues](https://img.shields.io/github/issues/SeppPenner/PrimeCalculator.svg)](https://github.com/SeppPenner/PrimeCalculator/issues)
[![GitHub forks](https://img.shields.io/github/forks/SeppPenner/PrimeCalculator.svg)](https://github.com/SeppPenner/PrimeCalculator/network)
[![GitHub stars](https://img.shields.io/github/stars/SeppPenner/PrimeCalculator.svg)](https://github.com/SeppPenner/PrimeCalculator/stargazers)
[![GitHub license](https://img.shields.io/badge/license-AGPL-blue.svg)](https://raw.githubusercontent.com/SeppPenner/PrimeCalculator/master/License.txt)
[![Known Vulnerabilities](https://snyk.io/test/github/SeppPenner/PrimeCalculator/badge.svg)](https://snyk.io/test/github/SeppPenner/PrimeCalculator)


## Basic usage:
```csharp
public void Test()
{
    IPrimeCalc calculator = new PrimeCalc();
    bool isPrime = calculator.Calc(7);
}
```

## Screenshot from the executable:
![Screenshot from the executable](https://github.com/SeppPenner/PrimeCalculator/blob/master/Screenshot.PNG "Screenshot from the executable")

Change history
--------------

* **Version 1.0.1.0 (2019-10-27)** : Updated nuget packages, added GitVersionTask.
* **Version 1.0.0.4 (2019-05-06)** : Updated .Net version to 4.8.
* **Version 1.0.0.3 (2017-03-24)** : Updated Languages.dll to version 1.0.0.4.
* **Version 1.0.0.2 (2017-03-21)** : Updated Languages.dll.
* **Version 1.0.0.1 (2017-03-11)** : Refactored code, switched to .Net 4.6.2.
* **Version 1.0.0.0 (2016-12-03)** : Added basic usage to Readme.
* **Version 1.0.0.0 (2016-08-13)** : 1.0 release.
