namespace Lesson_7;

public class ACoder : ICoder
{
    public string Encode(string? s)
    {
        if (s is null)
        {
            throw new ArgumentNullException();
        }
        char [] c = s.ToCharArray();
        for (int i = 0; i < c.Length; i++)
        {
            //int a = (char)c[i] + 1;
            c[i] = (char)((char)c[i] + 1);
        }
        s = c.ToString();
        return s;
    }
    public string Decode(string s)
    {
        /*if (s is { })
        {
            throw new ArgumentNullException("s");
        }*/
        return s;
    }

    public override string ToString()
    {
        string s = "";
        return s;
    }
}
