using System;

namespace Delirium.Shared
{
    public class LoginManager : ILoginManager
    {
        #region Construction

        public LoginManager()
        {
        } 

        #endregion

        #region ILoginManager

        public void Join(Identity identity)
        {
            throw new NotImplementedException();
        }

        public void Login(Identity identity)
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public event EventHandler<LoginErrorEventArgs> LoginError;

        protected virtual void OnLoginError(LoginErrorEventArgs e)
        {
            if (LoginError != null)
            {
                LoginError(this, e);
            }
        }

        public event EventHandler<SucceedEventArgs> Succeed;

        protected virtual void OnSucceed(SucceedEventArgs e)
        {
            if (Succeed != null)
            {
                Succeed(this, e);
            }
        } 

        #endregion
    }
}
