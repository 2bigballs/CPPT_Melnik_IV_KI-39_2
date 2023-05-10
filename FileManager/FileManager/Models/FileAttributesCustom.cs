

namespace FileManager.Models
{
    public class FileAttributesCustom
    {
        public string Name { get; set; }
        public string FullPath { get; set; }
        public string Owner { get; set; }
        public long Size { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastWriteTime { get; set; }
        public DateTime LastAccessTime { get; set; }
        public string FlagAttribute { get; set; }
    }
}
