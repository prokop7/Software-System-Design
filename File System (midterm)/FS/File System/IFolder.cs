using System.Collections.Generic;

namespace FS.File_System
{
    public interface IFolder : IComponent
    {
        List<IComponent> Components { get; set; }
    }
}