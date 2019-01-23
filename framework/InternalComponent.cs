using System;
using Framework.Interface;

namespace Framework
{
	public class InternalComponent : IInternal
	{
		public void DoSomething()
		{
			Console.WriteLine("DO SOMETHING INTERNAL");
		}
	}
}
