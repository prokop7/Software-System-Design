using FS.Visitors;

namespace FS.File_System
{
    public class NtfsFile : IFile
    {
        public NtfsFile(string name, int size, bool isText)
        {
            Name = name;
            Size = size;
            IsTextFile = isText;
        }

        public string Name { get; set; }
        public int Size { get; set; }
        public bool IsTextFile { get; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}