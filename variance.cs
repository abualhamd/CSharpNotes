namespace VarianceSpace
{
    public static class DemoClass{
        public static void demo(){
            /// Contravariance
            IComparer<object> objComparer = Comparer<object>.Default;
            // IComparer<string> stringComparer = objComparer;

            List<string> words = new List<string> { "Banana", "Apple", "Cherry" };
            Console.WriteLine("words before sorting with objectComparer:");
            foreach (var word in words){
                Console.Write(word+" ");
            }

            Console.WriteLine("");
            words.Sort(objComparer);

            Console.WriteLine("words after sorting with objectComparer:");
            foreach (var word in words){
                Console.Write(word+" ");
            }
            /// Covariance
            IEnumerable<string> strings = new List<string> { "Banana", "Apple", "Cherry" };
            IEnumerable<object> objects = strings;

            /// Invariance
            List<string> strings2 = ["Banana", "Apple", "Cherry"];
            List<object> objects2 = ["Banana", "Apple", "Cherry"];
            // objects2 = strings2; // Error
            objects2 = strings2.Select(s => (object)s).ToList();
        }
    }
}