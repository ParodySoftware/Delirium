namespace Delirium.Shared
{
    public class SucceedEventArgs
    {
        public SucceedEventArgs(RedirectionType redirectionType)
        {
            this.RedirectionType = redirectionType;
        }

        public RedirectionType RedirectionType { get; private set; }
    }
}
