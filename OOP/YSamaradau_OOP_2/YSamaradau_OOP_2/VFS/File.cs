using YSamaradau_OOP_2.VFS.Interfaces;

namespace YSamaradau_OOP_2.VFS
{
    public class File : IFile
    {
        public string Path { get; }

        public File(string path)
        {
            Path = path;
        }
    }
}
