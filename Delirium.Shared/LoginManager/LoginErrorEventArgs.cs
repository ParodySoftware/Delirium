namespace Delirium.Shared
{
    public class LoginErrorEventArgs
    {
        public LoginErrorEventArgs(string message)
        {
            this.Message = message;
        }

        public string Message { get; private set; }
    }    
}
