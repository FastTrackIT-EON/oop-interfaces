using System;
using System.IO;

namespace OopInterfaces
{
    public class TextFile : IDownloadableFile
    {
        public TextFile(string path)
        { 
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentNullException(
                    paramName: nameof(path),
                    message: "The path cannot be null or empty or whitespaces only");
            }

            if (!File.Exists(path))
            {
                throw new FileNotFoundException(
                    message: $"The file '{path}' was not found",
                    fileName: path);
            }

            Path = path;
        }

        public string Path { get; }

        public byte[] Download()
        {
            return File.ReadAllBytes(Path);
        }
    }
}
