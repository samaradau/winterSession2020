using System;
using YSamaradau_OOP_2.VFS.Interfaces;

namespace YSamaradau_OOP_2.VFS
{
    public class VFSFactory
    {
        public IVFS GetVFS(VFSParams vfsParam)
        {
            switch (vfsParam)
            {
                case VFSParams.Get:
                    break;
            }

            throw new NotImplementedException();
        }
    }
}
