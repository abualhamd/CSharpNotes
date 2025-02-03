namespace Interfces
{
    interface IMyInterface
    {
         void FirstMethodToImplement();
         void SecondMethodToImplement();

        static void StaticMethod()
        {
            Console.WriteLine("IMyInterface StaticMethod() called.");
        }
        public void DefaultMethod()
        {
            Console.WriteLine("IMyInterface DefaultMethod() called.");
        }

        static int StaticProperty { get; set; }
         const int Constant = 5;
    }

    public class ClassImplementInterface : IMyInterface
    {
         public void FirstMethodToImplement()
        {
            Console.WriteLine("ClassImplementInterface FirstMethodToImplement() called.");
        }

        internal void DefaultMethod()
        {
            Console.WriteLine("ClassImplementInterface DefaultMethod() called.");
        }

        void IMyInterface.SecondMethodToImplement()
        {
            Console.WriteLine("ClassImplementInterface SecondMethodToImplement() called.");
        }
    }

    public class ExtendClass : ClassImplementInterface
    {

    }

    public struct StructImplementInterface : IMyInterface
    {
        public void FirstMethodToImplement()
        {
            Console.WriteLine("StructImplementInterface FirstMethodToImplement() called.");
        }

        void IMyInterface.SecondMethodToImplement()
        {
            Console.WriteLine("StructImplementInterface SecondMethodToImplement() called.");
        }
    }

    interface VarianceInterface< out Y, in X>
    {
        Y M(X x);

        
    }

    public class VarianceClassImpl<T, K> : VarianceInterface<K, T> where K: new()
    {
        public K M(T b)
        {
            return new K();
        }
    }

    class DummyClass
    {
        public DummyClass()
        {
            Console.WriteLine("DummyClass constructor called.");
        }
    }

    class DummyClassChild : DummyClass
    {
        public DummyClassChild()
        {
            Console.WriteLine("DummyClassChild constructor called.");
        }
    }


    

    public static class DemoClass{
        public static void demo(){
            /// interface implementation
            IMyInterface classImplementation = new ClassImplementInterface();
            IMyInterface extendClassImplementation = new ExtendClass();
            IMyInterface structImplementation = new StructImplementInterface();


            classImplementation.FirstMethodToImplement();
            classImplementation.SecondMethodToImplement();
            extendClassImplementation.SecondMethodToImplement();
            structImplementation.FirstMethodToImplement();
            structImplementation.SecondMethodToImplement();

            /// Variance
            VarianceClassImpl<DummyClassChild, DummyClass> varianceClassImpl = new ();
            DummyClass dummyClassChild = varianceClassImpl.M(new DummyClassChild());


            ///
            ClassImplementInterface implementationClass = new ();
            StructImplementInterface implementationStruct = new ();

            implementationClass.DefaultMethod();
            // implementation.SecondMethodToImplement(); // Error
            // implementationStruct.SecondMethodToImplement(); // Error
            classImplementation.DefaultMethod();
            structImplementation.DefaultMethod();

            IMyInterface.StaticProperty = 5;
            Console.WriteLine(IMyInterface.StaticProperty);
            Console.WriteLine(IMyInterface.Constant);
        }
    }
}