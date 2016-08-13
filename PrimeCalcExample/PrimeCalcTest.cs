namespace PrimeCalculator
{
    public class PrimeCalcTest
    {
        public void Test()
        {
            IPrimeCalc calculator = new PrimeCalc();
            bool isPrime = calculator.Calc(7);
        }
    }
}