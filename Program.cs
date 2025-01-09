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
  
class Program
{
    static void Main(){
        // var calc = new Calculator();
        
        // var result = calc.Add(5, 10);

        // Console.WriteLine(result);

        // var unitConverter = new UnitConverter(100);
        // var result = unitConverter.Convert(5);
        // Console.WriteLine(result);

        StringBuilder sb = new();

        sb.Append("Hello, ");
        sb.Append("World!");

        Console.WriteLine(sb.ToString());

    }
}
