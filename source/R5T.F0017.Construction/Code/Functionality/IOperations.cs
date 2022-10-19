using System;

using R5T.T0132;
using R5T.T0140;


namespace R5T.F0017.Construction
{
	[FunctionalityMarker]
	public partial interface IOperations : IFunctionalityMarker
	{
		public void GetClosedGenericTypeName()
        {
			var type = typeof(ExampleClass01<ExampleClass00>);

			var typeIdentityName = Instances.IdentityNameProvider.GetIdentityName(type);

			Console.Write($"{type.FullName}\n{typeIdentityName}\n");
        }

		public void GetMethodName()
        {
			var methodName = Instances.ReflectedInstanceContextProvider.InExampleMethodContext(
				typeof(ExampleMethods<>),
				"Method106",
				methodInfo => Instances.IdentityNameProvider.GetIdentityName(methodInfo));
		}
	}
}