using System;

namespace Interface
{
    public interface IApp
    {
        void Init();
        void Update(IService service);
        void Shutdown();
    }
}
