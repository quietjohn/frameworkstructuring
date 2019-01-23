using System;
using Interface;
using Framework.Interface;

namespace Framework
{
	public class FrameworkCore : IFrameworkCore
	{
		private IService _service;
		private IInternal _internal;

		public FrameworkCore(IService srv, IInternal intrnl)
        {
            _service = srv;
			_internal = intrnl;
        }

		public void Run(IApp app)
		{
			//Here would be framework's inner loop (but this just executes once)
			_internal.DoSomething();
            app.Init();
            app.Update(_service);
            app.Shutdown();
		}
	}
}