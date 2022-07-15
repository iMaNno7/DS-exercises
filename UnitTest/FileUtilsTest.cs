using DataStructure;

namespace UnitTest;

public class FileUtilsTest
{
    private FileUtils fileUtils;
    public FileUtilsTest()
    {
        fileUtils = new FileUtils();
    }
    [Fact]
    public void ShouldCreateFile()
    {
        var path = "../text.txt";
        fileUtils.Create(path);
        Assert.True(fileUtils.IsExists(path));
    }

}