using System;
using System.Collections.Generic;
using System.Text;


class Rectangle
{
    private string id;
    private int width;
    private int height;
    private int topLeftX;
    private int topLeftY;

    public Rectangle()
    {
    }
    public Rectangle(string id, int width, int height, int topLeftX, int topLeftY)
    {
        Id = id;
        Width = width;
        Height = height;
        TopLeftX = topLeftX;
        TopLeftY = topLeftY;
    }

    public string Id
    {
        get { return id; }
        set { id = value; }
    }
    public int Width
    {
        get { return width; }
        set { width = value; }
    }
    public int Height
    {
        get { return height; }
        set { height = value; }
    }
    public int TopLeftX
    {
        get { return topLeftX; }
        set { topLeftX = value; }
    }
    public int TopLeftY
    {
        get { return topLeftY; }
        set { topLeftY = value; }
    }

    public bool IsIntersect(Rectangle rectangle)
    {
        return (this.topLeftX >= rectangle.topLeftX &&
                this.topLeftX <= rectangle.topLeftX + width &&
                this.topLeftY + height >= rectangle.topLeftY &&
                this.topLeftY + height <= rectangle.topLeftY + height)
               ||
               (this.topLeftX + width >= rectangle.topLeftX &&
                this.topLeftX + width <= rectangle.topLeftX + width &&
                this.topLeftY + width >= rectangle.topLeftY &&
                this.topLeftY + width <= rectangle.topLeftY + height)
               ||
               (this.topLeftX >= rectangle.topLeftX &&
                this.topLeftX <= rectangle.topLeftX + width &&
                this.topLeftY >= rectangle.topLeftY &&
                this.topLeftY <= rectangle.topLeftY + height)
               ||
               (this.topLeftX + width >= rectangle.topLeftX &&
                this.topLeftX + width <= rectangle.topLeftX + width &&
                this.topLeftY + height >= rectangle.topLeftY &&
                this.topLeftY + height <= rectangle.topLeftY + height);
    }
}

