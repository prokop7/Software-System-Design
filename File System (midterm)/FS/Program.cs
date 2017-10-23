using System;
using FS.File_System;
using FS.Visitors;

namespace FS
{
    public static class Program
    {
        /// <summary>
        /// The first task was implemented the same as it was in the midterm. 
        /// Was changed only the one thing, were added interfaces for capability to solve the third part of task.
        /// During exam I didn't read third part before had done the first. 
        /// I couldn't know about using interfaces in future.
        /// First part contains: ExtFile.cs, ExtFolder.cs, IFile.cs, IComponent.cs, IFolder.cs
        /// 
        /// 
        /// Second task was not implemented during the exam.
        /// So, now it fully completed.
        /// Second part contains: ICountable.cs, IVisitor.cs, TextFileCounter.cs
        /// 
        /// For the third part mostly I didn't change schema, only used interfaces instead of abstract classes.
        /// The code from the exam also remains almost the same.
        /// Third part contains: FileSystemFactory.cs, NtfsFolder.cs, NtfsFile.cs
        /// 
        /// For each non-abstract class was added constructor with certain parameters. 
        /// During exam we hadn't much time and space to do that.
        /// 
        /// Below you can see example of using this system.
        /// This class could be counted as a User.
        /// </summary>
        public static void Main()
        {
            var ntfsFactory = new NtfsFactory();

            var root = ntfsFactory.CreateFolder("root");
            var file1 = ntfsFactory.CreateFile("a", 5);
            var file2 = ntfsFactory.CreateFile("b", 15, true);
            var file3 = ntfsFactory.CreateFile("c", 50, true);
            var file4 = ntfsFactory.CreateFile("d", 10);
            var folder1 = ntfsFactory.CreateFolder("New Folder");
            folder1.Components.Add(file3);
            folder1.Components.Add(file2);
            folder1.Components.Add(file4);
            root.Components.Add(file1);
            root.Components.Add(folder1);
            var visitor = new TextFileCounter();
            root.Accept(visitor);

            Console.WriteLine(root.Size);
            Console.WriteLine(visitor.Counter);
        }
    }
}