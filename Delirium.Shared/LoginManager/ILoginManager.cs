using System;

namespace Delirium.Shared
{
    public interface ILoginManager
    {
        event EventHandler<LoginErrorEventArgs> LoginError;
        event EventHandler<SucceedEventArgs> Succeed;
        void Join(Identity identity);
        void Login(Identity identity);
        void Logout();
    }
}
