namespace DataStructure;

public static class File
{
    public static string Create(string path)
    {
        if (IsExists(path))
            return path;
        System.IO.File.Create(path);
        return path;
    }
    public static bool IsExists(string path)
       => System.IO.File.Exists(path);

}

