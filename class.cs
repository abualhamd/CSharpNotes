abstract class A{
    public abstract void doSomething();
    //  public abstract String Name;
}

class B{
    // public abstract void doAnother();
}

class C : A
{
    public override void doSomething()
    {
        
    }
}


sealed class D{
     public  void SomeFunc(){}
}

// won't work
// class E:D{

// }

public static class F{
    public static String x;

    public record class G
    {
        
    }
}