using System;

namespace Task1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    interface ISomeInterface
    {
        public int X { get; set; }
        public string Foo(string arg1);
        public void Bar(int number);
    }

    class A : ISomeInterface
    {
        public int X { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Y { get; set; }

        public void Bar(int number)
        {
            throw new NotImplementedException();
        }

        public string Foo(string arg1)
        {
            throw new NotImplementedException();
        }

        public A Process(A a)
        {
            return new A();
        }
    }

    class B : ISomeInterface
    {
        public int X { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Bar(int number)
        {
            throw new NotImplementedException();
        }

        public string Foo(string arg1)
        {
            throw new NotImplementedException();
        }

        private void DoSomething(double a)
        {

        }
    }

    class Consumer
    {
        public void UseSomeInterface(ISomeInterface o)
        {

        }
    }
}
