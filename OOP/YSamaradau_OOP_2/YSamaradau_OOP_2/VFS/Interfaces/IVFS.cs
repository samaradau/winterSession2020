namespace YSamaradau_OOP_2.VFS.Interfaces
{
    public interface IVFS
    {
        IVFSObject CreateDirectory(string rootPath, string directoryName);

        IVFSObject CreateFile(string path, string fileName);

        void Mount(string partition, IMountPoint mountPoint, string mountPath);

        void Unmount(IMountPoint mountPoint);
    }
}
