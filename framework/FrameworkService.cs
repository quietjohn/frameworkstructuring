using System;
using Interface;

namespace Framework
{
	public class FrameworkService : IService
	{
		public void UseFrameworkService()
		{
			Console.WriteLine("CALLING SERVICE");
		}
	}
}