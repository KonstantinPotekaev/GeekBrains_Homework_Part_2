namespace Lesson_4;
public class GenerateID
{
    private static long Id = 0;
    public static long GenerateId()
    {
        return Id++;
    }
}
