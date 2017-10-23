namespace FS.File_System
{
    public interface IFileSystemFactory
    {
        IFile CreateFile(string name, int size, bool isText = false);
        IFolder CreateFolder(string name);
    }

    public class NtfsFactory : IFileSystemFactory
    {
        public IFile CreateFile(string name, int size, bool isText = false) => new NtfsFile(name, size, isText);
        public IFolder CreateFolder(string name) => new NtfsFolder(name);
    }

    public class ExtFactory : IFileSystemFactory
    {
        public IFile CreateFile(string name, int size, bool isText = false) => new ExtFile(name, size, isText);

        public IFolder CreateFolder(string name)
        {
            return new ExtFolder(name);
        }
    }
}