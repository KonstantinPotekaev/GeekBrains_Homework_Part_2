﻿namespace Lesson_5;

public class Rational_number
{
    public int _numerator, _denominator;
    public Rational_number(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public static bool operator == (Rational_number a, Rational_number b)
    {
        return Equals((double)a._numerator/a._denominator, (double)b._numerator/b._denominator); 
    }
    public static bool operator != (Rational_number a, Rational_number b)
    {
        return !Equals((double)a._numerator / a._denominator, (double)b._numerator / b._denominator);
    }

    public static bool operator < (Rational_number a, Rational_number b)
    {
        return (double)a._numerator / a._denominator < (double)b._numerator / b._denominator;
    }
    public static bool operator > (Rational_number a, Rational_number b)
    {
        return (double)a._numerator / a._denominator > (double)b._numerator / b._denominator;
    }

    public static bool operator <=(Rational_number a, Rational_number b)
    {
        return (double)a._numerator / a._denominator <= (double)b._numerator / b._denominator;
    }
    public static bool operator >=(Rational_number a, Rational_number b)
    {
        return (double)a._numerator / a._denominator >= (double)b._numerator / b._denominator;
    }

    public static Rational_number operator +(Rational_number a, int b)
    {
        Rational_number b1 = (Rational_number)b;
        b1._numerator *= a._denominator;
        b1._denominator *= a._denominator;
        return new Rational_number(a._numerator + b1._numerator, a._denominator);
    }
    public static Rational_number operator +(Rational_number a, double b)
    {
        Rational_number b1 = (Rational_number)b;
        var a1 = a;
        if (a1._numerator == b1._numerator)
        {
            return new Rational_number(a1._numerator * 2, a1._denominator);
        }
        int denominator = b1._denominator;
        b1._numerator *= a._denominator;
        b1._denominator *= a._denominator;
        a1._numerator *= denominator;
        a1._denominator *= denominator;
        return new Rational_number(a1._numerator + b1._numerator, a1._denominator);
    }
    public static Rational_number operator +(Rational_number a, Rational_number b)
    {
        var a1 = a;
        var b1 = b;
        if (a1._numerator == b1._numerator)
        {
            return new Rational_number(a._numerator * 2, a._denominator);
        }
        int denominator = b1._denominator;
        b1._numerator *= a1._denominator;
        b1._denominator *= a1._denominator;
        a1._numerator *= denominator;
        a1._denominator *= denominator;
        return new Rational_number(a1._numerator + b1._numerator, a1._denominator);
    }


    public static Rational_number operator -(Rational_number a, int b)
    {
        Rational_number b1 = (Rational_number)b;
        var a1 = a;
        b1._numerator *= a1._denominator;
        b1._denominator *= a1._denominator;
        return new Rational_number(a1._numerator - b1._numerator, a1._denominator);
    }
    public static Rational_number operator -(Rational_number a, double b)
    {
        var b1 = (Rational_number)b;
        var a1 = a;
        int denominator = b1._denominator;
        b1._numerator *= a1._denominator;
        b1._denominator *= a1._denominator;
        a1._numerator *= denominator;
        a1._denominator *= denominator;
        return new Rational_number(a1._numerator - b1._numerator, a1._denominator);
    }
    public static Rational_number operator -(Rational_number a, Rational_number b)
    {
        var a1 = a;
        var b1 = b;
        int denominator = b1._denominator;
        b1._numerator *= a1._denominator;
        b1._denominator *= a1._denominator;
        a1._numerator *= denominator;
        a1._denominator *= denominator;
        return new Rational_number(a1._numerator - b1._numerator, a1._denominator);
    }

    public static Rational_number operator ++(Rational_number a)
    {
        a._numerator += a._denominator;
        return a;
    }
    public static Rational_number operator --(Rational_number a)
    {
        a._numerator -= a._denominator;
        return a;
    }

    public override string ToString()
    {
        string a = _numerator.ToString();
        string b = _denominator.ToString();
        if (_numerator == 0)
        {
            return "0\n\n";
        }
        return ($"{a}\n―\n{b}\n\n");
    }


    public static explicit operator Rational_number(int a)
    {
        return new Rational_number(a, 1);
    }
    public static explicit operator Rational_number(double a)
    {
        if ((int)a == 0)
        {
            string num = a.ToString();
            num = num.Remove(0, 2);
            int den = Convert.ToInt32(Math.Pow(10, num.Count()));

            return new Rational_number(int.Parse(num), den);
        }
        else
        {
            int k = (int)a;
            string num = a.ToString();
            num = num.Remove(0, 2);
            int den = Convert.ToInt32(Math.Pow(10, num.Count()));
            
            return new Rational_number((int)(k*den)+int.Parse(num), den);
        }
    }


    
}