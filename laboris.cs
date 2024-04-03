public static T SelectRandomElement<T>(IEnumerable<T> source)
{
    if (source == null)
    {
        throw new ArgumentNullException(nameof(source), "The source collection cannot be null.");
    }

    if (!source.Any())
    {
        throw new InvalidOperationException("Cannot select an element from an empty collection.");
    }

    Random random = new Random();
    int index = random.Next(source.Count());
    return source.ElementAt(index);
}
