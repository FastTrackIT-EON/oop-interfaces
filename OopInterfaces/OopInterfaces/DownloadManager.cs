using System.IO;

namespace OopInterfaces
{
    public class DownloadManager
    {
        private readonly IFileSystem _fileSystem;

        public DownloadManager(IFileSystem fileSystem)
        {
            _fileSystem = fileSystem;
        }

        public void DownloadAndSaveFile(
            IDownloadableFile file,
            string fileName)
        {
            byte[] fileBytes = file.Download();

            _fileSystem.SaveFile(fileName, fileBytes);
        }
    }
}
