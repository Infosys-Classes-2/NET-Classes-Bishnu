using System;
using System.IO;

public class Assignment5
{
    public void ListFileFolders()
    {
        string folderPath = @"D:\Downloads";

        var files = Directory.EnumerateFiles(folderPath);
        var folders = Directory.EnumerateDirectories(folderPath);

        string infoTable = "File/Folder Name\t\tCreated Date\t\tSize\t\tIsFile\n";

        foreach (var file in files)
        {
            FileInfo fi = new(file);
            var fileInfo = $"{fi.Name}\t\t{fi.CreationTime}\t\t{GetFileSize(fi.Length)}\t\tTrue\n";
            infoTable += fileInfo;
        }

        Console.WriteLine(infoTable);
    }

    string GetFileSize(long lenInBytes)
    {
        var lenInKb = (float)lenInBytes / 1024;
        if (lenInKb > 1024)
        {
            var lenInMb = lenInKb / 1024;
            if (lenInMb > 1024)
            {
                var lenInGb = lenInMb / 1024;
                return $"{lenInGb} Gb";
            }
            else
                return $"{lenInMb} Mb";
        }
        else
            return $"{lenInKb} Kb";
    }
}