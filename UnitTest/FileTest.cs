using DataStructure;
namespace UnitTest;

public class FileTest
{
    [Fact]
    public void ShouldCreateFile()
    {
        var path = "../text.txt";
        File.Create(path);
        Assert.True(File.IsExists(path));
    }
}