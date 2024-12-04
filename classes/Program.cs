class Point3d {
    double x, y, z;

    public Point3d(double x, double y, double z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public void MoveBy(double dx, double dy, double dz) {
        this.x += dx;
        this.y += dy;
        this.z += dz;
    }

    public void Print() {
        Console.WriteLine($"({x}, {y}, {z})");
    }
}

class User {
    // Фамилия, имя, отчество и возраст, а также метод ФИО, выводящее фамилию, имя и отчество, разделенные пробелами в виде строки.
    string last_name, first_name, otchestvo;
    uint age;

    public User(string last_name, string first_name, string otchestvo, uint age) {
        this.last_name = last_name;
        this.first_name = first_name;
        this.otchestvo = otchestvo;
        this.age = age;
    }

    public void FIO() {
        Console.WriteLine($"{last_name} {first_name} {otchestvo}");
    }
}

class PC {
    // Класс Персональный компьютер, имеющий поля модель,
    // тактовая частота процессора, объем оперативной памяти,
    // объем жесткого диска и метод Info, выводящий информацию
    // о персональном компьютере в виде строки

    protected string model;
    protected double frequency_GHz;
    protected double ram_GB;
    protected double rom_GB;

    public PC(string model, double frequency_Hz, double ram_GB, double hdd_GB) {
        this.model = model;
        this.frequency_GHz = frequency_Hz;
        this.ram_GB = ram_GB;
        this.rom_GB = hdd_GB;
    }

    public void Info() {
        Console.WriteLine($"model: {model}, frequency_GHz: {frequency_GHz}, ram_GB: {ram_GB}, hdd_GB {rom_GB}");
    }
}

class Laptop : PC {
    double mass_kg;

    public Laptop(string model, double frequency_Hz, double ram_GB, double rom_GB, double mass_kg)
        : base(model, frequency_Hz, ram_GB, rom_GB) {
            this.mass_kg = mass_kg;
        }

    new public void Info() {
        Console.WriteLine($"model: {model}, frequency_GHz: {frequency_GHz}, ram_GB: {ram_GB}, hdd_GB {rom_GB}, mass_kg: {mass_kg}");
    }
}

class Smartphone : PC {
    string os_type;
    double mass_kg;

    public Smartphone(string model, double frequency_Hz, double ram_GB, double rom_GB, double mass_kg, string os_type)
        : base(model, frequency_Hz, ram_GB, rom_GB) {
            this.os_type = os_type;
            this.mass_kg = mass_kg;
        }

    new public void Info() {
        Console.WriteLine($"model: {model}, frequency_GHz: {frequency_GHz}, ram_GB: {ram_GB}, rom_GB {rom_GB}, mass_kg: {mass_kg}, os_type: {os_type}");
    }
}

class Rect {
    class Point2d {
        public double x, y;

        public Point2d(double x, double y) {
            this.x = x;
            this.y = y;
        }
    }

    Point2d left_top, right_bottom;

    public Rect(double left_top_x, double left_top_y, double right_bottom_x, double right_bottom_y) {
        this.left_top = new Point2d(left_top_x, left_top_y);
        this.right_bottom = new Point2d(right_bottom_x, right_bottom_y);
    }

    double a() {
        return right_bottom.x - left_top.x;
    }

    double b() {
        return right_bottom.y - left_top.y;
    }

    public double area() {
        return a() * b();
    }

    public double perimeter() {
        return (a() + b()) * 2;
    }
}

class Triangle {
    double a, b, c;

    public Triangle(double a, double b, double c) {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double perimeter() {
        return a + b + c;
    }

    public void print_sides() {
        Console.WriteLine($"a: {a}, b: {b}, c: {c}");
    }

    public void print_perimeter() {
        Console.WriteLine($"perimeter: {perimeter()}");
    }
}

class PostalItem {
    // Класс Почтовое отправление, содержащий поля адреса получателя: индекс, город, улица,
    // дом, корпус, квартира, а также, тело письма (сообщение), и метод, выводящий адрес в виде строки.

    string index, city, street, body;
    uint house, building, apartment;

    public PostalItem(string index, string city, string street, uint house, uint building, uint apartment, string body) {
        this.index = index;
        this.city = city;
        this.street = street;
        this.house = house;
        this.building = building;
        this.apartment = apartment;
        this.body = body;
    }

    public void print_address() {
        Console.WriteLine($"{index}, {city}, ул. {street}, д. {house}к{building}, кв. {apartment}");
    }
}

class Program {
    public static void Main(string[] args) {
        Point3d p = new Point3d(1, 1, 1);
        p.Print();
        p.MoveBy(1, 1, 1);
        p.Print();

        User u = new User("Иванов", "Иван", "Иванович", 25);
        u.FIO();

        PC pc = new PC("computor", 3.8, 6, 512);
        pc.Info();

        Laptop laptop = new Laptop("Asus x57874598273845784754857 series", 2.0, 2, 120, 2);
        laptop.Info();

        Smartphone smartphone = new Smartphone("realme c67", 1.7, 8, 256, 0.4, "Android");
        smartphone.Info();

        Rect rect = new Rect(1, 1, 4, 5);
        Console.WriteLine($"area: {rect.area()}, perimeter: {rect.perimeter()}");

        Triangle t = new Triangle(3, 4, 5);
        t.print_sides();
        t.print_perimeter();

        PostalItem pi = new PostalItem("123123", "Москва", "Чехова", 12, 4, 55, "привет братан чо как дела");
        pi.print_address();
    }
}
