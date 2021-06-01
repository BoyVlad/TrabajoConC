using System;
abstract class Figure
{ 
	public Figure(string n)
	{
		name = n;
	}
	private string name;
	public abstract void Draw();
	public void ShowName()
	{
		Console.WriteLine(name);
	}
}
class Rectangle : Figure
{
	int width;
	int height;
	public Rectangle(int h, int w) : base("Прямоугольник")
	{
		this.width = w;
		this.height = h;
	}
	public override void Draw()
	{
		for (int i = 0; i < height; i++)
		{
			Console.WriteLine("{0}",new string('*', width));		
		}
	}
}
class Triangle : Figure
{
	int height;
	public Triangle(int h, int w) : base("Треугольник")
	{
		this.height = h;
	}
public override void Draw()
	{
		for (int i = 0; i < height; i++)
		{
			Console.WriteLine("{0}{1}", 
				new string(' ', height*2 - i*2), 
				new string('*', (i) * 4 + (height % 2 == 0 ? 0 : 1)));
		}
	}
}
class Rhombus : Figure
{
	int height;
	public Rhombus(int height, int width) : base("Ромб")
	{
		this.height = height;
	}
	public override void Draw()
	{
		for (int i = 0; i < height; i++)
		{
			if (i < height / 2)
			{
			Console.WriteLine("{0}{1}",
				new string(' ', height - i * 2 - 2 + (height % 2 == 0 ? 0 : 2)),
				new string('*', (i) * 4 + 2 + (height % 2 == 0 ? 0 : 1)));
			}
			else if (i <= height / 2 && height % 2 != 0)
			{
				Console.WriteLine("{0}{1}",
					new string(' ', height - i * 2),
					new string('*', i * 4 + 2 + (height % 2 == 0 ? 0 : 1)));
			}
			else if (i >= height / 2)
			{
				Console.WriteLine("{0}{1}",
					new string(' ', i * 2 - height + (height % 2 == 0 ? 0 : 2)),
					new string('*', height * 4 - (i) * 4 - 2 + (height % 2 == 0 ? 0 : 1)));
			}
		}
	}
}


class Sample
{
	static void Main()
	{
		try
		{
			Console.Write("Высота прямоугольника: ");
			int height = Convert.ToInt32(Console.ReadLine());
			Console.Write("Ширина прямоугольника: ");
			int width = Convert.ToInt32(Console.ReadLine());
			Rectangle rect = new Rectangle(height, width);
			rect.ShowName();
			rect.Draw();

			Console.Write("Высота треугольника: ");
			height = Convert.ToInt32(Console.ReadLine());
			Triangle tria = new Triangle(height, width);
			tria.ShowName();
			tria.Draw();

			Console.Write("Высота ромба: ");
			height = Convert.ToInt32(Console.ReadLine());
			Rhombus rom = new Rhombus(height, width);
			rom.ShowName();
			rom.Draw();
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
		Console.Read();
	}
}













