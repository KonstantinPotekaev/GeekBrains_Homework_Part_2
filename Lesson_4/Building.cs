namespace Lesson_4;

public class Building
{
    //Все поля приватные
    private long number;
    private double _height;
    private int _floor;
    private int _aparts;
    private int _entance;

    public Building(double height, int floor, int aparts, int entance)
    {
        number = GenerateID.GenerateId();
        _height = height;
        _floor = floor;
        _aparts = aparts;
        _entance = entance;
    }

    public (double, int, int, int) GetInfo()
    {
        return (_height, _floor, _aparts, _entance);
    }

    public double CalculatingFloorHeight()
    {

        return (double)(_height / CalculatingTheNumberOfApartmentsInEntrance());
    }

    public int CalculatingTheNumberOfApartmentsInEntrance()
    {
        return _aparts / _entance;
    }

    public int CalculateNumberOfApartementOnFloor()
    {
        return CalculatingTheNumberOfApartmentsInEntrance() / _floor;
    }
}

