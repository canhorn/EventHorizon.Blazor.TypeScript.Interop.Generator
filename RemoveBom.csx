private static void removeBoms(string filePattern, string directory)
{
    foreach (string filename in Directory.GetFiles(directory, filePattern))
    {
        var bytes = System.IO.File.ReadAllBytes(filename);
        if(bytes.Length > 2 && bytes[0] == 0xEF && bytes[1] == 0xBB && bytes[2] == 0xBF)
        {
            System.IO.File.WriteAllBytes(filename, bytes.Skip(3).ToArray()); 
        }
    }
    foreach (string subDirectory in Directory.GetDirectories(directory))
    {
        removeBoms(filePattern, subDirectory);
    }
}

string filePattern = "*";
string startDirectory = Directory.GetCurrentDirectory();
removeBoms(filePattern, startDirectory);            