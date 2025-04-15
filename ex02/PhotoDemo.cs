using System;
using static System.Console;
using System.Globalization;
class PhotoDemo
{
	static void Main()
	{
        Photo photo1 = new Photo(8, 10);
        WriteLine(photo1.ToString());

        Photo photo2 = new Photo(10, 12);
        WriteLine(photo2.ToString());

        MattedPhoto photo3 = new MattedPhoto("white", 10, 12);
        WriteLine(photo3.ToString());

        FramedPhoto photo4 = new FramedPhoto("silver","modern",8,10);
        WriteLine(photo4.ToString());
	}
}
class Photo
{
    private int width;
    private int height;
    protected double price;
    public int Width
    {
        get{return width;}
        set{width = value;}
    }
    public int Height
    {
        get{return height;}
        set{height = value;}
    }
    public double Price{
        get{return price;}
    }
    public Photo(int width, int height)
    {
        this.width = width;
        this.height = height;
        if(width == 8 && height == 10){
            price = 3.99;
        }
        else if(width == 10 && height == 12){
            price = 5.99;
        }
        else{
            price = 9.99;
        }
    }
    public override string ToString()
    {
        return GetType().Name + ": \nWidth: " +width+ " Height: " + height + " \nPrice: " + price.ToString("C", CultureInfo.GetCultureInfo("en-US"));
    }
}
class MattedPhoto : Photo
{
    private string color;
    public string Color 
    {
        get{return color;} 
        set{color = value;}
    }
    public MattedPhoto(string color, int width, int height)
        : base(width, height){
            this.color = color;
            price += 10;
        }
    public override string ToString()
    {
        return GetType().Name + ": \nWidth: " + Width + " Height: " + Height + "\nMatting: " + color + "\nPrice: " + price.ToString("C", CultureInfo.GetCultureInfo("en-US"));
    }
}
class FramedPhoto : Photo
{
    private string material;
    private string style;
    public string Material 
    {
        get{return material;}
        set{material = value;}
    }
    public string Style {
        get{return style;}
        set{style = value;}
    }
    public FramedPhoto(string material, string style, int width, int height)
    :   base(width, height){
        this.material = material;
        this.style = style;
        price += 25;
    }
    public override string ToString()
    {
        return GetType().Name + ": \nWidth: " + Width + " Height: " + Height + "\nMaterial: " + material +" Style: "+ style + "\nPrice: " + price.ToString("C", CultureInfo.GetCultureInfo("en-US"));
    }
}
