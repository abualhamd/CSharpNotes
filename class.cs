using System.Collections;
using System.Security.Cryptography.X509Certificates;

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

/// <summary>
/// nested classes can be used with factory pattern or
/// to implement Enumerators or Comprators
/// </summary>
public abstract class CardPayment
{
    private CardPayment(){}

    public abstract void Pay();

    class VisaPayment : CardPayment
    {
        public override void Pay()
        {
            Console.WriteLine("Pay by Visa");
        }
    }
    class MasterCardPayment : CardPayment{
        public override void Pay()
        {
            Console.WriteLine("Pay by MasterCard");
        }
    }



    public static CardPayment PayVisa(){
        return new VisaPayment();
    }
    public static CardPayment PayMasterCard(){
        return new MasterCardPayment();
    }
}

class MyUselessList : IEnumerable<int> {
    // ...
    private List<int> internalList;
    private class UselessListEnumerator : IEnumerator<int> {
        private MyUselessList obj;
        public UselessListEnumerator(MyUselessList o) {
           obj = o;
        }
        private int currentIndex = -1;
        public int Current {
           get { return obj.internalList[currentIndex]; }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public bool MoveNext() { 
           return ++currentIndex < obj.internalList.Count;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new UselessListEnumerator(this);
    }

    public IEnumerator<int> GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

public partial class PartialClass{
    public void Method1(){}
}

partial class PartialClass{
    public void Method2(){}
}

public class Test{

    public Test(){}
    public const int b =0;

    public void Method1(){
        Console.WriteLine("Method 1 - Base Class");
    }
    public new class NestedTest:Test{
        
        
           public const int b = 5;
    }

}

public class Test2:Test{

    new public void Method1(){
        Console.WriteLine("Method 1 - Derived Class");
    }

    public new class NestedTest{
        
        
           public const int c = 5;
    }

}

class J{
    virtual public void Method1(){
        Console.WriteLine("Method 1 - Base Class");
    }
}
class K:J{
    // override
    new public void Method1(){
        Console.WriteLine("Method 1 - Derived Class");
    }
}