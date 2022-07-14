namespace Lesson_5;

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

    

    public static Rational_number operator *(Rational_number a, int b)
    {
        return new Rational_number(a._numerator * b, a._denominator * 1);
    }
    public static Rational_number operator *(Rational_number a, double b)
    {
        return new Rational_number(a._numerator * ((Rational_number)b)._numerator, a._denominator * ((Rational_number)b)._denominator);
    }
    public static Rational_number operator *(Rational_number a, Rational_number b)
    {
        return new Rational_number(a._numerator * b._numerator, a._denominator * b._denominator);
    }


    public static Rational_number operator /(Rational_number a, int b)
    {
        return a * new Rational_number(1, b);
    }
    public static Rational_number operator /(Rational_number a, double b)
    {
        return a * new Rational_number(((Rational_number)b)._denominator, ((Rational_number)b)._numerator);
    }
    public static Rational_number operator /(Rational_number a, Rational_number b)
    {
        return a * new Rational_number(b._denominator, b._numerator);
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
    
    public static explicit operator int(Rational_number a)
    {
        return (int)((double)a);
    }
    public static explicit operator double(Rational_number a)
    {
        return (double)a._numerator / a._denominator;
    }


    public override string ToString()
    {
        string a = _numerator.ToString();
        string b = _denominator.ToString();
        char[] a1 = a.ToCharArray();
        char[] b1 = b.ToCharArray();
        Array.Reverse(a1);
        Array.Reverse(b1);
        if (_numerator == 0)
        {
            return "0\n\n";
        }
        if (_numerator % _denominator == 0)
        {
            return $"{(_numerator / _denominator).ToString()}\n\n" ;
        }
        for (int i = 0; i < a1.Length && i < b1.Length; i++)
        {
            if (a1[i] == b1[i] && a1[i] == '0')
            {
                a1[i] = ' ';
                b1[i] = ' ';
            }
            else
                break;
        }
        Array.Reverse(a1);
        Array.Reverse(b1);
        _numerator = int.Parse(a1);
        _denominator = int.Parse(b1);
        return ($"{new string(a1)}\n―\n{new string(b1)}\n\n");
    }

}
