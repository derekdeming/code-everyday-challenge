
Rectangle rectangle1 = new Rectangle(4, 3);
//rectangle1._area = 200; // anyone can just change the value of the area so we need to handle public vs private 
Console.WriteLine(rectangle1.Area);
rectangle1.Width = 7;
Console.WriteLine(rectangle1.Area);


class Rectangle
{
    private float _width;
    private float _height;
    private float? _cachedArea;

    public Rectangle(float width, float height)
    {
        _width = width;
        _height = height;
    }

    public float Width
    {
        get => _width;
        set
        {
            if (value <= 0) throw new ArgumentException("Width must be greater than 0");
            _width = value;
            _cachedArea = null;
        }
    }
    public float Height
    {
        get => _height;
        set
        {
            if (value <= 0) throw new ArgumentException("Width must be greater than 0");
            _height = value;
            _cachedArea = null;
        }
    }
    public float Area
    {
        get
        {
            if (!_cachedArea.HasValue)
            {
                _cachedArea = Width * Height;
            }
            return _cachedArea.Value;
        }
    }

}

public class MonitorSignal
{
    private Telemetry[] MonitoringTelementryHandlers = new[] { new MonitorSignal() };
    private static string workingDir = null;
    private const string training = "training";
    private const string signal = "monitoring";

    private static string FormatTrainingSignal(string input)
    {
        var prefix = $"{signal}:{training}:";
        string postfix = ":";
        if (!String.IsNullOrEmpty(input))
        {
            prefix = input;
        }
        if (!String.IsNullOrEmpty(postfix))
        {
            postfix += workingDir;
        }
        return prefix + postfix;
    }
}











//// ################ NON SCALABLE CLASS STRUCTURE ########################
//Rectangle rectangle1 = new Rectangle(4, 3);
////rectangle1._area = 200; // anyone can just change the value of the area so we need to handle public vs private 
//Console.WriteLine(rectangle1.Area);



//class Rectangle
//{
//    private float _width;
//    private float _height;
//    private float _area;

//    public Rectangle(float width, float height)
//    {
//        _width = width;
//        _height = height;
//        _area = width * height;
//    }

//    public float GetWidth() => _width;
//    public float GetHeight() => _height;
//    public float Area => _area;

//    // IF THE OUTSIDE WORLD NEEDS TO CHANGE THE RECTANGLES DIMENSIONS, WE CAN ALSO SOLVE THAT WITH METHODS 
//    public void SetWidth(float value)
//    {
//        _width = value; 
//        _area = _width * _height;
//    }

//    public void SetHeight(float value)
//    {
//        _height = value;
//        _area = _width * _height;
//    }
//}

