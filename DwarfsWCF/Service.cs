using System;
using System.IO;

namespace DwarfsWCF
{
    public class Service : IService
    {
        public MemoryStream GetStream(string path)
        {
            MemoryStream mm = new MemoryStream();

            using (FileStream stream = File.OpenRead(path))
            {
                stream.CopyTo(mm);
            }
            return mm;
        }

        public string GetString(string text)
        {
            return string.Format($"You entered: {text}");
        }
    }
}
