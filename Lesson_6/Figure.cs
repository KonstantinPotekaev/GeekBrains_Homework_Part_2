namespace Lesson_6;

public class Figure
{
    private string _colour;
    private bool _status;
    private double _x, _y;

    public Figure(string colour, bool status, double x, double y)
    {
        _colour = colour;
        _status = status;
        _x = x;
        _y = y;
    }

    public void MoveTo(double x, double y)
    {
        _x = x;
        _y = y;
    }
    public void ChangeColour(string colour)
    {
        _colour = colour;
    }
    public void ChangeStatus(bool status)
    {
        _status = status;
    }
    public override string ToString()
    {
        return ($"Color = {_colour}\nStatus = {_status}\nСoordinates = ({_x},{_y})\n\n");
    }
}

public class Point : Figure
{
    public Point(string colour, bool status, double x, double y) : base(colour, status, x, y) { }
}
public class Circle : Point
{
    private double _radius;
    public Circle(string colour, bool status, double x, double y, double radius) : base(colour, status, x, y) 
    {
        _radius = radius;
    }
    
    public double Square()
    {
        return (_radius * _radius * Math.PI);
    }
    /*public override string ToString()
    {
            КАК РЕАЛИЗОВАТЬ У НАСЛЕДНИКА?
        
    }*/
}

public class Rectangle : Point
{
    double _length, _width;
    public Rectangle(string colour, bool status, double x, double y, double length, double width) : base(colour, status, x, y)
    {
        _length = length;
        _width = width;
    }

    public double Square()
    {
        return _length * _width;
    }
}
