namespace DataStructure;

public class FileUtils
{
    public string Create(string path)
    {
        if (IsExists(path))
            return path;
        File.Create(path);
        return path;
    }
    public bool IsExists(string path)
       => File.Exists(path);

}

