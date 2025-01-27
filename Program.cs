class Program
{
    static void Main(){
        int [] ints = new int[4] {1,2,3,4};

        foreach (var item in ints)
        {
            Console.WriteLine(item);
        } 

        //  var items = ints.Select(x=> x*x).ToArray();
         var items = Array.ConvertAll(ints, x=> x*x);

         foreach (var item in items)
        {
            Console.WriteLine(item);
        } 


        int[,] multiDimensionalArray = {{1,2}, {3,4}};

        Console.WriteLine(multiDimensionalArray.Length);

        var newInts = ints.Append(0).ToArray();

        Console.WriteLine(newInts.Length);

        int [][] jaggedArray = new int[3][];

        jaggedArray[0] =  [1,2];
        jaggedArray[1] =  [1,2,3];
        jaggedArray[2] =  [1,2,3,4];

        Console.WriteLine(jaggedArray.Length);
    }

    
}
