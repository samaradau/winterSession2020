using System;
using YSamaradau_OOP_2.VFS;

namespace YSamaradau_OOP_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var vfs = VFSFactory.GetVFS(VFSParams.FAT32);
            vfs.Mount(new Directory("somePath"), "somepath");
            var mounted = vfs.GetMountedPoints();

            foreach (var item in mounted)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
