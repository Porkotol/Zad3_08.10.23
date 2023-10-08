class Parent
{
    protected double Pole1;
    protected double Pole2;
    protected double Pole3;
    protected double Pole4;
    protected internal double Pole5;

    public Parent()
    {

    }

    public Parent(double pole1, double pole2, double pole3)
    {
        this.Pole1 = pole1;
        this.Pole2 = pole2;
        this.Pole3 = pole3;
        this.Pole4 = 2 * (Pole1 + Pole2) * Pole3; /////площа
        this.Pole5 = Pole4 * 5; ////кiл.штук
    }
    public void Print()
    {
        Console.WriteLine($"Довжина кiмнати - {Pole1} Ширина кiмнати - {Pole2} Висота кiмнати - {Pole3} Площа стiн - {Pole4} Потрiбна кiлькiсть штукатурки - {Pole5} ");
    }
    public bool Metod1(double dayst)
    {
        if (Pole5 >= dayst)
        {
            Pole5 = Pole5 - dayst;
            return true;
        }
        else
        {
            return false;
        }
    }
}
class Child : Parent
{
    double Pole6; ///шир.плитк
    double Pole7; ///довж.плитк
    protected internal double Pole8; ///кiльк.плит

    public Child(double pole1, double pole2, double pole3, double pole6, double pole7) : base(pole1, pole2, pole3)
    {
        this.Pole6 = pole6;
        this.Pole7 = pole7;
        this.Pole8 = Math.Ceiling(Pole4 / (Pole6 * Pole7));
    }

    public void Print()
    {
        base.Print();
        Console.WriteLine($"Ширина однiєї плитки {Pole6}");
        Console.WriteLine($"Довжина однiєї плитки {Pole7}");
        Console.WriteLine($"Кiлькiсть плиток: {Pole8}");
    }

    public bool Metod2(int daypl)
    {
        if (Pole8 >= daypl)
        {
            Pole8 = Pole8 - daypl;
            return true;
        }
        else
        {
            return false;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Parent parent = new Parent(5, 6, 3);
        parent.Print();
        int st = 100;
        int dayst = 0;
        int pl = 100;
        int daypl = 0;
        do
        {
            dayst++;
        } 
        while (parent.Metod1(100) && parent.Pole5 >= 0);
        Console.WriteLine($"Потрiбно днiв на штукатурку: {dayst} по 100кг");
        Child child = new Child(5, 6, 3, 0.3, 0.4);
        child.Print();
        do
        {
            daypl++;
        }
        while (child.Metod2(100) && child.Pole8 >= 0);
        Console.WriteLine($"Потрiбно днiв на укладання плитки: {daypl}");
    }
}

