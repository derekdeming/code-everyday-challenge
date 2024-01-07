
Rectangle rectangle1 = new Rectangle(4, 3);
//rectangle1._area = 200; // anyone can just change the value of the area so we need to handle public vs private 
Console.WriteLine(rectangle1.Area);


class Rectangle
{
    private float _width;
    private float _height;
    private float _area;

    public Rectangle(float width, float height)
    {
        _width = width;
        _height = height;
        _area = width * height;
    }

    public float GetWidth() => _width;
    public float GetHeight() => _height;
    public float Area => _area;

    // IF THE OUTSIDE WORLD NEEDS TO CHANGE THE RECTANGLES DIMENSIONS, WE CAN ALSO SOLVE THAT WITH METHODS 
    public void SetWidth(float value)
    {
        _width = value; 
        _area = _width * _height;
    }

    public void SetHeight(float value)
    {
        _height = value;
        _area = _width * _height;
    }
}