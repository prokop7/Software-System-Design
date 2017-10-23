using FS.File_System;

namespace FS.Visitors
{
    public interface IVisitor
    {
        void Visit(IFile file);
        void Visit(IFolder folder);
    }
}