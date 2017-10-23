using FS.Visitors;

namespace FS.File_System
{
    public interface IComponent : ICountable
    {
        string Name { get; set; }
        int Size { get; set; }
    }
}