using System.IO;

namespace OopInterfaces
{
    public class PhysicalFileSystem : IFileSystem
    {
        public void SaveFile(string path, byte[] content)
        {
            File.WriteAllBytes(path, content);
        }
    }
}
