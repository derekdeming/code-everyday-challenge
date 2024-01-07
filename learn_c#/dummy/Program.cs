
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