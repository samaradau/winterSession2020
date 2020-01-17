using System;
using YSamaradau_OOP_2.VFS.Interfaces;

namespace YSamaradau_OOP_2.VFS
{
    public class VFSFactory
    {
        public static IVFS GetVFS(VFSParams vfsParam)
        {
            switch (vfsParam)
            {
                case VFSParams.NTFS:
                    return new NTFS();
                    break;
                case VFSParams.FAT32:
                    return new FAT32();
            }

            throw new NotImplementedException();
        }
    }
}
