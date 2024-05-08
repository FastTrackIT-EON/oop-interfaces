using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFileSystem fileSystem = new PhysicalFileSystem();

            //TextFile textFile = new TextFile(
            //    @"D:\FastTrackIT\EON\oop-interfaces\OopInterfaces\OopInterfaces\TextFile.txt");

            XmlFile xmlFile = new XmlFile();

            DownloadManager downloadManager = new DownloadManager(fileSystem);
            downloadManager.DownloadAndSaveFile(xmlFile, "DownloadedFile.txt");
        }
    }
}
