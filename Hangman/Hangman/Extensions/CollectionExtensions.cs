internal static class CollectionExtensions
{
    private static readonly Random Random = new();

    public static T RandomElement<T>(this IList<T> list)
    { 
        return list[Random.Next(list.Count)];
    }
}