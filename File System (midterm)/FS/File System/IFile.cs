namespace FS.File_System
{
    public interface IFile : IComponent
    {
        bool IsTextFile { get; }
    }
}