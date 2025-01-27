// // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");


// // int feetToInches(int feet){
// //     return feet * 12;
// // }

// // Console.WriteLine(feetToInches(5));

// //         Console.WriteLine("Enter a number!");
// // var input = Console.ReadLine();

// // if(int.TryParse(input, out int result)){

// //         Console.WriteLine($"{result} parsed successfully");

// // }

// void GetSumAndProduct(int a, int b, out int sum, out int product){
//     sum = a+b;
//     product = a*b;
// }

// GetSumAndProduct(5, 10, out int sum, out int product);

// Console.WriteLine($"Sum: {sum}, Product: {product}");

// (int sum, int product) GetSumAndProduct2(int a, int b){
//     return (a+b, a*b);

// }

// var (sum2, product2) = GetSumAndProduct2(5, 10);
// Console.WriteLine($"Sum2: {sum2}, Product2: {product2}");
using System.Text;
using Comments;
using Points;
  
class Program
{
    public delegate void MyDelegate(int a);
    public delegate void MyDelegate2(int a);

    /// <summary>
    /// unmanaged: The type must be a non-nullable value type that isn't a pointer type or a struct with no reference-type fields.
    /// notnull: The type must be a non-nullable value type that isn't a pointer type.
    /// new(): The type must have a public parameterless constructor.
    /// </summary>
    /// <typeparam name="K">input</typeparam>
    /// <typeparam name="T">output</typeparam>
    delegate T MyGenericDelegate<in K, out T>(K k) 
        where K: unmanaged //, notnull, new() 
        where T: notnull;
    static void Main(){
        void myMethod(int a){
            Console.WriteLine(a);
        }

        
        MyDelegate myDelegate1 = Console.WriteLine;
        myDelegate1 += myMethod;

        var del1 = new MyDelegate(Console.WriteLine);
        var del2 = new MyDelegate(myMethod);

        MyDelegate myDelegate2 = del1 + del2;

        myDelegate1(2);


        MyDelegate myDelegate3 = (int a)=> Console.WriteLine(a);
        MyDelegate myDelegate4 = delegate (int a){Console.WriteLine(a);};
        

        myDelegate1 += myDelegate3+ myDelegate4;

        myDelegate1(4);

        Predicate<int> isEven = (int a) => a%2 == 0;

        Console.WriteLine(isEven(5));

        Func<int, int, int> add = (int a, int b) => a+b;
        Console.WriteLine(add(5, 10));

        Action<object> print = (a) => Console.WriteLine(a.ToString());
        print(5);

        MyGenericDelegate<int, string> myGenericDelegate = (k) => "1";
        myGenericDelegate += (k) => "2";
        myGenericDelegate += (k) => "3";

        Console.WriteLine(myGenericDelegate(700));

        /// delegate equality is name based
        Delegate del3 = delegate (int a){Console.WriteLine(a);};
        Delegate del4 = delegate (int a){Console.WriteLine(a);};
        Console.WriteLine(del3.Equals(del4));

        Console.WriteLine(myGenericDelegate.DynamicInvoke(400));
        Console.WriteLine(myGenericDelegate.GetInvocationList().Length);
    }

    
}
