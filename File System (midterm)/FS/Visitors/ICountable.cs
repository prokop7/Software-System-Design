namespace FS.Visitors
{
    public interface ICountable
    {
        void Accept(IVisitor visitor);
    }
}