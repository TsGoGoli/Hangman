public class FileWordRepository : IWordRepository
{
    private readonly string _filePath = @"..\..\..\TextFiles\words.txt";
    public List<string> GetWords()
    {
        if (!File.Exists(_filePath)) throw new FileNotFoundException($"File does not exists on '{_filePath}' path!");
        return File.ReadAllLines(_filePath).ToList();
    }
}