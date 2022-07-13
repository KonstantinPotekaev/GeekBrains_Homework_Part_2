namespace Lesson_5;

public class Rational_number
{
    public int _numerator, _denominator;
    public Rational_number(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public static bool operator ==(Rational_number a, Rational_number b)
    {
        return Equals(a._numerator/a._denominator, b._numerator/b._denominator); 
    }
    public static bool operator !=(Rational_number a, Rational_number b)
    {
        return !Equals(a._numerator / a._denominator, b._numerator / b._denominator);
    }

}
