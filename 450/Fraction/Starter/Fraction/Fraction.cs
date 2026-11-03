using System;
using System.Globalization;

namespace FractionsPourTestUnitaires
{
    /// <summary>
    /// Fraction entière : numérateur et dénominateur, opérations de base.
    /// </summary>
    public class Fraction : IOperationFraction, IComparable<Fraction>
    {
        private int _numerator;
        private int _denominator;

        /// <summary>
        /// Get or Set Numerator
        /// </summary>
        public int Numerator
        {
            get { return _numerator; }
            private set { _numerator = value; }
        }

        /// <summary>
        /// Get or Set Denominator
        /// </summary>
        public int Denominator
        {
            get { return _denominator; }
            private set { _denominator = value; }
        }

        /// <summary>
        /// Contruit une nouvelle fraction de 1/1
        /// </summary>
        public Fraction() : this(1, 1)
        {
        }

        /// <summary>
        /// Construit une novuelle Fraction avec les mêmes Numerator et Denominator de la fraction reçue
        /// </summary>
        /// <param name="f">La fraction à copier.</param>
        public Fraction(Fraction f) : this(f.Numerator, f.Denominator)
        {
        }

        /// <summary>
        /// Construit une nouvelle ffraction avec le numérateur reçu et le Denominator 1
        /// </summary>
        /// <param name="numerator">Le numérateur de la fraction.</param>
        public Fraction(int numerator) : this(numerator, 1)
        {
        }

        /// <summary>
        /// Contruit une nouvelle Fraction avec le Numerator et le Denominator reçus
        /// </summary>
        /// <param name="numerator">Le numérateur de la fraction.</param>
        /// <param name="denominator">Le dénominateur de la fraction.</param>
        /// <exception cref="DivideByZeroException">Lance une exception si le dénominateur est nul.</exception>
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Impossible de créer une fraction avec un dénominateur nul");
            }
            Numerator = numerator;
            Denominator = denominator;
    }

        /// <summary>
        /// Construit une nouvelle Fraction à partir d'un double
        /// </summary>
        /// <param name="f">Le nombre à convertir en fraction.</param>
        public Fraction(double f)
        {
            CreateFractionFromDouble(f);
            Reduce();
        }

        /// <summary>
        /// Calcule le numérateur et le dénominateur à partir d'un double  
        /// </summary>
        /// <param name="f"></param>
        private void CreateFractionFromDouble(double f)
        {
            NumberFormatInfo nfi = CultureInfo.CurrentCulture.NumberFormat;
            string floatString = f.ToString();
            int length = floatString.Substring(floatString.IndexOf(nfi.NumberDecimalSeparator) + 1).Length;
            Numerator = (int)Math.Round(f * length * 10, 0);
            Denominator = length * 10;
        }

        /// <summary>
        /// Retourne la somme de cette fraction et de la fraction reçue.
        /// </summary>
        public Fraction Add(Fraction fr)
        {
            Fraction frAdd = new Fraction(
                    this.Numerator * fr.Denominator - this.Denominator * fr.Numerator,
                    this.Denominator * fr.Denominator
                );

            return frAdd;
        }

        /// <summary>
        /// Trouve et retourne le plus grand commun diviseur de a et b
        /// </summary>
        /// <param name="a">Le premier entier.</param>
        /// <param name="b">Le deuxième entier.</param>
        /// <returns>Le plus grand commun diviseur de a et b.</returns>
        private int FindCD(int a, int b)
        {
            int c = a % b;

            while (c != 0)
            {
                a = b;
                b = c;
                c = a % b;
            }

            return b;
        }

        /// <summary>
        /// Reduit la fraction à sa forme la plus simple en divisant le numérateur 
        /// et le dénominateur par leur plus grand commun diviseur.
        /// </summary>
        private void Reduce()
        {
            int pgcd = FindCD(Numerator, Denominator);
            Numerator /= pgcd;
            Denominator /= pgcd;
            if (Numerator < 0 && Denominator < 0)
            {
                Numerator = Math.Abs(Numerator);
                Denominator = Math.Abs(Denominator);
            }
            else if (Denominator < 0)
            {
                Numerator *= -1;
                Denominator *= -1;
            }
        }

        /// <summary>
        /// Compare cette fraction avec une autre fraction reçue en paramètre
        /// et retourne un entier indiquant si cette fraction est inférieure, égale ou supérieure à l'autre fraction.
        /// </summary>
        /// <param name="other">La fraction à comparer avec cette fraction.</param>
        /// <returns>1 si cette fraction est supérieure, -1 si elle est inférieure, 0 si elles sont égales.</returns>
        public int CompareTo(Fraction other)
        {
            if (Numerator * other.Denominator > other.Numerator * Denominator)
            {
                return 1;
            }
            else if (Numerator * other.Denominator < other.Numerator * Denominator)
            {
                return -1;
            }
            return 0;
        }

        /// <summary>
        /// Retourne le quotient de cette fraction divisée par la fraction reçue.
        /// </summary>
        /// <param name="fr">La fraction par laquelle diviser cette fraction.</param>
        /// <returns>La fraction résultante du quotient.</returns>
        public Fraction Divide(Fraction fr)
        {
            return new Fraction(Numerator * fr.Denominator, Denominator * fr.Numerator);
        }

        /// <summary>
        /// Retourne le produit de cette fraction multipliée par la fraction reçue.
        /// </summary>
        /// <param name="fr">La fraction à multiplier par cette fraction.</param>
        /// <returns>La fraction résultante du produit.</returns>
        public Fraction Multiply(Fraction fr)
        {
            return new Fraction(Numerator * fr.Numerator, Denominator * fr.Denominator);
        }

        /// <summary>
        /// Retourne la différence entre cette fraction et la fraction reçue.
        /// </summary>
        /// <param name="fr">La fraction à soustraire de cette fraction.</param>
        /// <returns>La fraction résultante de la soustraction.</returns>
        public Fraction Substract(Fraction fr)
        {
            return new Fraction(
                    this.Numerator * fr.Denominator - this.Denominator * fr.Numerator,
                    this.Denominator * fr.Denominator
                );
        }

        /// <summary>
        /// Retourne une représentation sous forme de chaîne de caractères de la fraction, 
        /// au format "numérateur/dénominateur".
        /// </summary>
        /// <returns>Une chaîne de caractères représentant la fraction.</returns>
        public override string ToString()
        {
            if (Numerator < 0)
            {
                return $"-{Math.Abs(Numerator)}/{Math.Abs(Denominator)}";
            }
            return $"{Numerator}/{Denominator}";
        }
    }
}
