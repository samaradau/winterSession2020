using System.Collections.Generic;
using System.Linq;
using YSamaradau_OOP_2.VFS.Interfaces;

namespace YSamaradau_OOP_2.VFS
{
    public class Directory : IDirectory
    {
        public string Path { get; }

        public Directory(string path)
        {
            Path = path;
        }

        public override string ToString()
        {
            return Path;
        }

        public IEnumerable<IFile> GetFiles()
        {
            var result = System.IO.Directory.GetFiles(Path).ToList().Select(x => new File(x));
            return result;
        }
    }
}
