using System;
using System.Collections.Generic;
using YSamaradau_OOP_2.VFS.Interfaces;

namespace YSamaradau_OOP_2.VFS
{
    public class FAT32 : IVFS
    {
        private Dictionary<string, string> mountedPoints = new Dictionary<string, string>();
        private string logPrefix = $"{nameof(FAT32)} :: ";
        public IVFSObject CreateDirectory(string path)
        {
            System.IO.Directory.CreateDirectory(path);
            Console.WriteLine($"{logPrefix}Directory with path {path} has been created");
            return new Directory(path);
        }

        public IVFSObject CreateFile(string path, string text)
        {
            using (var sr = System.IO.File.CreateText(path))
            {
                sr.Write(text);
            }

            Console.WriteLine($"{logPrefix}File with path {path} has been created");
            return new File(path);
        }

        public void Mount(IMountPoint mountPoint, string mountPath)
        {
            var path = ((Directory)mountPoint).Path;
            mountedPoints.Add(path, mountPath);

            Console.WriteLine($"{logPrefix}Point with path {path} has been mounted");
        }

        public void Unmount(IMountPoint mountPoint)
        {
            var path = ((Directory)mountPoint).Path;
            mountedPoints.Remove(path);
            Console.WriteLine($"{logPrefix}Point with path {path} has been mounted");
        }

        public IEnumerable<IMountPoint> GetMountedPoints()
        {
            foreach (var item in mountedPoints)
            {
                yield return new Directory(item.Key);
            }
        }
    }
}
