using System.Collections.Generic;

namespace YSamaradau_OOP_2.VFS.Interfaces
{
    public interface IDirectory : IMountPoint
    {
        IEnumerable<IFile> GetFiles();
    }
}
