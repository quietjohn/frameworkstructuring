using System;
using Interface;

namespace Framework
{
	public class FrameworkService : IService
	{
		public void Update()
		{
			Console.WriteLine("CALLING SERVICE");
		}
	}
}