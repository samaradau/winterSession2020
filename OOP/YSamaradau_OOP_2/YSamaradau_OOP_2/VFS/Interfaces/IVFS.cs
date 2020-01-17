using System.Collections.Generic;

namespace YSamaradau_OOP_2.VFS.Interfaces
{
    public interface IVFS
    {
        IVFSObject CreateDirectory(string path);

        IVFSObject CreateFile(string path, string fileName);

        void Mount(IMountPoint mountPoint, string mountPath);

        void Unmount(IMountPoint mountPoint);

        IEnumerable<IMountPoint> GetMountedPoints();
    }
}
