using System.IO;

namespace OopInterfaces
{
    public class XmlFile : IDownloadableFile
    {
        public byte[] Download()
        {
            return File.ReadAllBytes(@"D:\FastTrackIT\EON\oop-interfaces\OopInterfaces\OopInterfaces\XMLFile.xml");
        }
    }
}
