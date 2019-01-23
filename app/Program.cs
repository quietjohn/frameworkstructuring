using System;
using Framework;
using Interface;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            IApp app = new App();
            CompositionFacade.Run(app);
        }
    }
}