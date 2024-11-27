//var tuple1 = (5, 10);
//Console.WriteLine(tuple1.Item1);
//Console.WriteLine(tuple1.Item2);
//tuple1.Item1 += 28;
//Console.WriteLine(tuple1.Item1);
//(int, int) tuple2 = (12, 18);
//(string, int, double) person = ("Tom", 23, 56.0);
//var tuple3 = (count: 3, sum: 10);
//Console.WriteLine(tuple3.count);
//Console.WriteLine(tuple3.sum);
//var (name, age) = ("Jerry", 10);
//Console.WriteLine(name);
//Console.WriteLine(age);

//int a = 7;
//int b = 10;
//Console.WriteLine(a + " " + b);
//(a, b) = (b, a);
//Console.WriteLine(a + " " + b);

//Random random = new Random();
//int[] mas = new int[10];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10, 100);
//    Console.WriteLine(mas[i] + " ");
//}
//Console.WriteLine();
//for (int i = 0; i < mas.Length; i++)
//{
//    for (int j = i+1;j<mas.Length; j++)
//    {
//        if (mas[j] > mas[i]) (mas[i], mas[j]) = (mas[j], mas[i]);
//    }
//}
//for (int i = 0; i < mas.Length; i++)
//{
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();

//int Min(int[]mas)
//{
//    int min = mas[0];
//    for (int i = 1; i < mas.Length; i++)
//    {
//        if (mas[i] > min) min = mas[i];
//    }
//    return min;
//}

//(int max,int min) GetMaxMin(int[]mas)
//{
//    int min = mas[0];
//    int max = mas[0];
//    for (int i = 1; i < mas.Length; i++)
//    {
//        if (mas[i] < min) min = mas[i];
//        if (mas[i] > max) max = mas[i];
//    }
//    return (max,min);
//}

//var maxMin = GetMaxMin(mas);
//Console.WriteLine("max="+maxMin.max);
//Console.WriteLine("min="+maxMin.min);

//Структуры и записи
//набор зависимых друг от друга переменных, относится к типу значения, а не к ссылочному типу
//Person tom = new Person();
//tom.name = "Tom";
//tom.age = 30;
//tom.Print();
//Person golub = new();
//golub.name = "Голубок";
//golub.age = 25;
//golub.Print();
//Person bob = new Person("Bob", 32);
//Console.WriteLine(bob.name);
//Console.WriteLine(bob.age);
//Person jerry = bob with { name = "Jerry" };
//Console.WriteLine(jerry.name);
//Console.WriteLine(jerry.age);
//Human human = new Human("Хроменков", 20);
//human.Print();
//struct Person
//{
//    public string name; 
//    public int age;
//    public Person(string _name, int _age)
//    {
//        name = _name;
//        age = _age;
//    }
//    public void Print()
//    {
//        Console.WriteLine($"Имя:{name} Возраст:{age}");
//    }
//}
//records
//представляет новый ссылочный тип, ключевая особенность его состоит в том, что они могу не изменяемый тип,
//который по умолчанию обладает рядом дополнительных возможностей, по сравнению со структурами
//public record Human
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public Human(string _name, int _age)
//    {
//        Name = _name;
//        Age = _age;
//    }
//    public void Print()
//    {
//        Console.WriteLine($"Имя:{Name} Возраст:{Age}");
//    }
//}

//lab7
struct Computer
{
    public string Name;
    public string Frecuancy;
    public int Memory;
    public bool DVD;
    public decimal Price;

    public Computer(string name, string frecuancy, int memory, bool dVD, decimal price)
    {
        Name = name;
        Frecuancy = frecuancy;
        Memory = memory;
        DVD = dVD;
        Price = price;
    }
    public void Print()
    {
        Console.WriteLine($"Название: {Name} Частота: {Frecuancy}"
    }
}
