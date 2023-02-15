namespace practise;

public abstract class ABC
{
    public abstract void A();
}

public class BAC : ABC
{
    String a,b;

    public override void A()
    {
        Console.WriteLine("Number : ");
        a = Console.ReadLine();
        Console.WriteLine("Number : ");
        b = Console.ReadLine();
        int z = Convert.ToInt32(a) + Convert.ToInt32(b);
        Console.WriteLine($"The value added to : {z}");
    }
}
