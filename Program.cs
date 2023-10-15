using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

public class MusicalInstrument
{
    public string Name { get; set; }
    public string Characteristics { get; set; }

    public MusicalInstrument()
    {
        Console.Write("Введіть назву музичного інструменту: ");
        Name = Console.ReadLine();
        Console.Write("Введіть характеристики музичного інструменту: ");
        Characteristics = Console.ReadLine();
    }

    public virtual void Sound()
    {
        Console.WriteLine($"Звук музичного інструменту {Name}");
    }

    public void Show()
    {
        Console.WriteLine($"Назва музичного інструменту: {Name}");
    }

    public void Desc()
    {
        Console.WriteLine($"Опис музичного інструменту: {Characteristics}");
    }

    public virtual void History()
    {
        Console.WriteLine($"Історія створення музичного інструменту {Name}");
    }
}

public class Violin : MusicalInstrument
{
    public Violin() : base()
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"Скрипка грає душею");
    }
}

public class Trombone : MusicalInstrument
{
    public Trombone() : base()
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"Тромбон видає могутній звук");
    }
}

public class Ukulele : MusicalInstrument
{
    public Ukulele() : base()
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"Укулеле грає легкими і веселими звуками");
    }
}

public class Cello : MusicalInstrument
{
    public Cello() : base()
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"Віолончель має глибокий звук");
    }
}

public abstract class Worker
{
    public string Name { get; set; }

    public Worker()
    {
        Console.Write("Введіть ім'я працівника: ");
        Name = Console.ReadLine();
    }

    public abstract void Print();
}

public class President : Worker
{
    public President() : base()
    {
    }

    public override void Print()
    {
        Console.WriteLine($"Президент: {Name}");
    }
}

public class Security : Worker
{
    public Security() : base()
    {
    }

    public override void Print()
    {
        Console.WriteLine($"Охоронець: {Name}");
    }
}

public class Manager : Worker
{
    public Manager() : base()
    {
    }

    public override void Print()
    {
        Console.WriteLine($"Менеджер: {Name}");
    }
}

public class Engineer : Worker
{
    public Engineer() : base()
    {
    }

    public override void Print()
    {
        Console.WriteLine($"Інженер: {Name}");
    }
}

class Program
{
    static void Main()
    {
        Violin violin = new Violin();
        violin.Sound();
        violin.Show();
        violin.Desc();
        violin.History();

        Trombone trombone = new Trombone();
        trombone.Sound();
        trombone.Show();
        trombone.Desc();
        trombone.History();

        Ukulele ukulele = new Ukulele();
        ukulele.Sound();
        ukulele.Show();
        ukulele.Desc();
        ukulele.History();

        Cello cello = new Cello();
        cello.Sound();
        cello.Show();
        cello.Desc();
        cello.History();

        President president = new President();
        president.Print();
        Security security = new Security();
        security.Print();
        Manager manager = new Manager();
        manager.Print();
        Engineer engineer = new Engineer();
        engineer.Print();
    }
}
