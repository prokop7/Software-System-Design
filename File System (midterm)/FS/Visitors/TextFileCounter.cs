using FS.File_System;

namespace FS.Visitors
{
    public class TextFileCounter : IVisitor
    {
        public int Counter { get; private set; } = 0;

        public void Visit(IFile c) => Counter += c.IsTextFile ? 1 : 0;

        public void Visit(IFolder folder)
        {
            foreach (var folderComponent in folder.Components)
            {
                var counter = new TextFileCounter();
                folderComponent.Accept(counter);
                Counter += counter.Counter;
            }
        }
    }
}