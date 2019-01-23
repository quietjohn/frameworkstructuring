using System;
using Interface;
    
namespace app
{
    public class App : IApp
    {
	    public void Init()
	    {
		    Console.WriteLine("INIT APP");
	    }

	    public void Update(IService service)
	    {
		    Console.WriteLine("UPDATE APP");
		    service.Update();
	    }

	    public void Shutdown()
	    {
		    Console.WriteLine("SHUTDOWN APP");
	    }
    }
}