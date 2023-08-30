namespace Exercise_4
{
    class Fraction
    {
        private int numerator;
        private int denominator;

        public int Numerator
        {
            get { return numerator; }
            set { this.numerator = value; }
        }

        public int Denominator
        {
            get { return denominator; }
            set { this.denominator = value; }
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        private void Normalize()
        {
            int commonDivisor = GCD(numerator, denominator);
            this.numerator /= commonDivisor;
            this.denominator /= commonDivisor;
        }


        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero");
            }
            this.numerator = numerator;
            this.denominator = denominator;
            Normalize();
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            int newNumerator = a.Numerator * b.Denominator + a.Denominator * b.Numerator;
            int newDenominator = a.Denominator * b.Denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            int newNumerator = a.Numerator * b.Denominator - a.Denominator * b.Numerator;
            int newDenominator = a.Denominator * b.Denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            int newNumerator = a.Numerator * b.Numerator;
            int newDenominator = a.Denominator * b.Denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.numerator == 0)
            {
                throw new ArgumentException("Cannot divide by zero");
            }

            int newNumerator = a.numerator * b.denominator;
            int newDenominator = a.denominator * b.numerator;
            return new Fraction(newNumerator, newDenominator);
        }

        public double ToDecimal()
        {
            return (double)numerator / denominator;
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }
    }
}