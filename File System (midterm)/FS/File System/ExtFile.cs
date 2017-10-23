using FS.Visitors;

namespace FS.File_System
{
    public class ExtFile : IFile
    {
        public ExtFile(string s, int size, bool isTextFile = false)
        {
            Name = s;
            Size = size;
            IsTextFile = isTextFile;
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