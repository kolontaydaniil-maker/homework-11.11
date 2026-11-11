//Задание 1
//class Device
//{
//    public string Name;
//    public string Description;

//    public Device(string name, string description)
//    {
//        Name = name;
//        Description = description;
//    }

//    public virtual void Sound()
//    {
//        Console.WriteLine("Звук устройства");
//    }

//    public void Show()
//    {
//        Console.WriteLine("Название: " + Name);
//    }

//    public void Desc()
//    {
//        Console.WriteLine("Описание: " + Description);
//    }
//}

//class Kettle : Device
//{
//    public Kettle(string name, string description) : base(name, description) { }

//    public override void Sound()
//    {
//        Console.WriteLine("Ш-ш-ш!");
//    }
//}

//class Microwave : Device
//{
//    public Microwave(string name, string description) : base(name, description) { }

//    public override void Sound()
//    {
//        Console.WriteLine("Бип-бип!");
//    }
//}

//class Car : Device
//{
//    public Car(string name, string description) : base(name, description) { }

//    public override void Sound()
//    {
//        Console.WriteLine("Брум-брум!");
//    }
//}

//class Steamboat : Device
//{
//    public Steamboat(string name, string description) : base(name, description) { }

//    public override void Sound()
//    {
//        Console.WriteLine("Ту-ту!");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Device[] devices =
//        {
//            new Kettle("Чайник", "Кипятит воду"),
//            new Microwave("Микроволновка", "Разогревает еду"),
//            new Car("Автомобиль", "Транспортное средство"),
//            new Steamboat("Пароход", "Водный транспорт")
//        };

//        foreach (Device device in devices)
//        {
//            device.Show();
//            device.Desc();
//            device.Sound();
//            Console.WriteLine();
//        }
//    }
//}

//Задание 2
//class Course
//{
//    public string Name;
//    public int Duration;

//    public Course(string name, int duration)
//    {
//        Name = name;
//        Duration = duration;
//    }

//    public override string ToString()
//    {
//        return $"Название курса: {Name}, Продолжительность: {Duration} часов";
//    }
//}

//class OnlineCourse : Course
//{
//    public string Platform;

//    public OnlineCourse(string name, int duration, string platform)
//        : base(name, duration)
//    {
//        Platform = platform;
//    }

//    public override string ToString()
//    {
//        return base.ToString() + $", Платформа: {Platform}";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Course course = new Course("C#", 30);
//        OnlineCourse online = new OnlineCourse("C++", 40, "Udemy");

//        Console.WriteLine(course);
//        Console.WriteLine(online);
//    }
//}

//Задание 3

//abstract class Product
//{
//    public abstract double CalculateDiscount();
//}

//class Electronics : Product
//{
//    public override double CalculateDiscount()
//    {
//        return 10;
//    }
//}

//class Furniture : Product
//{
//    public override double CalculateDiscount()
//    {
//        return 20;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        List<Product> products = new List<Product>();

//        products.Add(new Electronics());
//        products.Add(new Furniture());

//        foreach (Product product in products)
//        {
//            Console.WriteLine("Размер скидки: " + product.CalculateDiscount() + "%");
//        }
//    }
//}