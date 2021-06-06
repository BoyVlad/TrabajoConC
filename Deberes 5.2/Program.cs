using System;
using System.Collections;
using System.Collections.Generic;
class Employee
{
	string nombre;
	string apellido;
	string position;
	public Employee(string nombre, string apellido, string position)
	{
		this.nombre = nombre;
		this.apellido = apellido;
		this.position = position;
	}
	public Employee()
	{
		this.nombre = "Имя";
		this.apellido = "Фамилия";
		this.position = "Должность";
	}
	public string Nombre
	{
		get
		{
			return nombre;
		}
		set
		{
			nombre = value;
		}
	}
	public string Apellido
	{
		get
		{
			return apellido;
		}
		set
		{
			apellido = value;
		}
	}
	public string Position
	{
		get
		{
			return position;
		}
		set
		{
			position = value;
		}
	}
	public void Show()
	{
		Console.WriteLine("Имя: {0} Фамилия: {1} Должность: {2}", nombre, apellido, position);
	}
}
class Firma
{
	string nombre;
	string apellido;
	string position;
	List<Employee> Employees { get; }
	List<string> post = new List<string>();
	public int Quantity;
	private string name;
	public Firma()
	{
		name = "Название Фирмы";
		Employees.Add(new Employee("Иван", "Иванов", "Редактор"));
		Employees.Add(new Employee("Иванна", "Иванова", "НеРедактор"));
		Employees.Add(new Employee("Иванна", "Иванова", "Директор"));
	}
	public Firma(string name, int Quantity)
	{
		Employees = new List<Employee>();
		this.name = name;
		this.Quantity = Quantity;

		for (int i = 0; i < Quantity; i++)
		{
			Console.WriteLine("Введите имя сотрудника: ");
			nombre = Console.ReadLine();
			Console.WriteLine("Введите фамилию сотрудника: ");
			apellido = Console.ReadLine();
			Console.WriteLine("Введите должность сотрудника: ");
			position = Console.ReadLine();
			Employees.Add(new Employee(nombre, apellido, position)); ;
		}
	}
	public void Add(string nombre, string apellido, string position)
	{
		Employees.Add(new Employee(nombre, apellido, position));
		CheckPosition(position);
	}
	public void Del()
	{
		int del = 0;
		int ind = 1;
		foreach (Employee b in Employees)
		{
			Console.Write(ind + ". ");
			b.Show();
			ind++;
		}
		Console.WriteLine("Введите индекс сотрудника, которого нужно удалить: ");
		do
		{
			del = Convert.ToInt32(Console.ReadLine());
			if (del == 0 && del > QuantityOfEmployee)
			{
				Console.WriteLine("Неверный индекс");
			}
		}
		while (del == 0 && del > QuantityOfEmployee);
		del--;
		Employees.RemoveAt(del);
	}
	public virtual int QuantityOfEmployee
	{
		get
		{
			return Employees.Count;
		}
	}
	public string Name
	{
		get
		{
			return name;
		}
	}
	public void ResConsole()
	{
		Console.Clear();
		ShowList();
		Console.ReadLine();
	}
	public void ShowList()
	{
		for (int i = 0; i < Quantity; i++)
		{
			Console.Write(i + 1 + ". ");
			Employees[i].Show();
		}
	}
	public void CheckListPosition()
	{
		for (int i = 0; i < QuantityOfEmployee; i++)
			CheckPosition(Employees[i].Position);
	}
	public void CheckPosition(string Position)
	{
		if (!post.Contains(Position))
			AddPosition(Position);
	}
	public void AddPosition(string Position)
	{
		int indPost;
		Console.WriteLine("Должности {0} нет в списке", Position);
		Console.ReadLine();
		if (post.Count == 0)
			post.Add(Position);
		else
		{
			for (int i = 0; i < post.Count; i++)
				Console.WriteLine("{0}. {1}", i + 1, post[i]);

			Console.WriteLine("Введите цифру, на котором месте по иерархии дожна находиться должность {0}(должность на этой позиции сместиться вниз)", Position);

			do
				indPost = Convert.ToInt32(Console.ReadLine());
			while (indPost == 0 && indPost > post.Count);
			indPost--;
			post.Insert(indPost, Position);

		}
	}
	public void СomparisonPosition(int A, int B)
	{
		string PositionA, PositionB, NameA, NameB, ApellidoA, ApellidoB;
		PositionA = Employees[A].Position;
		PositionB = Employees[B].Position;
		NameA = Employees[A].Nombre;
		NameB = Employees[B].Nombre;
		ApellidoA = Employees[A].Apellido;
		ApellidoB = Employees[B].Apellido;
		int IndexA = post.IndexOf(PositionA);
		int IndexB = post.IndexOf(PositionB);
		if (IndexA > IndexB)
			Console.WriteLine("Сотрудник {0} {1} на должности {2} имеет более низкую должноть чем сотрудник {3} {4} на должности {5}", ApellidoA, NameA, PositionA, ApellidoB, NameB, PositionB);
		if (IndexA < IndexB)
			Console.WriteLine("Сотрудник {0} {1} на должности {2} имеет более высокую должноть чем сотрудник {3} {4} на должности {5}", ApellidoA, NameA, PositionA, ApellidoB, NameB, PositionB);
		if (IndexA == IndexB)
			Console.WriteLine("Сотрудник {0} {1} на должности {2} имеет туже должноть, что и сотрудник {3} {4}", ApellidoA, NameA, PositionA, ApellidoB, NameB, PositionB);
	}
}
class Program
{ 
	static void Main()
	{

		try
		{
			bool end = false;
			string cmd;
			Console.WriteLine("Введите навание фирмы: ");
			string NameFirma = Console.ReadLine();
			Console.WriteLine("Введите количество сотрудников: ");
			int Quantity = Convert.ToInt32(Console.ReadLine());
			Firma firm = new Firma(NameFirma, Quantity);
			firm.CheckListPosition();
			do
			{
				Console.Clear();
				Console.WriteLine("Фирма <<{0}>>. Количество сотрудников - {1}", firm.Name, firm.QuantityOfEmployee);
				Console.WriteLine("Введите команду(help для вызова справки): ");
				cmd = Console.ReadLine();
				switch (cmd)
				{
					case "Добавить сотрудника":
						Console.WriteLine("Введите имя сотрудника: ");
						string nombre = Console.ReadLine();
						Console.WriteLine("Введите фамилию сотрудника: ");
						string apellido = Console.ReadLine();
						Console.WriteLine("Введите должность сотрудника: ");
						string position = Console.ReadLine();
						firm.Add(nombre, apellido, position);
						firm.ResConsole();
						break;
					case "Удалить сотрудника":
						Quantity--;
						firm.Del();
						firm.ResConsole();
						break;
					case "Список сотрудников":
						firm.ResConsole();
						break;
					case "Проверить по должности":
						int A, B;
						firm.ResConsole();
						Console.WriteLine("Введите индексы тех, кого вы хотите сравнить. Первый: ");
						do
						{
							A = Convert.ToInt32(Console.ReadLine());
							if (A == 0 && A > firm.QuantityOfEmployee)
								Console.WriteLine("Недопустимый индекс");
						}
						while (A == 0 && A > firm.QuantityOfEmployee);
						Console.WriteLine("Второй: ");
						do
						{
							B = Convert.ToInt32(Console.ReadLine());
							if (B == 0 && B > firm.QuantityOfEmployee)
								Console.WriteLine("Недопустимый индекс");
						}
						while (B == 0 && B > firm.QuantityOfEmployee);
						A--;
						B--;
						firm.СomparisonPosition(A, B);
						break;
					case "Конец":
						end = true;
						break;
					case "help":
                        Console.WriteLine("Добавить сотрудника, Удалить сотрудника, Список сотрудников, Проверить по должности, Конец");
						break;
				}
				Console.ReadLine();
			}
			while (!end);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		Console.Read();
	}
}
