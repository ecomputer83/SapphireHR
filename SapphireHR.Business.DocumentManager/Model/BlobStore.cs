using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SapphireHR.Business.DocumentManager.Model
{
    public class BlobStore
    {
        public string ContentType { get; set; }
        public string FileName { get; set; }
        public long FileLength { get; set; }
        public Stream FileStream { get; set; }
    }
}
