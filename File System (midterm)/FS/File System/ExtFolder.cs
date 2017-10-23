using System;
using System.Collections.Generic;
using System.Linq;
using FS.Visitors;

namespace FS.File_System
{
    public class ExtFolder : IFolder
    {
        /// <param name="s">Name of the folder</param>
        public ExtFolder(string s)
        {
            Name = s;
        }
        
        /// <summary>
        /// List of Subfolders and files.
        /// </summary>
        public List<IComponent> Components { get; set; } = new List<IComponent>();

        public string Name { get; set; }

        /// <exception cref="NotImplementedException">Size cannot be set for the folder. 
        /// But the "set" method is required for compatability with interface (C# restriction)</exception>
        public int Size
        {
            get { return Components.Sum(_ => _.Size); }
            set { throw new NotImplementedException(); }
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}