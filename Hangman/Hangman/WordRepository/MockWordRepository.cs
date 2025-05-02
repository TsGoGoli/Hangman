internal class MockWordRepository : IWordRepository
{
    public List<string> GetWords()
    {
        List<string> words = ["Immutable", "Abstract", "Cascade", "Paradigm"];

        return words;
    }
}