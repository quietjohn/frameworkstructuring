using System;
using Interface;
using Framework.Interface;

namespace Framework
{
	public class CompositionFacade
	{
		public static void Run(IApp app)
		{
			//If using Facade helper, this is framework composition route. Wire up and run framework here. Possible place for framework DI container
			IInternal intrnl = new InternalComponent();
			IService srv = new FrameworkService();
			IFrameworkCore framework = new FrameworkCore(srv, intrnl);
			
			framework.Run(app);
		}
	}
}