using System;
using System.Collections;

namespace Deberes_5._1
{
    class Employee
    {
        string nombre;
        string apellido;
        string position;
        public void AddEmployee()
        {
            Console.WriteLine("Введите имя сотрудника: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Введите фамилию сотрудника: ");
            apellido = Console.ReadLine();
            Console.WriteLine("Введите должность сотрудника: ");
            position = Console.ReadLine();
        }
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

    class Firma : IEnumerable, IEnumerator
    {

        private Employee[] obj;
        private string name;
        int current = -1;
        public Firma()
        {
            name = "Партнеры+";
            obj = new Employee[3];
            obj[0] = new Employee("Хосе", "Андриа", "Редактор");
            obj[1] = new Employee("Хуан", "Рики", "Клинер");
            obj[2] = new Employee("Мария", "Гарсия", "Директор");
        }

        public Firma(string name, int pos)
        {
            this.name = name;
            obj = new Employee[pos];
            for (int i = 0; i < obj.Length; i++)
            {
                obj[i] = new Employee();
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void AddEmployee()
        {
            for (int i = 0; i < obj.Length; i++)
            {
                obj[i].AddEmployee();
            }
        }
        public float QuantityOfEmployee
        {
            get
            {
                return obj.Length;
            }
        }
        public void ShowEmployee()
        {
            for (int i = 0; i < obj.Length; i++)
            {
                obj[i].Show();
            }
        }
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
        public void Reset()
        {
            current = -1;
        }
        public object Current
        {
            get
            {
                return obj[current];
            }
        }
        public bool MoveNext()
        {

            if (current < obj.Length - 1)
            {
                current++;
                return true;
            }
            return false;
        }
        public Firma Copy()
        {
            return new Firma(Name, obj.Length);
        }

        public void Interacting(int index)
        {
            object [] newArray = new object[obj.Length - 1];
            for (int i = 0; i < index; i++)
                newArray[i] = obj[i];
            for (int i = index; i < obj.Length-1; i++)
                newArray[i] = obj[i+1];
            obj = null;
            for (int i = 0; i < newArray.Length; i++)
            {
                //obj[i] = newArray[i]; это не работает!!!
            }
        }
        public void Interacting()
        {
            obj = new Employee[obj.Length+1];
            obj[obj.Length] = new Employee();
            obj[obj.Length].AddEmployee();
        }
    } 
        class Program
        {
            public static void Main()
            {
                try
                {
                    bool end = false;
                    string cmd;
                    int Quantity;
                    Console.WriteLine("Введите навание фирмы: ");
                    string NameFirma = Console.ReadLine();
                    //do
                    //{
                        Console.WriteLine("Введите количество сотрудников: ");
                        Quantity = Convert.ToInt32(Console.ReadLine());
                        /*if (Quantity == 0)
                        {
                            Console.WriteLine("Некорректнное количество работников");
                        }*/
                    //}
                    //while (Quantity == 0);
                    Firma firm = new Firma(NameFirma, Quantity);
                    firm.AddEmployee();
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Фирма <<{0}>>. Количество сотрудников - {1}", NameFirma, firm.QuantityOfEmployee);
                        Console.WriteLine("Введите команду(help для вызова справки): ");
                        cmd = Console.ReadLine();
                        switch (cmd)
                        {
                            case "Добавить сотрудника":
                                firm.Interacting();
                                break;
                            case "Удалить сотрудника":
                                foreach (Employee b in firm)
                                {
                                    int ind = 1;
                                    Console.Write(ind + ". ");
                                    ind++;
                                    b.Show();
                                }
                                Console.WriteLine("Сотрудника под каким индексом удалить?");
                                int del = Convert.ToInt32(Console.ReadLine());
                                if (del <= 0&&del>firm.QuantityOfEmployee)
                                {
                                    Console.WriteLine("Некорректнный индекс работника");
                                    break;
                                }
                                del--;
                                firm.Interacting(del);
                                Quantity--;
                                break;
                            case "Список сотрудников":
                                foreach (Employee b in firm)
                                {
                                    b.Show();
                                }
                                firm.Reset();
                                break;
                        }

                    }
                    while (!end);
                    foreach (Employee b1 in firm)
                    {
                        b1.Show();
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.Read();
            }
        }
    }


