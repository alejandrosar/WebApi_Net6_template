using System.Reflection.Metadata;

namespace Entities.LongFile
{
    public class LongFile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public byte[] File { get; set; }
    }
}
