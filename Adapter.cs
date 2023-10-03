public interface Duck
{
    public void quack();
    public void fly();
}

public class MallardDuck : Duck
{
    public void quack()
    {
        Console.WriteLine("Quack");
    }
    public void fly()
    {
        Console.WriteLine("I’m flying");
    }
}


public interface Turkey
{
    public void gobble();
    public void fly();
}

public class WildTurkey : Turkey
{
    public void gobble()
    {
        Console.WriteLine("Gobble gobble");
    }
    public void fly()
    {
        Console.WriteLine("I’m flying a short distance");
    }
}


public class TurkeyAdapter : Duck
{
    Turkey turkey;
    public TurkeyAdapter(Turkey turkey)
    {
        this.turkey = turkey;
    }
    public void quack()
    {
        turkey.gobble();
    }
    public void fly()
    {
        for (int i = 0; i < 5; i++)
        {
            turkey.fly();
        }
    }
}


public class TestAdapter
{
    public static void Test(String[] args)
    {
        MallardDuck duck = new MallardDuck();
        WildTurkey turkey = new WildTurkey();

        Duck turkeyAdapter = new TurkeyAdapter(turkey);
        Console.WriteLine("The Turkey says...");
        turkey.gobble();
        turkey.fly();

        Console.WriteLine("\nThe Duck says...");
        testDuck(duck);

        Console.WriteLine("\nThe TurkeyAdapter says...");
        testDuck(turkeyAdapter);
    }

    static void testDuck(Duck duck)
    {
        duck.quack();
        duck.fly();
    }
}