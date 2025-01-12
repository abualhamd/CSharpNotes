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
    static void Main(){
        // var calc = new Calculator();
        
        // var result = calc.Add(5, 10);

        // Console.WriteLine(result);

        // var unitConverter = new UnitConverter(100);
        // var result = unitConverter.Convert(5);
        // Console.WriteLine(result);

        // Point2D point1 = new (3,4);
        // Point2D point2 = new (3,4);


        // Console.WriteLine(point1.Equals(point2));

        // Point3D point3 = new (3,4,5);
        // Point3D point4 = new (3,4,5);

        // Console.WriteLine(point3.Equals(point4));


        // Point2D point5 = new Point2D();

        // Console.WriteLine(point5.Magnitude.ToString());

        F.G g = new();

        Console.WriteLine(g.GetType());
    }
}
