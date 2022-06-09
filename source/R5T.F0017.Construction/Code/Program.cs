using System;


namespace R5T.F0017.Construction
{
    static class Program
    {
        static void Main()
        {
            Program.GetMethodName();
        }

        private static void GetMethodName()
        {
            var methodName = Instances.ReflectedInstanceContextProvider.InExampleMethodContext(
                typeof(F002.V000.T000.ExampleMethods<>),
                "Method106",
                methodInfo => Instances.IdentityNameProvider.GetIdentityName(methodInfo));
        }
    }
}